namespace Laser_Communication
{
    partial class Laser_Communication_Experiment
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Laser_Communication_Experiment));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_RxMessage = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ConnectRx = new System.Windows.Forms.Button();
            this.comboBox_ComPortRx = new System.Windows.Forms.ComboBox();
            this.panelRx = new System.Windows.Forms.Panel();
            this.lb_Rx = new System.Windows.Forms.Label();
            this.txb_Receiver = new System.Windows.Forms.TextBox();
            this.lb_TxMessage = new System.Windows.Forms.Label();
            this.lb_TxPort = new System.Windows.Forms.Label();
            this.lb_Tx = new System.Windows.Forms.Label();
            this.panelTx = new System.Windows.Forms.Panel();
            this.btn_ConnectTx = new System.Windows.Forms.Button();
            this.comboBox_ComPortTx = new System.Windows.Forms.ComboBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.txb_Transmitter = new System.Windows.Forms.TextBox();
            this.tmr_Com = new System.Windows.Forms.Timer(this.components);
            this.tmr_Connect = new System.Windows.Forms.Timer(this.components);
            this.serialPortRx = new System.IO.Ports.SerialPort(this.components);
            this.serialPortTx = new System.IO.Ports.SerialPort(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelRx.SuspendLayout();
            this.panelTx.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(906, 580);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 26);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lb_RxMessage
            // 
            this.lb_RxMessage.AutoSize = true;
            this.lb_RxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_RxMessage.Location = new System.Drawing.Point(35, 178);
            this.lb_RxMessage.Name = "lb_RxMessage";
            this.lb_RxMessage.Size = new System.Drawing.Size(112, 29);
            this.lb_RxMessage.TabIndex = 13;
            this.lb_RxMessage.Text = "Message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "Port";
            // 
            // btn_ConnectRx
            // 
            this.btn_ConnectRx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ConnectRx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConnectRx.Location = new System.Drawing.Point(318, 100);
            this.btn_ConnectRx.Name = "btn_ConnectRx";
            this.btn_ConnectRx.Size = new System.Drawing.Size(131, 45);
            this.btn_ConnectRx.TabIndex = 9;
            this.btn_ConnectRx.Text = "Connect";
            this.btn_ConnectRx.UseVisualStyleBackColor = false;
            this.btn_ConnectRx.Click += new System.EventHandler(this.btn_ConnectRx_Click);
            // 
            // comboBox_ComPortRx
            // 
            this.comboBox_ComPortRx.FormattingEnabled = true;
            this.comboBox_ComPortRx.Location = new System.Drawing.Point(98, 108);
            this.comboBox_ComPortRx.Name = "comboBox_ComPortRx";
            this.comboBox_ComPortRx.Size = new System.Drawing.Size(199, 28);
            this.comboBox_ComPortRx.TabIndex = 10;
            // 
            // panelRx
            // 
            this.panelRx.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelRx.Controls.Add(this.lb_RxMessage);
            this.panelRx.Controls.Add(this.label2);
            this.panelRx.Controls.Add(this.btn_ConnectRx);
            this.panelRx.Controls.Add(this.comboBox_ComPortRx);
            this.panelRx.Controls.Add(this.lb_Rx);
            this.panelRx.Controls.Add(this.txb_Receiver);
            this.panelRx.Location = new System.Drawing.Point(578, 67);
            this.panelRx.Name = "panelRx";
            this.panelRx.Size = new System.Drawing.Size(499, 496);
            this.panelRx.TabIndex = 11;
            // 
            // lb_Rx
            // 
            this.lb_Rx.AutoSize = true;
            this.lb_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Rx.Location = new System.Drawing.Point(3, 6);
            this.lb_Rx.Name = "lb_Rx";
            this.lb_Rx.Size = new System.Drawing.Size(177, 46);
            this.lb_Rx.TabIndex = 8;
            this.lb_Rx.Text = "Receiver";
            // 
            // txb_Receiver
            // 
            this.txb_Receiver.Location = new System.Drawing.Point(40, 223);
            this.txb_Receiver.Multiline = true;
            this.txb_Receiver.Name = "txb_Receiver";
            this.txb_Receiver.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txb_Receiver.Size = new System.Drawing.Size(430, 213);
            this.txb_Receiver.TabIndex = 2;
            // 
            // lb_TxMessage
            // 
            this.lb_TxMessage.AutoSize = true;
            this.lb_TxMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TxMessage.Location = new System.Drawing.Point(21, 206);
            this.lb_TxMessage.Name = "lb_TxMessage";
            this.lb_TxMessage.Size = new System.Drawing.Size(112, 29);
            this.lb_TxMessage.TabIndex = 11;
            this.lb_TxMessage.Text = "Message";
            // 
            // lb_TxPort
            // 
            this.lb_TxPort.AutoSize = true;
            this.lb_TxPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TxPort.Location = new System.Drawing.Point(21, 123);
            this.lb_TxPort.Name = "lb_TxPort";
            this.lb_TxPort.Size = new System.Drawing.Size(57, 29);
            this.lb_TxPort.TabIndex = 10;
            this.lb_TxPort.Text = "Port";
            // 
            // lb_Tx
            // 
            this.lb_Tx.AutoSize = true;
            this.lb_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Tx.Location = new System.Drawing.Point(3, 7);
            this.lb_Tx.Name = "lb_Tx";
            this.lb_Tx.Size = new System.Drawing.Size(220, 46);
            this.lb_Tx.TabIndex = 7;
            this.lb_Tx.Text = "Transmitter";
            // 
            // panelTx
            // 
            this.panelTx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.panelTx.Controls.Add(this.lb_TxMessage);
            this.panelTx.Controls.Add(this.lb_TxPort);
            this.panelTx.Controls.Add(this.lb_Tx);
            this.panelTx.Controls.Add(this.btn_ConnectTx);
            this.panelTx.Controls.Add(this.comboBox_ComPortTx);
            this.panelTx.Controls.Add(this.btnSend);
            this.panelTx.Controls.Add(this.txb_Transmitter);
            this.panelTx.Location = new System.Drawing.Point(11, 67);
            this.panelTx.Name = "panelTx";
            this.panelTx.Size = new System.Drawing.Size(525, 496);
            this.panelTx.TabIndex = 10;
            // 
            // btn_ConnectTx
            // 
            this.btn_ConnectTx.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_ConnectTx.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConnectTx.Location = new System.Drawing.Point(339, 116);
            this.btn_ConnectTx.Name = "btn_ConnectTx";
            this.btn_ConnectTx.Size = new System.Drawing.Size(121, 45);
            this.btn_ConnectTx.TabIndex = 0;
            this.btn_ConnectTx.Text = "Connect";
            this.btn_ConnectTx.UseVisualStyleBackColor = false;
            this.btn_ConnectTx.Click += new System.EventHandler(this.btn_ConnectTx_Click);
            // 
            // comboBox_ComPortTx
            // 
            this.comboBox_ComPortTx.FormattingEnabled = true;
            this.comboBox_ComPortTx.Location = new System.Drawing.Point(84, 124);
            this.comboBox_ComPortTx.Name = "comboBox_ComPortTx";
            this.comboBox_ComPortTx.Size = new System.Drawing.Size(219, 28);
            this.comboBox_ComPortTx.TabIndex = 5;
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(403, 198);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 45);
            this.btnSend.TabIndex = 4;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txb_Transmitter
            // 
            this.txb_Transmitter.Location = new System.Drawing.Point(139, 209);
            this.txb_Transmitter.Name = "txb_Transmitter";
            this.txb_Transmitter.Size = new System.Drawing.Size(256, 26);
            this.txb_Transmitter.TabIndex = 1;
            // 
            // tmr_Com
            // 
            this.tmr_Com.Interval = 300;
            this.tmr_Com.Tick += new System.EventHandler(this.tmr_Com_Tick);
            // 
            // tmr_Connect
            // 
            this.tmr_Connect.Enabled = true;
            this.tmr_Connect.Tick += new System.EventHandler(this.tmr_Connect_Tick);
            // 
            // serialPortRx
            // 
            this.serialPortRx.PortName = "COM6";
            // 
            // serialPortTx
            // 
            this.serialPortTx.PortName = "COM3";
            // 
            // Laser_Communication_Experiment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 620);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panelRx);
            this.Controls.Add(this.panelTx);
            this.Name = "Laser_Communication_Experiment";
            this.Text = "Laser Communication Experiment";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelRx.ResumeLayout(false);
            this.panelRx.PerformLayout();
            this.panelTx.ResumeLayout(false);
            this.panelTx.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_RxMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ConnectRx;
        private System.Windows.Forms.ComboBox comboBox_ComPortRx;
        private System.Windows.Forms.Panel panelRx;
        private System.Windows.Forms.Label lb_Rx;
        private System.Windows.Forms.TextBox txb_Receiver;
        private System.Windows.Forms.Label lb_TxMessage;
        private System.Windows.Forms.Label lb_TxPort;
        private System.Windows.Forms.Label lb_Tx;
        private System.Windows.Forms.Panel panelTx;
        private System.Windows.Forms.Button btn_ConnectTx;
        private System.Windows.Forms.ComboBox comboBox_ComPortTx;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txb_Transmitter;
        private System.Windows.Forms.Timer tmr_Com;
        private System.Windows.Forms.Timer tmr_Connect;
        private System.IO.Ports.SerialPort serialPortRx;
        private System.IO.Ports.SerialPort serialPortTx;
    }
}

