using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Management;
using System.Windows.Forms;

namespace FlashESP8266
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Check Com Ports
            UpdateElmts();

            cbx_firmware.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_serial.DropDownStyle = ComboBoxStyle.DropDownList;
            speed.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void UpdateElmts()
        {
            string[] ports = SerialPort.GetPortNames();
            //Check Firmware files
            string[] fileArray = Directory.GetFiles(@".", "*.bin");
            cbx_serial.Items.Clear();
            ComPortBkp.Items.Clear();

            //Fill out the Combobox with serial Ports
            foreach (var port in ports)
            {
                cbx_serial.Items.Add(port);
                cbx_serial.Text = port;
                ComPortBkp.Items.Add(port);
                ComPortBkp.Text = port;
            }


            cbx_firmware.Items.Clear();
            //Fill out the Combobox with Firmware Files
            foreach (var files in fileArray)
            {
                cbx_firmware.Items.Add(files);
            }
        }

        private void bttn_flash_Click(object sender, EventArgs e)
        {
            string serial = this.cbx_serial.GetItemText(this.cbx_serial.SelectedItem);
            string firmware = this.cbx_firmware.GetItemText(this.cbx_firmware.SelectedItem);

            if (serial == "")
            {
                MessageBox.Show("Please select Com-Port!");
            }
            if (firmware == "")
            {
                MessageBox.Show("Please select Firmware!");
            }

            if (firmware != "" & serial != "")
            {

                string cmd = "esptool.exe";
                //Flash Arguments for the esptool.exe. Change when needed.
                string arg = "--port " + serial + " --baud "+speed.Text+" write_flash 0x0 " + firmware;

                Process myProcess = null;

                try
                {
                    // Start the process.
                    myProcess = Process.Start(cmd, arg);

                    while (!myProcess.WaitForExit(1000));

                    if (myProcess.ExitCode != 0)
                    {
                        MessageBox.Show("Flash Failed with arg" +arg+ " are the Settings correct?");
                    }
                    else
                    {
                        MessageBox.Show("Flash Complete");
                    }

                }
                finally
                {
                    if (myProcess != null)
                    {
                        myProcess.Close();
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void backupClick(object sender, EventArgs e)
        {
            
            string serial = this.cbx_serial.GetItemText(this.ComPortBkp.SelectedItem);
            string firmware = this.fileName.Text;

            string filesize = this.cbx_serial.GetItemText(this.flashSize.Text);
            int i;
            if (filesize.Contains("MB"))
            {
                i = int.Parse(filesize.Replace("MB", ""))*1048576;
            }
            else
            {
                i = int.Parse(filesize.Replace("KB", ""))*1024;
            }
            filesize = i.ToString("X");
            


            if (serial == "")
            {
                MessageBox.Show("Please select Com-Port!");
            }
            if (firmware == "")
            {
                MessageBox.Show("Please select Firmware!");
            }

            if (firmware != "" & serial != "")
            {

                string cmd = "esptool.exe";
                //Flash Arguments for the esptool.exe. Change when needed.
                string arg = "--port " + serial + " --baud " + this.speed2.Text + " read_flash 0x0 "+ filesize +" " + firmware;

                Process myProcess = null;

                try
                {
                    // Start the process.
                    myProcess = Process.Start(cmd, arg);

                    while (!myProcess.WaitForExit(1000)) ;

                    if (myProcess.ExitCode != 0)
                    {
                        MessageBox.Show("Flash Failed with arg" + arg + " are the Settings correct?");
                    }
                    else
                    {
                        MessageBox.Show("Backup Complete");
                    }

                }
                finally
                {
                    if (myProcess != null)
                    {
                        myProcess.Close();
                    }
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            UpdateElmts();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            UpdateElmts();
        }
    }
}
