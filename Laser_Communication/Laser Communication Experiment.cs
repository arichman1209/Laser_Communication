using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace Laser_Communication
{
    public partial class Laser_Communication_Experiment : Form
    {
        public Laser_Communication_Experiment()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_ComPort.Items.Clear(); // 清空 comboBox_ComPort
            comboBox_ComPort.Items.AddRange(SerialPort.GetPortNames()); // 獲取所有可用的serial port
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                tmr_Com.Enabled = false; // 停止 Timer
                btn_Connect.BackColor = Color.Pink;
                return;
            }

            if (comboBox_ComPort.SelectedIndex < 0)
            {
                MessageBox.Show("Please choose your device.", "Remind");
                return;
            }

            serialPort.PortName = comboBox_ComPort.Text;
            serialPort.BaudRate = 9600; // 設定波特率為 9600

            try
            {
                serialPort.Open();
                tmr_Com.Enabled = true; // 啟用 Timer
                btn_Connect.BackColor = Color.LightGreen;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Device connection error.\n{ex.Message}", "Warning");
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen)
            {
                MessageBox.Show("Device not connected. Please connect first.", "Error");
                return;
            }

            if (string.IsNullOrEmpty(txb_Transmitter.Text))
            {
                return; // 傳送內容為空時不進行傳輸
            }

            string Tx_Message = $"{DateTime.Now:HH:mm:ss}:\t{txb_Transmitter.Text}\r\n";
            serialPort.Write(Tx_Message); // 傳送訊息
        }

        private void tmr_Com_Tick(object sender, EventArgs e)
        {
            if (!serialPort.IsOpen) return;

            if (serialPort.BytesToRead > 0)
            {
                string Rx_Message = serialPort.ReadExisting(); // 接收訊息
                txb_Receiver.Text += Rx_Message; // 顯示訊息
                txb_Receiver.SelectionStart = txb_Receiver.Text.Length;
                txb_Receiver.ScrollToCaret();
            }
        }
    }
}
