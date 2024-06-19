using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            comboBox_ComPortTx.Items.Clear(); //清空comboBox_ComPortTx的項目，讓此格是空的
            comboBox_ComPortRx.Items.Clear(); //清空comboBox_ComPortTx的項目，讓此格是空的
            comboBox_ComPortTx.Items.AddRange(SerialPort.GetPortNames()); //獲取系統中所有接口的名稱，並添加到comboBox_ComPortTx的項目中
            comboBox_ComPortRx.Items.AddRange(SerialPort.GetPortNames()); //獲取系統中所有接口的名稱，並添加到comboBox_ComPortRx的項目中
        }

        private void btn_ConnectTx_Click(object sender, EventArgs e)
        {
            if (serialPortTx.IsOpen) { serialPortTx.Close(); return; } //假如你已經連接上，此功能就關閉
            if (comboBox_ComPortTx.SelectedIndex < 0) { MessageBox.Show("Please choose your device.", "Remind"); return; } //假如你沒選接口就按Connect，跳錯誤訊息
            serialPortTx.PortName = comboBox_ComPortTx.Text; //設置接口的名稱
            serialPortTx.BaudRate = 9600; //設定波特率為9600
            try
            {
                serialPortTx.Open(); //打開接口
            }
            catch (Exception ex) { MessageBox.Show($"Device connection error.\n{ex.Message}", "Warning"); return; } //如果選取到已經被連接的接口，跳錯誤訊息
        }

        private void btn_ConnectRx_Click(object sender, EventArgs e)
        {
            if (serialPortRx.IsOpen) { serialPortRx.Close(); return; } //假如你已經連接上，此功能就關閉
            if (comboBox_ComPortRx.SelectedIndex < 0) { MessageBox.Show("Please choose your device.", "Remind"); return; } //假如你沒選接口就按Connect，跳錯誤訊息
            serialPortRx.PortName = comboBox_ComPortRx.Text; //設置接口的名稱
            serialPortRx.BaudRate = 9600;//設定波特率為9600
            try
            {
                serialPortRx.Open(); //打開接口
                tmr_Com.Enabled = true; //打開 Timer
            }
            catch (Exception ex) { MessageBox.Show($"Device connection error.\n{ex.Message}", "Warning"); return; } //如果選取到已經被連接的接口，跳錯誤訊息
        }

        private void tmr_Connect_Tick(object sender, EventArgs e)
        {
            if (serialPortTx.IsOpen) btn_ConnectTx.BackColor = Color.LightGreen; //連接上的話 Connect 會顯示綠色
            else btn_ConnectTx.BackColor = Color.Pink; //沒連接上的話 Connect 會顯示粉紅色
            if (serialPortRx.IsOpen) btn_ConnectRx.BackColor = Color.LightGreen; //連接上的話 Connect 會顯示綠色
            else btn_ConnectRx.BackColor = Color.Pink; //沒連接上的話 Connect 會顯示粉紅色
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (serialPortTx == null) { return; } //沒有接口時關閉
            else if (!serialPortTx.IsOpen) { MessageBox.Show("Device not found, Please choose your device. ", "Error"); return; } //接口還沒開啟，跳錯誤訊息

            serialPortTx.Write(txb_Transmitter.Text + "\r\n"); //發送訊號，訊號傳遞的方式為txb_Transmitter.Text裡的字+換行
        }


        private void tmr_Com_Tick(object sender, EventArgs e)
        {

            if (serialPortRx == null) return; //沒有接口時，跳出此功能
            if (!serialPortRx.IsOpen) return; //接口還沒開啟時，跳出此功能
            if (serialPortRx.BytesToRead > 0) //檢查串口是否有數據可讀
            {
                txb_Receiver.Text += $"{DateTime.Now.ToString("HH:mm:ss")}:\t{serialPortRx.ReadExisting()}"; //在txb_Receiver.Text 將其寫下來，並記錄時間
                txb_Receiver.SelectionStart = txb_Receiver.Text.Length; //讓畫面停在最新的訊息
                txb_Receiver.ScrollToCaret(); // 可捲動
            }
        }
    }
}
