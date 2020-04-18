namespace Hello
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_send = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.sendGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.textBox_send = new System.Windows.Forms.TextBox();
            this.receiveGroup = new System.Windows.Forms.GroupBox();
            this.textBox_receive = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox_setting = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_check = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_stop = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_data = new System.Windows.Forms.ComboBox();
            this.comboBox_baud = new System.Windows.Forms.ComboBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.comboBox_COM = new System.Windows.Forms.ComboBox();
            this.btn_open = new System.Windows.Forms.Button();
            this.btn_open_wave = new System.Windows.Forms.Button();
            this.sendGroup.SuspendLayout();
            this.panel1.SuspendLayout();
            this.receiveGroup.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox_setting.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(6, 24);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(75, 23);
            this.btn_send.TabIndex = 0;
            this.btn_send.Text = "发送";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // sendGroup
            // 
            this.sendGroup.Controls.Add(this.panel1);
            this.sendGroup.Controls.Add(this.textBox_send);
            this.sendGroup.Controls.Add(this.btn_send);
            this.sendGroup.Location = new System.Drawing.Point(278, 226);
            this.sendGroup.Name = "sendGroup";
            this.sendGroup.Size = new System.Drawing.Size(335, 134);
            this.sendGroup.TabIndex = 1;
            this.sendGroup.TabStop = false;
            this.sendGroup.Text = "发送区";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Location = new System.Drawing.Point(6, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(75, 65);
            this.panel1.TabIndex = 2;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 30);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(58, 19);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.Text = "数值";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(58, 19);
            this.radioButton2.TabIndex = 0;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "字符";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // textBox_send
            // 
            this.textBox_send.Location = new System.Drawing.Point(87, 24);
            this.textBox_send.Multiline = true;
            this.textBox_send.Name = "textBox_send";
            this.textBox_send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_send.Size = new System.Drawing.Size(241, 94);
            this.textBox_send.TabIndex = 1;
            // 
            // receiveGroup
            // 
            this.receiveGroup.Controls.Add(this.textBox_receive);
            this.receiveGroup.Controls.Add(this.panel2);
            this.receiveGroup.Location = new System.Drawing.Point(278, 49);
            this.receiveGroup.Name = "receiveGroup";
            this.receiveGroup.Size = new System.Drawing.Size(335, 171);
            this.receiveGroup.TabIndex = 2;
            this.receiveGroup.TabStop = false;
            this.receiveGroup.Text = "接收区";
            // 
            // textBox_receive
            // 
            this.textBox_receive.Location = new System.Drawing.Point(87, 32);
            this.textBox_receive.Multiline = true;
            this.textBox_receive.Name = "textBox_receive";
            this.textBox_receive.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_receive.Size = new System.Drawing.Size(242, 121);
            this.textBox_receive.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.radioButton4);
            this.panel2.Controls.Add(this.radioButton3);
            this.panel2.Location = new System.Drawing.Point(6, 50);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(75, 65);
            this.panel2.TabIndex = 3;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(4, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(58, 19);
            this.radioButton4.TabIndex = 1;
            this.radioButton4.Text = "数值";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(58, 19);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "字符";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox_setting
            // 
            this.groupBox_setting.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_setting.Controls.Add(this.label5);
            this.groupBox_setting.Controls.Add(this.comboBox_check);
            this.groupBox_setting.Controls.Add(this.label4);
            this.groupBox_setting.Controls.Add(this.comboBox_stop);
            this.groupBox_setting.Controls.Add(this.label3);
            this.groupBox_setting.Controls.Add(this.label2);
            this.groupBox_setting.Controls.Add(this.label1);
            this.groupBox_setting.Controls.Add(this.comboBox_data);
            this.groupBox_setting.Controls.Add(this.comboBox_baud);
            this.groupBox_setting.Controls.Add(this.btn_test);
            this.groupBox_setting.Controls.Add(this.comboBox_COM);
            this.groupBox_setting.Controls.Add(this.btn_open);
            this.groupBox_setting.Location = new System.Drawing.Point(54, 49);
            this.groupBox_setting.Name = "groupBox_setting";
            this.groupBox_setting.Size = new System.Drawing.Size(218, 311);
            this.groupBox_setting.TabIndex = 3;
            this.groupBox_setting.TabStop = false;
            this.groupBox_setting.Text = "串口设置";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(-2, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "校验位";
            // 
            // comboBox_check
            // 
            this.comboBox_check.FormattingEnabled = true;
            this.comboBox_check.Location = new System.Drawing.Point(56, 230);
            this.comboBox_check.Name = "comboBox_check";
            this.comboBox_check.Size = new System.Drawing.Size(75, 23);
            this.comboBox_check.TabIndex = 10;
            this.comboBox_check.SelectedIndexChanged += new System.EventHandler(this.comboBox_check_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "停止位";
            // 
            // comboBox_stop
            // 
            this.comboBox_stop.FormattingEnabled = true;
            this.comboBox_stop.Location = new System.Drawing.Point(56, 192);
            this.comboBox_stop.Name = "comboBox_stop";
            this.comboBox_stop.Size = new System.Drawing.Size(75, 23);
            this.comboBox_stop.TabIndex = 8;
            this.comboBox_stop.SelectedIndexChanged += new System.EventHandler(this.comboBox_stop_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "数据位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-2, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "波特率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-2, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "串口号";
            // 
            // comboBox_data
            // 
            this.comboBox_data.FormattingEnabled = true;
            this.comboBox_data.Location = new System.Drawing.Point(56, 152);
            this.comboBox_data.Name = "comboBox_data";
            this.comboBox_data.Size = new System.Drawing.Size(75, 23);
            this.comboBox_data.TabIndex = 4;
            this.comboBox_data.SelectedIndexChanged += new System.EventHandler(this.comboBox_data_SelectedIndexChanged);
            // 
            // comboBox_baud
            // 
            this.comboBox_baud.FormattingEnabled = true;
            this.comboBox_baud.Location = new System.Drawing.Point(56, 114);
            this.comboBox_baud.Name = "comboBox_baud";
            this.comboBox_baud.Size = new System.Drawing.Size(75, 23);
            this.comboBox_baud.TabIndex = 3;
            this.comboBox_baud.SelectedIndexChanged += new System.EventHandler(this.comboBox_baud_SelectedIndexChanged);
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(138, 66);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(64, 32);
            this.btn_test.TabIndex = 2;
            this.btn_test.Text = "检测";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // comboBox_COM
            // 
            this.comboBox_COM.FormattingEnabled = true;
            this.comboBox_COM.Location = new System.Drawing.Point(56, 72);
            this.comboBox_COM.Name = "comboBox_COM";
            this.comboBox_COM.Size = new System.Drawing.Size(75, 23);
            this.comboBox_COM.TabIndex = 1;
            this.comboBox_COM.SelectedIndexChanged += new System.EventHandler(this.comboBox_COM_SelectedIndexChanged);
            // 
            // btn_open
            // 
            this.btn_open.Location = new System.Drawing.Point(29, 29);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(102, 27);
            this.btn_open.TabIndex = 0;
            this.btn_open.Text = "打开串口";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // btn_open_wave
            // 
            this.btn_open_wave.Location = new System.Drawing.Point(483, 12);
            this.btn_open_wave.Name = "btn_open_wave";
            this.btn_open_wave.Size = new System.Drawing.Size(102, 33);
            this.btn_open_wave.TabIndex = 12;
            this.btn_open_wave.Text = "打开波形图";
            this.btn_open_wave.UseVisualStyleBackColor = true;
            this.btn_open_wave.Click += new System.EventHandler(this.btn_open_wave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 403);
            this.Controls.Add(this.btn_open_wave);
            this.Controls.Add(this.groupBox_setting);
            this.Controls.Add(this.receiveGroup);
            this.Controls.Add(this.sendGroup);
            this.Name = "Form1";
            this.Text = "Form1";
            this.sendGroup.ResumeLayout(false);
            this.sendGroup.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.receiveGroup.ResumeLayout(false);
            this.receiveGroup.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox_setting.ResumeLayout(false);
            this.groupBox_setting.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Timer timer1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox sendGroup;
        private System.Windows.Forms.TextBox textBox_send;
        private System.Windows.Forms.GroupBox receiveGroup;
        private System.Windows.Forms.GroupBox groupBox_setting;
        private System.Windows.Forms.ComboBox comboBox_COM;
        private System.Windows.Forms.Button btn_open;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_data;
        private System.Windows.Forms.ComboBox comboBox_baud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_check;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_stop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox_receive;
        private System.Windows.Forms.Button btn_open_wave;
    }
}

