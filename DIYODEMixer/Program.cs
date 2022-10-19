using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore.CoreAudioAPI;
using System.IO.Ports;
using System.Threading;

namespace DIYODEMixer
{
    internal static class Program
    {

        public static SerialPort _serialPort;
        public static String portName;

        public static MixerSource[] sources;
        public const int MAX_SOURCES = 20;

        volatile static List<String> audioProcesses;
        readonly static List<string> excludedProcesses = new List<string>(new[]
        {
             "Idle"
        });

        readonly static List<string> sliderAssignments = new List<string>(new[]
        {
             "Slider 1",
             "Slider 2",
             "Slider 3",
             "Disabled"
        });

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Task.Run(() => ScanForAudio());

            //OpenMixerCOM();
            //Task.Run(() => Read());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form = new Form1();
            audioProcesses = new List<String>();
            Console.WriteLine(audioProcesses.Count);
            bool scanningDone = false;
            Task.Run(() => ScanForAudio(out scanningDone));
            while (!scanningDone) ;
            audioProcesses.Remove("Idle");
            sources = new MixerSource[MAX_SOURCES];

            string[] names = SerialPort.GetPortNames();
            form.comPortBox.Items.AddRange(names);
            if(names.Length >= 1)
            {
                form.comPortBox.SelectedIndex = 0;
            }
            portName = names[0];
            StartMixerCOM();
            form.SetCOMDisconnected();

            int index = 0;
            foreach (String process in audioProcesses)
            {
                
                var sourceCombobox = new System.Windows.Forms.ComboBox();
                sourceCombobox.DropDownHeight = 150;
                sourceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                sourceCombobox.FormattingEnabled = true;
                sourceCombobox.IntegralHeight = false;
                sourceCombobox.ItemHeight = 13;
                sourceCombobox.Location = new System.Drawing.Point(140, 13);
                sourceCombobox.Name = "sourceCombobox" + index.ToString();
                sourceCombobox.Size = new System.Drawing.Size(130, 21);
                sourceCombobox.TabIndex = 1;
                sourceCombobox.Items.AddRange(sliderAssignments.ToArray());
                //Additional audio sources are initialized so that they are disabled.
                if(index >= 3)
                {
                    sourceCombobox.SelectedIndex = 3;
                } else
                {
                    sourceCombobox.SelectedIndex = index;
                }
                sources.Append(new MixerSource(process, MixerSource.intToChannel(index)));

                var applicationName = new System.Windows.Forms.Label();
                applicationName.AutoSize = true;
                applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                applicationName.Location = new System.Drawing.Point(9, 10);
                applicationName.Name = "applicationName";
                applicationName.Size = new System.Drawing.Size(54, 24);
                applicationName.TabIndex = 2;
                applicationName.Text = process;
                applicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                var sourcePanel = new System.Windows.Forms.Panel();
                sourcePanel.Controls.Add(sourceCombobox);
                sourcePanel.Controls.Add(applicationName);
                sourcePanel.Location = new System.Drawing.Point(3, 3);
                sourcePanel.Name = "sourcePanel" + index.ToString();
                sourcePanel.Size = new System.Drawing.Size(273, 48);
                //sourcePanel.TabIndex = 0;

                form.audioSourcePanel.Controls.Add(sourcePanel);
                index++;
            }

            /*foreach (String slider in sliderAssignments)
            {
                form.comboBox1.Items.Add(slider);
            }
            form.comboBox1.SelectedIndex = 0;*/
            //form.audioSourceTabs.TabPages.
            Task.Run(() => Read());
            Application.Run(form);

            
        }

        public static void StartMixerCOM()
        {
            _serialPort = new SerialPort();
            _serialPort.BaudRate = 115200;
            _serialPort.PortName = portName;
            _serialPort.ReadTimeout = 500;
            _serialPort.WriteTimeout = 500;
        }

        public static void OpenMixerCOM()
        {
            _serialPort.PortName = portName;
            _serialPort.Open();

            //Update mixer channels.
            for(int i = 0; i < audioProcesses.Count; i++)
            {
                UpdateMixerChannel(i, char.ToUpper(audioProcesses[i][0]) + audioProcesses[i].Substring(1));
            }
        }

        //Updates a channel name on the mixer.
        public static void UpdateMixerChannel(int channel, String name)
        {
            if (!_serialPort.IsOpen)
                return;

            string message = "CH#";
            message += channel.ToString();
            message += ":";
            message += name;

            _serialPort.WriteLine(message);
        }

        public static void CloseMixerCOM()
        {
            _serialPort.Close();
        }

        public static void Read()
        {
            while (true)
            {
                try
                {
                    if (!_serialPort.IsOpen)
                        continue;

                    string message = _serialPort.ReadLine().Trim();

                    

                    //If we're receiving a Vol update message, check it also has the required length.
                    //Format: CH#1:54<\n>
                    if (message.StartsWith("CH#") && message.Length > 5)
                    {
                        //This is a volume update message.
                        //First, let's find the channel number.
                        int channel = message[3] - '0';
                        //Now, let's find the volume level.
                        int volume = 0;
                        int.TryParse(message.Substring(5), out volume);
                        Console.Write("Channel: ");
                        Console.Write(channel);
                        Console.Write(", Volume: ");
                        Console.WriteLine(volume);
                        if(audioProcesses.Count > channel)
                        {
                            SetAudioLevel(audioProcesses[channel], (volume / 100f));
                        }
                        

                    }
                    
                }
                catch (TimeoutException) { }
            }
        }

        public static void SetAudioLevel(string name, float level)
        {
            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnumerator)
                    {
                        using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                        using (var sessionControl = session.QueryInterface<AudioSessionControl2>())
                        {

                            string processName = sessionControl.Process.ProcessName;
                           // processName = char.ToUpper(processName[0]) + processName.Substring(1);
                            //Console.WriteLine(processName);
                            if (processName == name)
                            {
                                simpleVolume.MasterVolume = level;
                            }
                        }
                    }
                }
            }
        }



        public static void ScanForAudio(out bool done)
        {
            //audioProcesses.Clear();
            using (var sessionManager = GetDefaultAudioSessionManager2(DataFlow.Render))
            {
                using (var sessionEnumerator = sessionManager.GetSessionEnumerator())
                {
                    foreach (var session in sessionEnumerator)
                    {
                        using (var simpleVolume = session.QueryInterface<SimpleAudioVolume>())
                        using (var sessionControl = session.QueryInterface<AudioSessionControl2>())
                        {
                            

                            string processName = sessionControl.Process.ProcessName;
                            audioProcesses.Add(processName);
                            //processName = char.ToUpper(processName[0]) + processName.Substring(1);
                            
                            /*Console.WriteLine(processName);
                            if (processName == "Spotify")
                            {
                                simpleVolume.MasterVolume = 0.3f;
                            }*/
                        }
                    }
                }
            }
            done = true;
        }

        private static AudioSessionManager2 GetDefaultAudioSessionManager2(DataFlow dataFlow)
        {
            using (var enumerator = new MMDeviceEnumerator())
            {
                using (var device = enumerator.GetDefaultAudioEndpoint(dataFlow, Role.Multimedia))
                {
                    Console.WriteLine("DefaultDevice: " + device.FriendlyName);
                    var sessionManager = AudioSessionManager2.FromMMDevice(device);
                    return sessionManager;
                }
            }
        }
    }
}