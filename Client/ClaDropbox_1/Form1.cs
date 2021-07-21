using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaDropbox_1
{
    public partial class Form1 : Form
    {
        // 접속할 IP & Port
        string bindIP = "127.0.0.1";
        int bindPort = 10004;

        // 상대방 IP & Port
        string serverIP = "127.0.0.1";
        const int serverPort = 5454;
        string message = "";
        //클라이언트 인터넷 주소 만들기
        IPEndPoint clientAddress;

        //서버 인터넷 주소 만들기
        IPEndPoint serverAddress;

        NetworkStream stream;

        //클라이언트 만들고 서버로 접속하기
        TcpClient client;

        

            public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(20, 40);
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 

                if(comboBox1.SelectedIndex == 0) { 
                comboBox1.SelectedIndex = 0;
                pictureBox1.Image = Properties.Resources.게이밍용;
                int a = comboBox1.SelectedIndex;
                }
                else if(comboBox1.SelectedIndex == 1) { 
                comboBox1.SelectedIndex = 1;
                    pictureBox1.Image = Properties.Resources.사무용;
                }
                else if (comboBox1.SelectedIndex == 2)
                {
                    comboBox1.SelectedIndex = 2;
                    pictureBox1.Image = Properties.Resources.서버용;
                }
                else if (comboBox1.SelectedIndex == 3)
                {
                    comboBox1.SelectedIndex = 3;
                    pictureBox1.Image = Properties.Resources.영상편집용;
                }
                else if (comboBox1.SelectedIndex == 4)
                {
                    comboBox1.SelectedIndex = 4;
                    pictureBox1.Image = Properties.Resources.웹서핑용;
                }
            }
            catch(Exception exc)
            {
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            string[] data = { "게이밍", "사무용","서버용", "영상 편집용", "웹 서핑용" };
            comboBox1.Items.AddRange(data);

            //클라이언트 인터넷 주소 만들기
             clientAddress =
                new IPEndPoint(IPAddress.Parse(bindIP), bindPort);

            //서버 인터넷 주소 만들기
             serverAddress =
                new IPEndPoint(IPAddress.Parse(serverIP), serverPort);


            //클라이언트 만들고 서버로 접속하기
             client = new TcpClient(clientAddress);
            client.Connect(serverAddress);
            stream = client.GetStream();
            Thread datereceive = new Thread(receive);
            datereceive.Start();                
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                      , int nTopRect
                                      , int nRightRect
                                      , int nBottomRect
                                      , int nWidthEllipse
                                      , int nHeightEllipse);
        public void receive()
        {
            string data;
            try
            {
                int length;
                byte[] bytes = new byte[256];
                while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    data = Encoding.Default.GetString(bytes, 0, length);
                    /*Console.WriteLine(string.Format("수신: {0}", data));*/


                    //재고 증가시키는 부분
                    if (data.Equals("0"))
                    {
                        int cnt = Convert.ToInt32(label1.Text); //데이터베이스 받아옴
                        cnt++;
                        label1.Text = cnt.ToString();
                    }
                    else if (data.Equals("1"))
                    {
                        int cnt = Convert.ToInt32(label2.Text);
                        cnt++;
                        label2.Text = cnt.ToString();
                    }
                    else if (data.Equals("2"))
                    {
                        int cnt = Convert.ToInt32(label3.Text);
                        cnt++;
                        label3.Text = cnt.ToString();
                    }
                    else if (data.Equals("3"))
                    {
                        int cnt = Convert.ToInt32(label4.Text);
                        cnt++;
                        label4.Text = cnt.ToString();
                    }
                    else if (data.Equals("4"))
                    {
                        int cnt = Convert.ToInt32(label5.Text);
                        cnt++;
                        label5.Text = cnt.ToString();
                    }
                    else
                    {

                    }

                    /*byte[] data = System.Text.Encoding.Default.GetBytes(message);
                    //서버에서 받은 메시지 화면에 출력하기
                    data = new byte[256];
                    string responeData = "";
                    int bytes = stream.Read(data, 0, data.Length);
                    responeData = Encoding.Default.GetString(data, 0, bytes);
                    Console.WriteLine("수신: {0}", responeData);
                    //서버로 메세지 보내기
                    //리소스 반환하기*/
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                
                    message = comboBox1.SelectedIndex.ToString();
                    byte[] data = System.Text.Encoding.Default.GetBytes(message);
                    stream.Write(data, 0, data.Length);

                
            }
            catch (SocketException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 폼이 닫히는 중에 실행
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stream != null)
            {
                stream.Close();
            }
            if (client != null)
            {
                client.Close();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            product.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Graph g = new Graph();
            g.ShowDialog();
        }
    }
}
