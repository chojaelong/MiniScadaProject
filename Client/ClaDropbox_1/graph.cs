using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClaDropbox_1
{
    public partial class Graph : Form
    {
        //db
        string strConn;
        OracleConnection conn = null;
        public Graph()
        {
            InitializeComponent();
            // 네트워크 연결 정보 직접 대입
            strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=tiger;";
            // 오라클 연결
            conn = new OracleConnection(strConn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(20, 360);
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));

            List<string> x = new List<string> { "게이밍", "사무용", "서버용", "영상편집용", "웹서핑용" };
            List<double> y = new List<double> { };

            try
            {
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT STOCK FROM COMPUTER";

                // 결과 리더 객체를 리턴
                OracleDataReader rdr = cmd.ExecuteReader();
                // 레코드 계속 가져와서 루핑
                while (rdr.Read())

                {
                    // 필드 데이타 읽기
                    string stock = rdr["STOCK"].ToString();
                    y.Add(Convert.ToInt32(stock));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                conn.Close();
            }

            chart1.Series[0].Points.DataBindXY(x, y);
        }
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect
                                      , int nTopRect
                                      , int nRightRect
                                      , int nBottomRect
                                      , int nWidthEllipse
                                      , int nHeightEllipse);


        class computer
        {
            public string Name { get; set; }
            public double Score { get; set; }

            public computer(string name, double score)
            {
                this.Name = name;
                this.Score = score;
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

