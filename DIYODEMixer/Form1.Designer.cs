namespace DIYODEMixer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comPortBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.statusText = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.audioSourcePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sourceCombobox = new System.Windows.Forms.ComboBox();
            this.applicationName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.audioSourcePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DIYODEMixer.Properties.Resources.image;
            this.pictureBox1.Location = new System.Drawing.Point(60, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(202, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Button Action:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownHeight = 150;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.IntegralHeight = false;
            this.comboBox2.ItemHeight = 13;
            this.comboBox2.Items.AddRange(new object[] {
            "Switch To Window",
            "Mute (Toggle)",
            "Mute (Momentary)",
            "Reduce Volume by 50%",
            "Reduce Volume by 90%"});
            this.comboBox2.Location = new System.Drawing.Point(116, 13);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(163, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "COM Port:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // comPortBox
            // 
            this.comPortBox.DropDownHeight = 150;
            this.comPortBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comPortBox.FormattingEnabled = true;
            this.comPortBox.IntegralHeight = false;
            this.comPortBox.ItemHeight = 13;
            this.comPortBox.Location = new System.Drawing.Point(33, 123);
            this.comPortBox.Name = "comPortBox";
            this.comPortBox.Size = new System.Drawing.Size(112, 21);
            this.comPortBox.TabIndex = 6;
            this.comPortBox.SelectedIndexChanged += new System.EventHandler(this.changeCOMPort);
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(163, 103);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(142, 43);
            this.connectButton.TabIndex = 7;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.toggleConnectButton_Click);
            // 
            // statusText
            // 
            this.statusText.AutoSize = true;
            this.statusText.Location = new System.Drawing.Point(110, 156);
            this.statusText.Name = "statusText";
            this.statusText.Size = new System.Drawing.Size(109, 13);
            this.statusText.TabIndex = 8;
            this.statusText.Text = "Status: Disconnected";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.audioSourcePanel);
            this.groupBox2.Location = new System.Drawing.Point(20, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 441);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Audio Sources";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(182, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 17);
            this.label8.TabIndex = 3;
            this.label8.Text = "Mixer Channel";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Application Name";
            // 
            // audioSourcePanel
            // 
            this.audioSourcePanel.Controls.Add(this.panel1);
            this.audioSourcePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.audioSourcePanel.Location = new System.Drawing.Point(3, 48);
            this.audioSourcePanel.Name = "audioSourcePanel";
            this.audioSourcePanel.Size = new System.Drawing.Size(282, 390);
            this.audioSourcePanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sourceCombobox);
            this.panel1.Controls.Add(this.applicationName);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 48);
            this.panel1.TabIndex = 3;
            this.panel1.Visible = false;
            // 
            // sourceCombobox
            // 
            this.sourceCombobox.DropDownHeight = 150;
            this.sourceCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sourceCombobox.FormattingEnabled = true;
            this.sourceCombobox.IntegralHeight = false;
            this.sourceCombobox.ItemHeight = 13;
            this.sourceCombobox.Location = new System.Drawing.Point(140, 13);
            this.sourceCombobox.Name = "sourceCombobox";
            this.sourceCombobox.Size = new System.Drawing.Size(130, 21);
            this.sourceCombobox.TabIndex = 1;
            // 
            // applicationName
            // 
            this.applicationName.AutoSize = true;
            this.applicationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applicationName.Location = new System.Drawing.Point(9, 10);
            this.applicationName.Name = "applicationName";
            this.applicationName.Size = new System.Drawing.Size(54, 24);
            this.applicationName.TabIndex = 2;
            this.applicationName.Text = "Hello";
            this.applicationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(20, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(288, 39);
            this.panel2.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusText);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comPortBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "DIYODE Audio Mixer";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.audioSourcePanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox comPortBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Label statusText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label applicationName;
        public System.Windows.Forms.ComboBox sourceCombobox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.FlowLayoutPanel audioSourcePanel;
        private System.Windows.Forms.Panel panel2;
    }
}

