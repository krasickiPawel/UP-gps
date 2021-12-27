using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Globalization;

namespace GPS_1
{
    public partial class Form1 : Form
    {

        string width;
        string length;
        string data;
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenPort(string com)
        {
            try
            {
                serialPort = new SerialPort(com, 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                //serialPort.DataReceived += new SerialDataReceivedEventHandler(PortDataReceived);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.StackTrace + " " + e.Message, "Port error", MessageBoxButtons.OK);
            }
        }

        private void PortDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serialPort.ReadExisting();
        }

        private void ReadPort()
        {
            if (serialPort.IsOpen)
            {
                Thread.Sleep(2);
                string data = serialPort.ReadExisting();
                string[] lines = data.Split('$');
                foreach (string line in lines)
                {
                    string[] words = line.Split(',');
                    if (words[0] == "GPGGA")
                    {
                        
                        try
                        {
                            //Double width = Convert.ToDouble(words[2]);
                            string widthString = words[2];
                            string col1 = words[3];
                            //width = width / 100;
                            //string[] widthElements = width.ToString().Split('.');
                            //this.width = words[3] + widthElements[0] + "." + ((Convert.ToDouble(widthElements[1]) / 60)).ToString("#####");
                            //this.width = words[3] + width.ToString();

                            //Double length = Convert.ToDouble(words[4]);
                            string lengthString = words[4];
                            string col2 = words[5];

                            string heightString = words[9];
                            //length = length / 100;
                            //this.length = words[5] + length.ToString();
                            CultureInfo culture = CultureInfo.CreateSpecificCulture("en-GB");

                            double width = Double.Parse(widthString, culture);
                            double length = Double.Parse(lengthString, culture);
                            double height = Double.Parse(heightString, culture);
                            width /= 100;
                            length /= 100;

                            string wid = width.ToString();
                            string len = length.ToString();
                            string wid2 = wid.Replace(',', '.');
                            string len2 = len.Replace(',', '.');

                            this.width = wid2;
                            this.length = len2;

                            textWidth.Text = this.width;
                            textLength.Text = this.length;
                        }
                        catch
                        {
                            textWidth.Text = "GPS Unavailable";
                            textLength.Text = "GPS Unavailable";
                        }
                    }

                }

            }
            else
            {
                textWidth.Text = "COM Port Closed";
                textLength.Text = "COM Port Closed";
            }
        }

        private void ClosePort()
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }
        }

        private void ShowOnMap()
        {
            try
            {
                string result = this.width + "," + this.length;
                string address = "http://www.google.com/maps/place/";

                if (this.width != "" && this.length != "")
                {
                    address += result;
                }

                OpenURL(address);
            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.StackTrace + " " + e2.Message, "Map error", MessageBoxButtons.OK);
            }
        }

        private void OpenURL(string url)
        {
            try
            {
                System.Diagnostics.Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                url = url.Replace("&", "^&");
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo("cmd", $"/c start {url}") { CreateNoWindow = true });
            }
        }

        private void buttonLocationData_Click(object sender, EventArgs e)
        {
            OpenPort(textCOM.Text);
            ReadPort();
            ClosePort();
        }

        private void buttonShowMap_Click(object sender, EventArgs e)
        {
            ShowOnMap();
        }
    }
}
