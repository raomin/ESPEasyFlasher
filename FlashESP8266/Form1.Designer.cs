namespace FlashESP8266
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
            this.bttn_flash = new System.Windows.Forms.Button();
            this.lbl_serial = new System.Windows.Forms.Label();
            this.cbx_serial = new System.Windows.Forms.ComboBox();
            this.lbl_firmware = new System.Windows.Forms.Label();
            this.cbx_firmware = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.speed = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.flashSize = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.speed2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ComPortBkp = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttn_flash
            // 
            this.bttn_flash.Location = new System.Drawing.Point(336, 164);
            this.bttn_flash.Name = "bttn_flash";
            this.bttn_flash.Size = new System.Drawing.Size(85, 29);
            this.bttn_flash.TabIndex = 0;
            this.bttn_flash.Text = "Flash";
            this.bttn_flash.UseVisualStyleBackColor = true;
            this.bttn_flash.Click += new System.EventHandler(this.bttn_flash_Click);
            // 
            // lbl_serial
            // 
            this.lbl_serial.AutoSize = true;
            this.lbl_serial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serial.Location = new System.Drawing.Point(33, 32);
            this.lbl_serial.Name = "lbl_serial";
            this.lbl_serial.Size = new System.Drawing.Size(74, 20);
            this.lbl_serial.TabIndex = 1;
            this.lbl_serial.Text = "COM-Port";
            // 
            // cbx_serial
            // 
            this.cbx_serial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_serial.FormattingEnabled = true;
            this.cbx_serial.Location = new System.Drawing.Point(113, 32);
            this.cbx_serial.Name = "cbx_serial";
            this.cbx_serial.Size = new System.Drawing.Size(279, 23);
            this.cbx_serial.TabIndex = 2;
            // 
            // lbl_firmware
            // 
            this.lbl_firmware.AutoSize = true;
            this.lbl_firmware.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firmware.Location = new System.Drawing.Point(37, 75);
            this.lbl_firmware.Name = "lbl_firmware";
            this.lbl_firmware.Size = new System.Drawing.Size(70, 20);
            this.lbl_firmware.TabIndex = 3;
            this.lbl_firmware.Text = "Firmware";
            // 
            // cbx_firmware
            // 
            this.cbx_firmware.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_firmware.FormattingEnabled = true;
            this.cbx_firmware.Location = new System.Drawing.Point(113, 76);
            this.cbx_firmware.Name = "cbx_firmware";
            this.cbx_firmware.Size = new System.Drawing.Size(279, 23);
            this.cbx_firmware.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Upload speed";
            // 
            // speed
            // 
            this.speed.FormattingEnabled = true;
            this.speed.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.speed.Location = new System.Drawing.Point(113, 125);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(121, 29);
            this.speed.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(459, 245);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.checkBox1);
            this.tabPage1.Controls.Add(this.bttn_flash);
            this.tabPage1.Controls.Add(this.cbx_firmware);
            this.tabPage1.Controls.Add(this.speed);
            this.tabPage1.Controls.Add(this.lbl_firmware);
            this.tabPage1.Controls.Add(this.cbx_serial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbl_serial);
            this.tabPage1.Location = new System.Drawing.Point(4, 30);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(451, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Upload";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label7.Location = new System.Drawing.Point(398, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 17);
            this.label7.TabIndex = 16;
            this.label7.Text = "";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(113, 174);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(162, 19);
            this.checkBox1.TabIndex = 7;
            this.checkBox1.Text = "DIO upload (slower, safer)";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.flashSize);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.fileName);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.speed2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.ComPortBkp);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 30);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(451, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Backup";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Font Awesome 5 Free Solid", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(413, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // flashSize
            // 
            this.flashSize.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flashSize.FormattingEnabled = true;
            this.flashSize.Items.AddRange(new object[] {
            "256KB",
            "512KB",
            "1MB",
            "2MB",
            "4MB",
            "2MB-c1",
            "4MB-c1",
            "8MB",
            "16MB"});
            this.flashSize.Location = new System.Drawing.Point(127, 156);
            this.flashSize.Name = "flashSize";
            this.flashSize.Size = new System.Drawing.Size(108, 25);
            this.flashSize.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Flash size";
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(127, 72);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(279, 29);
            this.fileName.TabIndex = 12;
            this.fileName.Text = "fw.bin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Backup to file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.backupClick);
            // 
            // speed2
            // 
            this.speed2.Font = new System.Drawing.Font("Segoe UI Semilight", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed2.FormattingEnabled = true;
            this.speed2.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.speed2.Location = new System.Drawing.Point(127, 116);
            this.speed2.Name = "speed2";
            this.speed2.Size = new System.Drawing.Size(108, 25);
            this.speed2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Filename";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Upload speed";
            // 
            // ComPortBkp
            // 
            this.ComPortBkp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPortBkp.FormattingEnabled = true;
            this.ComPortBkp.Location = new System.Drawing.Point(127, 39);
            this.ComPortBkp.Name = "ComPortBkp";
            this.ComPortBkp.Size = new System.Drawing.Size(279, 23);
            this.ComPortBkp.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "COM-Port";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 252);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ESPEasy Flasher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bttn_flash;
        private System.Windows.Forms.Label lbl_serial;
        private System.Windows.Forms.ComboBox cbx_serial;
        private System.Windows.Forms.Label lbl_firmware;
        private System.Windows.Forms.ComboBox cbx_firmware;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox speed;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox speed2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComPortBkp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox flashSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

