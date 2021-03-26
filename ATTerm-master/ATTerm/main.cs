// 
// MHC
//  https://github.com/markharleycarson/ATTerm 
//  https://github.com/markharleycarson/ATTerm 
//  https://github.com/markharleycarson/ATTerm 
// 20200409
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.Net.Sockets;
using System.Diagnostics;
using System.Reflection;

namespace ATTerm
{
    public partial class Form1 : Form
    {
        char rxd;
        string[] ports;
        SerialPort serialPort1;
        System.Diagnostics.Stopwatch sw = new Stopwatch();
        // delegate is used to write to a UI control from a non-UI thread  
        private delegate void SetTextDeleg(string text);
        bool bolConnected = false;
        int number = 0;
        int startTime = 0;
        string message = "";

        public Form1()
        {

            InitializeComponent();

            ports = SerialPort.GetPortNames();     
            cmbBaud.Items.Add(1200);
            cmbBaud.Items.Add(4800);
            cmbBaud.Items.Add(9600);             
            cmbBaud.Items.Add(19200);
            cmbBaud.Items.Add(38400);
            cmbBaud.Items.Add(57600);
            cmbBaud.Items.Add(115200);
            
            for( int i = 0; i < ports.Length; i++)
            {
                cmbPort.Items.Add(ports[i]);
            }

            cmbPort.SelectedItem = 0;   
            cmbBaud.SelectedItem = 0;

            openFileDialog1.Title = "Open Text File";
            openFileDialog1.Filter = "TXT files|*.txt";
            openFileDialog1.InitialDirectory = Application.ExecutablePath; 
                       
            btnDisconnect.Enabled = true;
        
        }    
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbPort.SelectedIndex == -1)
                {
                    MessageBox.Show("Error: No port selected, try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (cmbBaud.SelectedIndex == -1)
                {
                    MessageBox.Show("Error: No baud rate selected, try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (btnDisconnect.Text == "Connect")
                {
                    serialPort1 = new SerialPort(cmbPort.Text, Convert.ToInt32(cmbBaud.Text));

                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort2_DataReceived);
                                      
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;                   //Open serial port
                    serialPort1.ReadTimeout = 2000;
                    serialPort1.WriteTimeout = 2000;

                    serialPort1.Open();
                    bolConnected = true;

                    btnDisconnect.Text = "Disconnect";
                }
                else
                {
                    serialPort1.Close();
                    bolConnected = false;
                    btnDisconnect.Text = "Connect";
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                serialPort1.Close();
                bolConnected = false;
                btnDisconnect.Text = "Connect";
            }
        }   
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
           // Thread.Sleep(500);
            string strres = serialPort1.ReadExisting();
            this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { strres });
            Logger.WriteLine(strres);
        }
        private void si_DataReceived(string data)
        {
            txtResults.Invoke(new Action(() =>txtResults.AppendText(data)));           
            txtResultsHex.Invoke(new Action(() => txtResultsHex.AppendText(StrToHex(data) + Environment.NewLine)));
            
        }
        private string StrToHex(string data)
        {
            byte[] ba = Encoding.Default.GetBytes(data);
            var hexString = BitConverter.ToString(ba);           
            return hexString;
        }

        private void btnAT_Click(object sender, EventArgs e)
        {
            Button button;
            if (serialPort1 == null)
            {
                MessageBox.Show("Error: port not connected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!bolConnected)
            {
                MessageBox.Show("Error: port not connected.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string strRes = sender.GetType().Name;
            if ((sender is Button) && (serialPort1.IsOpen == true))
            {
                button = sender as Button;
            } else
            {
                return;
            }
            switch (button.Name) 
            {
                case "btnSendCmd":
                    {                                                   
                            serialPort1.Write(txtSendCmd.Text + "\r");
                        break;                     
                    }
                case "btnConnectToServer":
                {
                    serialPort1.Write(txtConnectToServer.Text + "\r");
                    break;
                }
                case "btnDisconectFromServer":
                    {
                        serialPort1.Write(txtDisconect.Text + "\r");
                        break;
                    }
                case "btnSend":
                    {
                        serialPort1.Write(txtSend.Text + "\r");
                        break;
                    }
                case "btnSendCycle":
                    {
                        serialPort1.Write(txtSend.Text + "\r");
                        number = 0;
                        message = "";
                        for (int i = 0; i < Convert.ToInt32(txtToSend.Text); i++)
                        {
                            message += "q";
                        }
                        break;
                    }
                
                
            }
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1 != null)
            {
                if (serialPort1.IsOpen == true)
                {
                    bolConnected = false;
                    serialPort1.Close();
                }
            }
        }       
       
     
        private void txtResults_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (cycleMode.Checked == true)
                {
                    if (startTime == 0)
                    {
                        startTime++;
                        sw.Start();
                        sw.Restart();
                    }
                    if (number < Convert.ToInt32(txtQuantity.Text))
                    {
                        if (txtResults.Lines[txtResults.Lines.Length - 2] == "OK")
                        {
                            serialPort1.Write(txtSend.Text + "\r");
                        }

                        if (txtResults.Lines[txtResults.Lines.Length - 1] == "> ")
                        {
                            serialPort1.Write(message + "\r");
                            number++;
                           // Thread.Sleep(1500);
                        }
                    }
                    if (number == Convert.ToInt32(txtQuantity.Text))
                    {
                        sw.Stop();
                        MessageBox.Show("Время выполнения программы в секундах : " + sw.Elapsed.TotalMilliseconds / 1000 + "с.\r\n");
                        startTime = 0;
                    }
                }
            }
            catch (Exception p) { }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtResults.Text = "";
            txtResultsHex.Text = "";
        }

        private void cycleMode_CheckedChanged(object sender, EventArgs e)
        {
            if (cycleMode.Checked == true)
            {
                btnSendCycle.Enabled = true;
                btnConnectToServer.Enabled = false;
                btnDisconectFromServer.Enabled = false;
                btnSend.Enabled = false;
                btnSendCmd.Enabled = false;
            }
            else
            {
                btnSendCycle.Enabled = false;
                btnConnectToServer.Enabled = true;
                btnDisconectFromServer.Enabled = true;
                btnSend.Enabled = true;
                btnSendCmd.Enabled = true;
            }
        }

        private void txtSendCmd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtConnectToServer_TextChanged(object sender, EventArgs e)
        {

        }
    }
    static public class Logger
    {
        //----------------------------------------------------------
        // Статический метод записи строки в файл без переноса
        //----------------------------------------------------------
        public static void Write(string text)
        {
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\data.log", true))
            {
                sw.Write(text);
            }
        }

        //---------------------------------------------------------
        // Статический метод записи строки в файл с переносом
        //---------------------------------------------------------
        public static void WriteLine(string message)
        {
            using (StreamWriter sw = new StreamWriter(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\data.log", true))
            {
                sw.WriteLine(String.Format("{0} {1}", DateTime.Now.ToString() + ":", message));
            }
        }
    }
}
