using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using Oracle.ManagedDataAccess.Client;
using System.Runtime.InteropServices;

namespace SeverTest
{
    public partial class main : Form
    {
        delegate void EventHandlerAddCtrl();
        event EventHandlerAddCtrl OnAddCtrl;

        Thread rTh;
        Thread ServerThread;
        Thread UpdateThread;
        Thread FormThread;
        // 클라이언트 : 192.168.132.22
        string bindIP = "127.0.0.1";
        const int bindPort = 5454;
        TcpListener server = null;
        IPEndPoint localAddress = null;
        TcpClient client = null;
        NetworkStream stream = null;
        PictureBox product = null;
        string data = "";
        string err = "";
        int use;

        //db
        string strConn;
        OracleConnection conn = null;
        OracleConnection conn2 = null;
        OracleConnection conn3 = null;
        OracleTransaction STrans = null;
        public main()
        {
            this.OnAddCtrl += new EventHandlerAddCtrl(AddCtrl);
            InitializeComponent();
            // 네트워크 연결 정보 직접 대입
            strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=tiger;";
            // 오라클 연결
            conn = new OracleConnection(strConn);
            conn2 = new OracleConnection(strConn);
            conn3 = new OracleConnection(strConn);

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(480, 120);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            ServerThread = new Thread(connect);
            ServerThread.Start();

            
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                      , int nTopRect
                                      , int nRightRect
                                      , int nBottomRect
                                      , int nWidthEllipse
                                      , int nHeightEllipse);
        public void update()
        {
            try
            {
                conn2.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn2;
                cmd.CommandText = $"UPDATE COMPUTER SET STOCK = STOCK+1 WHERE ID = {data}";
                cmd.ExecuteNonQuery();
                MessageBox.Show("update완료","성공!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn2.Close();
            }
        }
        void AddCtrl()
        {
            Controls.Add(product);
        }
        public static void CrossThread(Control item)
        {
            if (item.InvokeRequired)
            {
                item.BeginInvoke(new MethodInvoker(delegate ()
                {
                    item.Visible = true;
                }));
            }
        }    
        private void connect()
        {
            try
            {
                localAddress =
                    new IPEndPoint(IPAddress.Parse(bindIP), bindPort);
                server = new TcpListener(localAddress);
                server.Start();
                while (true)
                {
                    client = server.AcceptTcpClient();
                    /*Console.WriteLine("클라이언트 접속 : {0}",
                        ((IPEndPoint)client.Client.RemoteEndPoint).ToString());*/
                    
                    stream = client.GetStream();
                    MessageBox.Show("클라이언트와 연결 완료.");
                    int length;
                    
                    byte[] bytes = new byte[256];
                    try
                    {
                        //클라이언트로 부터 도착하는 패킷이 있다면 while이 구동
                        while ((length = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            //데이터 읽기
                            data = Encoding.Default.GetString(bytes, 0, length);
                            /*Console.WriteLine(string.Format("수신: {0}", data));*/

                            byte[] msg = Encoding.Default.GetBytes(data);
                            stream.Write(msg, 0, msg.Length);

                            rTh = new Thread(new ParameterizedThreadStart(MakeCase));
                            rTh.Start(data);
                            
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        //MessageBox.Show(ex.ToString());
                    }
                    finally
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
                }
                
                
            }
            catch (SocketException e)
            {

               // MessageBox.Show(e.ToString());
            }
            finally
            {
                server.Stop();
            }
        }

        private void MakeCase(object data)
        {
            OracleCommand cmd;
            cmd = new OracleCommand();
            try
            {
                use = 1;
                err = "컴퓨터를 만들 재고가 부족합니다. 부족 재고 :\n";
                string num = data.ToString();
                product = new PictureBox();
                product.Location = new System.Drawing.Point(14, 256);
                product.Size = new System.Drawing.Size(112, 102);
                product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                product.TabIndex = 0;
                product.TabStop = false;
                product.BorderStyle = BorderStyle.None;
                product.BackColor = Color.Transparent;
                product.Visible = true;
                Invoke(OnAddCtrl);
                product.BringToFront();

                //db
                conn.Open();
                cmd.Connection = conn;

                if (data.Equals("0"))
                {
                    product.Image = Properties.Resources.게이밍용;
                }
                else if (data.Equals("1"))
                {
                    product.Image = Properties.Resources.사무용;
                }
                else if (data.Equals("2"))
                {
                    product.Image = Properties.Resources.서버용;
                }
                else if (data.Equals("3"))
                {
                    product.Image = Properties.Resources.영상편집용;
                }
                else if (data.Equals("4"))
                {
                    product.Image = Properties.Resources.웹서핑용;
                }
                else
                {
                    MessageBox.Show("올바른 값이 아닙니다.");
                }
                PictureBox[] a = new PictureBox[12];
                a[0] = pictureBox1;
                a[1] = pictureBox2;
                a[2] = pictureBox3;
                a[3] = pictureBox4;
                a[4] = pictureBox5;
                a[5] = pictureBox6;
                a[6] = pictureBox13;
                a[7] = pictureBox14;
                a[8] = pictureBox15;
                a[9] = pictureBox16;
                a[10] = pictureBox17;
                a[11] = pictureBox18;
                //for (int i = 1; i < 13; i++)
                //{
                //    Control[] conlist = this.Controls.Find("pictureBox"+i, true);
                //}

                STrans = conn.BeginTransaction();
                cmd.Transaction = STrans;
                for (int j = 0; j < 6; j++)
                {
                    a[j].Image = Properties.Resources.집게2;
                    if( j == 0)
                    {
                        a[6].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[6].Visible = true;
                                }
                            )
                        );
                        Point p6 = a[6].Location;
                        for (int i = 0; i < 25; i++)
                        {                            
                            int y = a[6].Location.Y + 7;
                            Point p1 = new Point(a[6].Location.X, y);
                            a[6].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[6].Location = p6;
                        a[6].Visible = false;
                    }
                    else if( j == 1)
                    {
                        a[7].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[7].Visible = true;
                                }
                            )
                        );
                        Point p7 = a[7].Location;
                        for (int i = 0; i < 25; i++)
                        {
                            int y = a[7].Location.Y + 7;
                            Point p1 = new Point(a[7].Location.X, y);
                            a[7].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[7].Location = p7;
                        a[7].Visible = false;
                    }
                    else if (j == 2)
                    {
                        a[8].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[8].Visible = true;
                                }
                            )
                        );
                        Point p8 = a[8].Location;
                        for (int i = 0; i < 25; i++)
                        {
                            int y = a[8].Location.Y + 7;
                            Point p1 = new Point(a[8].Location.X, y);
                            a[8].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[8].Location = p8;
                        a[8].Visible = false;
                    }
                    else if (j == 3)
                    {
                        a[9].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[9].Visible = true;
                                }
                            )
                        );
                        Point p9 = a[9].Location;
                        for (int i = 0; i < 25; i++)
                        {
                            int y = a[9].Location.Y + 7;
                            Point p1 = new Point(a[9].Location.X, y);
                            a[9].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[9].Location = p9;
                        a[9].Visible = false;
                    }
                    else if (j == 4)
                    {
                        a[10].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[10].Visible = true;
                                }
                            )
                        );
                        Point p10 = a[10].Location;
                        for (int i = 0; i < 25; i++)
                        {
                            int y = a[10].Location.Y + 7;
                            Point p1 = new Point(a[10].Location.X, y);
                            a[10].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[10].Location = p10;
                        a[10].Visible = false;
                    }
                    else if (j == 5)
                    {
                        a[11].Invoke(
                            new MethodInvoker(
                                delegate () {
                                    a[11].Visible = true;
                                }
                            )
                        );
                        Point p11 = a[11].Location;
                        for (int i = 0; i < 25; i++)
                        {
                            int y = a[11].Location.Y + 7;
                            Point p1 = new Point(a[11].Location.X, y);
                            a[11].Location = p1;
                            Thread.Sleep(10);
                        }
                        a[11].Location = p11;
                        a[11].Visible = false;
                    }
                    Thread.Sleep(1000);
                    a[j].Image = Properties.Resources.집게1;
                    if( j == 0 )
                    {
                        
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 5;                           
                            Point p = new Point(x, product.Location.Y);                          
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔 10세대용메인보드'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔 10세대용메인보드'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'AMD 라이젠 3세대용 메인보드'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔 10세대용메인보드'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'AMD 라이젠 3세대용 메인보드'";
                            cmd.ExecuteNonQuery();
                        }
                        

                    }
                    else if (j == 1)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 5;
                            Point p = new Point(x, product.Location.Y);
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔i5-10세대'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔i3-10세대'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'AMD 라이젠7-3세대'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '인텔i7-10세대'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'AMD 라이젠5-3세대'";
                            cmd.ExecuteNonQuery();
                        }

                    }
                    else if (j == 2)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 5;
                            Point p = new Point(x, product.Location.Y);
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-2 where productname = '16G'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-2 where productname = '8G'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-2 where productname = '32G'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-2 where productname = '16G'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-2 where productname = '8G'";
                            cmd.ExecuteNonQuery();
                        }

                    }
                    else if( j == 3)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 5;
                            Point p = new Point(x, product.Location.Y);
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '600W'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '450W'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '700W'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '600W'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '450W'";
                            cmd.ExecuteNonQuery();
                        }

                    }
                    else if (j == 4)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 5;
                            Point p = new Point(x, product.Location.Y);
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '1TB'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '250GB'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '1TB'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '1TB'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = '250GB'";
                            cmd.ExecuteNonQuery();
                        }
                        

                    }
                    else if (j == 5)
                    {
                        for (int i = 0; i < 25; i++)
                        {
                            int x = product.Location.X + 8;
                            Point p = new Point(x, product.Location.Y);
                            product.Location = p;
                            Thread.Sleep(10);
                        }
                        if (data.Equals("0"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'Gaming'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("1"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'Office'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("2"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'Server'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("3"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'Video_Edit'";
                            cmd.ExecuteNonQuery();
                        }
                        else if (data.Equals("4"))
                        {
                            cmd.CommandText = "update elements set stock = stock-1 where productname = 'Web_Surfing'";
                            cmd.ExecuteNonQuery();
                        }
                        
                    }
                }
                Thread.Sleep(1000);


                /*FindThread = new Thread(FindStock);
                FindThread.Start();*/
                //메인보드
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = '메인보드'";

                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "메인보드 ";
                        break;
                    }
                }
                //cpu
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = 'CPU'";

                // 결과 리더 객체를 리턴
                rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "CPU ";
                        break;
                    }
                }
                //RAM
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = 'RAM'";

                // 결과 리더 객체를 리턴
                rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "RAM ";
                        break;
                    }
                }
                //파워
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = '파워'";

                // 결과 리더 객체를 리턴
                rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "파워 ";
                        break;
                    }
                }
                //SSD
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = 'SSD'";

                // 결과 리더 객체를 리턴
                rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "SSD ";
                        break;
                    }
                }
                //Case
                cmd.CommandText = "SELECT STOCK FROM ELEMENTS WHERE PARTSNAME = 'Case'";

                // 결과 리더 객체를 리턴
                rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())
                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    if (Convert.ToInt32(stock) < 0)
                    {
                        use = 0;
                        err += "Case";
                        break;
                    }
                }
                if (use == 0)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        int y = product.Location.Y - 7;
                        Point p = new Point(product.Location.X, y);
                        product.Location = p;
                        Thread.Sleep(10);
                    }
                    product.Visible = false;
                    cmd.Transaction.Rollback();
                    MessageBox.Show(err, "실패!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (use == 1)
                {
                    for (int i = 0; i < 25; i++)
                    {
                        int y = product.Location.Y + 7;
                        Point p = new Point(product.Location.X, y);
                        product.Location = p;
                        Thread.Sleep(10);
                    }
                    product.Visible = false;
                    cmd.Transaction.Commit();
                    UpdateThread = new Thread(update);
                    UpdateThread.Start();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                cmd.Transaction.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
                if (server != null)
                    server.Stop();
                if (ServerThread.IsAlive == true)
                    ServerThread.Join();
                if (rTh.IsAlive == true)
                    rTh.Join();
            }
            catch(Exception)
            {

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormThread = new Thread(GoProduct);
            FormThread.Start();
        }
        public void GoProduct()
        {
            Product product = new Product();
            product.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graph graph = new Graph();
            graph.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {

        }
    }
}
