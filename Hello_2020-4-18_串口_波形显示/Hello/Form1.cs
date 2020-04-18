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

namespace Hello
{
    public delegate void ShowWindow(); //delegate类似于创建一个父类，后续子类可以对其进行实例化
    public delegate void HideWindow();
    public delegate void Serial_1_OpenPort();
    public delegate void Serial_1_ClosePort();
    public delegate Point GetMainPos();
    public delegate int GetMainWidth();

    public partial class Form1 : Form
    {
        Form2 wave_form;

        public Form1()
        {
            InitializeComponent();

            // 允许跨线程访问，如果不加这句话，在串口读取函数中，不允许调用TextBox控件
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;//设置该属性 为false
            
            //波特率下选框
            comboBox_baud.Items.Add(4800);
            comboBox_baud.Items.Add(9600);
            comboBox_baud.Items.Add(115200);
            comboBox_baud.SelectedIndex = 2; //设置默认值
            //数据位下选框
            comboBox_data.Items.Add(7);
            comboBox_data.Items.Add(8);
            comboBox_data.SelectedIndex = 1; //设置默认值
            //停止位
            comboBox_stop.Items.Add(1);
            comboBox_stop.Items.Add(1.5);
            comboBox_stop.Items.Add(2);
            comboBox_stop.SelectedIndex = 0; //设置默认值
            //校验位
            comboBox_check.Items.Add("None");
            comboBox_check.Items.Add("Odd");
            comboBox_check.Items.Add("Even");
            comboBox_check.Items.Add("Mark");
            comboBox_check.Items.Add("Space");
            comboBox_check.SelectedIndex = 0; //设置默认值

            //串口初始设置
            serialPort1.BaudRate = Convert.ToInt32(comboBox_baud.Text);
            serialPort1.DataBits = Convert.ToInt32(comboBox_data.Text);
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity), comboBox_check.Text, true);
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stop.Text, true);
        }

        public void Serial_1_ClosePort()
        {
            try
            {
                serialPort1.Close();
                btn_open.Text = "打开串口";
            }
            catch (System.Exception)
            {

            }
        }

        public void Serial_1_OpenPort()
        {
            try
            {
                serialPort1.Open();
                btn_open.Text = "关闭串口";
            }
            catch (System.Exception)
            {
                MessageBox.Show("串口打开失败，请检查", "错误");
            }
        }

        private Point GetMyPos()//供委托调用
        {
            return this.Location;
        }

        public void ShowMe()//供委托调用
        {
            this.Show();
        }

        public void HideMe()//供委托调用
        {
            this.Hide();
        }

        int GetMyWidth()//供委托调用
        {
            return this.Width;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void CreateNewDrawer()//创建ADC绘制窗口
        {
            wave_form = new Form2();//创建新对象
            wave_form.ShowMainWindow = new ShowWindow(ShowMe);//初始化类成员委托
            wave_form.HideMainWindow = new HideWindow(HideMe);
            wave_form.GetMainPos = new GetMainPos(GetMyPos);
            wave_form.CloseSerialPort = new Serial_1_ClosePort(Serial_1_ClosePort);
            wave_form.OpenSerialPort = new Serial_1_OpenPort(Serial_1_OpenPort);
            wave_form.GetMainWidth = new GetMainWidth(GetMyWidth);
            wave_form.Show();//显示窗口
        }

        private void CreateDisplayer()
        {
            this.Left = 0;
            CreateNewDrawer();
            Rectangle Rect = Screen.GetWorkingArea(this);
            wave_form.SetWindow(Rect.Width - this.Width, new Point(this.Width, this.Top));//设置绘制窗口宽度，以及坐标
        }

        private void btn_open_wave_Click(object sender, EventArgs e)
        {
            if (wave_form == null)//第一次创建Displayer = null
            {
                CreateDisplayer();
            }
            else
            {
                if (wave_form.IsDisposed)//多次创建通过判断IsDisposed确定串口是否已关闭，避免多次创建
                {
                    CreateDisplayer();
                }
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            if (!radioButton4.Checked)
            {
                try
                {
                    textBox_receive.AppendText(serialPort1.ReadExisting());//串口类会自动处理汉字，所以不需要特别转换
                }
                catch
                {
                    MessageBox.Show("串口数据字符型读取错误", "错误");
                }

            }
            else
            {
                try
                {
                    byte[] data = new byte[serialPort1.BytesToRead];                                //定义缓冲区，因为串口事件触发时有可能收到不止一个字节
                    serialPort1.Read(data, 0, data.Length);
                    if (wave_form != null)
                        wave_form.AddData(data);
                    foreach (byte Member in data)                                                   //遍历用法
                    {
                        string str = Convert.ToString(Member, 16).ToUpper(); // 16表示16进制
                        textBox_receive.AppendText("0x" + (str.Length == 1 ? "0" + str : str) + " ");
                    }
                }
                catch
                {
                    MessageBox.Show("串口数据数值型读取错误", "错误");

                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            byte[] Data = new byte[1];                                                         //单字节发数据     
            if (serialPort1.IsOpen)
            {
                if (textBox_send.Text != "")
                {
                    if (!radioButton1.Checked)
                    {
                        try
                        {
                            serialPort1.Write(textBox_send.Text);
                            //serialPort1.WriteLine();                             //字符串写入
                        }
                        catch
                        {
                            MessageBox.Show("串口数据写入错误", "错误");
                        }
                    }
                    else                                                                    //数据模式
                    {
                        try                                                                 //如果此时用户输入字符串中含有非法字符（字母，汉字，符号等等，try，catch块可以捕捉并提示）
                        {
                            for (int i = 0; i < (textBox_send.Text.Length - textBox_send.Text.Length % 2) / 2; i++)//转换偶数个
                            {
                                Data[0] = Convert.ToByte(textBox_send.Text.Substring(i * 2, 2), 16);           //转换
                                serialPort1.Write(Data, 0, 1);
                            }
                            if (textBox_send.Text.Length % 2 != 0)
                            {
                                Data[0] = Convert.ToByte(textBox_send.Text.Substring(textBox_send.Text.Length - 1, 1), 16);//单独处理最后一个字符
                                serialPort1.Write(Data, 0, 1);                              //写入
                            }
                            //Data = Convert.ToByte(textBox2.Text.Substring(textBox2.Text.Length - 1, 1), 16);
                            //  }
                        }
                        catch
                        {
                            MessageBox.Show("数据转换错误，请输入数字。", "错误");
                        }
                    }
                }
            }
        }

        private void comboBox_COM_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox_COM.Text;
        }

        private void comboBox_baud_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBox_baud.Text);
            serialPort1.BaudRate = Convert.ToInt32(comboBox_baud.Text);
        }

        private void comboBox_data_SelectedIndexChanged(object sender, EventArgs e)
        {

            serialPort1.DataBits = Convert.ToInt32(comboBox_data.Text);
        }

        private void comboBox_stop_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBox_stop.Text, true);
        }

        private void comboBox_check_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Parity = (Parity)Enum.Parse(typeof(Parity),comboBox_check.Text, true);
            //MessageBox.Show(Convert.ToString(serialPort1.Parity));
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            if(btn_open.Text == "打开串口")
            {
                Serial_1_OpenPort();
            }
            else
            {
                Serial_1_ClosePort();
            }
            
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            comboBox_COM.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox_COM.Items.Add(s);
            }
        }


    }
}
