using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeverTest
{
    public partial class Product : Form
    {

        string strConn = "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521)))" +
            "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=xe)));User Id=scott;Password=tiger;";
        OracleConnection conn;
        OracleCommand cmd;


        public Product()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(880, 120);

            conn = new OracleConnection(strConn);
            cmd = new OracleCommand();
            conn.Open();
            cmd.Connection = conn;

            string[] cpu = { "인텔i7-10세대", "인텔i5-10세대", "인텔i3-10세대", "AMD 라이젠7-3세대", "AMD 라이젠5-3세대" };
            cpucombo.Items.AddRange(cpu);

            string[] mainBoard = { "인텔 10세대용 메인보드", "AMD 라이젠 3세대용 메인보드" };
            mbcombo.Items.AddRange(mainBoard);

            string[] power = { "450W", "500W", "600W", "700W" };
            pwcombo.Items.AddRange(power);

            string[] ram = { "8GB", "16GB", "32GB" };
            memorycombo.Items.AddRange(ram);

            string[] ssd = { "250GB", "500GB", "1TB" };
            hdcombo.Items.AddRange(ssd);

            string[] Case = { "Gaming", "Office", "Server", "Video Edit", "Web Surfing" };
            casecombo.Items.AddRange(Case);

        }



        private void mbcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mbcombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '인텔 10세대용메인보드'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    mbstock.Text = sb.ToString();
                }
            }
            else if (mbcombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'AMD 라이젠 3세대용 메인보드'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    mbstock.Text = sb.ToString();
                }
            }
        }

        private int GetLargestTextExtent(System.Windows.Forms.ComboBox cbo)
        {
            int maxLen = -1;
            if (cbo.Items.Count >= 1)
            {
                using (Graphics g = cbo.CreateGraphics())
                {
                    int vertScrollBarWidth = 0;
                    if (cbo.Items.Count > cbo.MaxDropDownItems)
                    {
                        vertScrollBarWidth = SystemInformation.VerticalScrollBarWidth;
                    }
                    for (int nLoopCnt = 0; nLoopCnt < cbo.Items.Count; nLoopCnt++)
                    {
                        int newWidth = (int)g.MeasureString(cbo.Items[nLoopCnt].ToString(), cbo.Font).Width + vertScrollBarWidth;
                        if (newWidth > maxLen)
                        {
                            maxLen = newWidth;
                        }
                    }
                }
            }
            return maxLen;
        }
        private void mdstock_TextChanged(object sender, EventArgs e)
        {

        }
        private void cpucombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cpucombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '인텔i7-10세대'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    cpustock.Text = sb.ToString();
                }
            }

            else if (cpucombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '인텔i5-10세대'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    cpustock.Text = sb.ToString();
                }
            }

            else if (cpucombo.SelectedIndex == 2)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '인텔i3-10세대'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    cpustock.Text = sb.ToString();
                }
            }

            else if (cpucombo.SelectedIndex == 3)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'AMD 라이젠7-3세대'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    cpustock.Text = sb.ToString();
                }
            }
            else if (cpucombo.SelectedIndex == 4)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'AMD 라이젠5-3세대'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    cpustock.Text = sb.ToString();
                }
            }
        }
        private void hdcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (hdcombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '250GB'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    hdstock.Text = sb.ToString();
                }
            }
            else if (hdcombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '500GB'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    hdstock.Text = sb.ToString();
                }
            }
            else if (hdcombo.SelectedIndex == 2)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '1TB'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    hdstock.Text = sb.ToString();
                }
            }
        }
        private void pwcombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (pwcombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '450W'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    pwstock.Text = sb.ToString();
                }
            }
            else if (pwcombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '500W'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    pwstock.Text = sb.ToString();
                }
            }
            else if (pwcombo.SelectedIndex == 2)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '600W'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    pwstock.Text = sb.ToString();
                }
            }
            else if (pwcombo.SelectedIndex == 3)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '700W'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    pwstock.Text = sb.ToString();
                }
            }

        }

        private void memorycombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (memorycombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '8G'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    memorystock.Text = sb.ToString();
                }
            }

            else if (memorycombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '16G'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    memorystock.Text = sb.ToString();
                }
            }

            else if (memorycombo.SelectedIndex == 2)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = '32G'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    memorystock.Text = sb.ToString();
                }
            }
        }

        private void casecombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (casecombo.SelectedIndex == 0)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'Gaming'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    casestock.Text = sb.ToString();
                }
            }

            else if (casecombo.SelectedIndex == 1)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'Office'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    casestock.Text = sb.ToString();
                }
            }

            else if (casecombo.SelectedIndex == 2)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'Server'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    casestock.Text = sb.ToString();
                }
            }

            else if (casecombo.SelectedIndex == 3)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'Video_Edit'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    casestock.Text = sb.ToString();
                }
            }

            else if (casecombo.SelectedIndex == 4)
            {
                cmd.CommandText = "select * from elements where PRODUCTNAME = 'Web_Surfing'";
                OracleDataReader rdr = cmd.ExecuteReader();
                StringBuilder sb = new StringBuilder();

                while (rdr.Read())
                {
                    string stock = rdr["STOCK"].ToString();
                    sb.Append(stock);
                    casestock.Text = sb.ToString();
                }
            }
        }

        // CPU 길이에 맞춰 TEXT 창 늘리기
        private void cpucombo_DropDown(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo == null) { return; }
            int pw = GetLargestTextExtent(combo);
            if (pw != 1)
            {
                if (combo.Width > combo.DropDownWidth)
                {
                    combo.DropDownWidth = combo.Width;
                }
                else
                {
                    combo.DropDownWidth = pw;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        // 메인보드 길이에 맞춰 TEXT 창 늘리기
        private void mbcombo_DropDown(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            if (combo == null) { return; }
            int pw = GetLargestTextExtent(combo);
            if (pw != 1)
            {
                if (combo.Width > combo.DropDownWidth)
                {
                    combo.DropDownWidth = combo.Width;
                }
                else
                {
                    combo.DropDownWidth = pw;
                }
            }
        }

        // 확인 버튼
        public void FieldClear()
        {
            //콤보박스
            mbcombo.SelectedIndex = -1;
            cpucombo.SelectedIndex = -1;
            hdcombo.SelectedIndex = -1;
            pwcombo.SelectedIndex = -1;
            memorycombo.SelectedIndex = -1;
            casecombo.SelectedIndex = -1;
            //텍스트 박스
            mbadd.Text = "";
            mbstock.Text = "";
            cpuadd.Text = "";
            cpustock.Text = "";
            pwadd.Text = "";
            pwstock.Text = "";
            memoryadd.Text = "";
            memorystock.Text = "";
            caseadd.Text = "";
            casestock.Text = "";
            hdadd.Text = "";
            hdstock.Text = "";
        }
        private void confirm_Click(object sender, EventArgs e)
        {
            string madd = mbadd.Text;
            string cadd = cpuadd.Text;
            string hadd = hdadd.Text;
            string padd = pwadd.Text;
            string meadd = memoryadd.Text;
            string shelladd = caseadd.Text;

            // 메인보드 수량
            if (mbcombo.SelectedIndex == 0)
            {
                if (mbadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {madd} where productname = '인텔 10세대용메인보드'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '인텔 10세대용메인보드'";
            }

            if (mbcombo.SelectedIndex == 1)
            {
                if (mbadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {madd} where productname = 'AMD 라이젠 3세대용 메인보드'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '인텔 10세대용메인보드'";

            }
            // CPU 수량
            if (cpucombo.SelectedIndex == 0)
            {
                if (cpuadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {cadd} where productname = '인텔i7-10세대'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '인텔i7-10세대'";
            }

            if (cpucombo.SelectedIndex == 1)
            {
                if (cpuadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {cadd} where productname = '인텔i5-10세대'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '인텔i5-10세대'";
            }

            if (cpucombo.SelectedIndex == 2)
            {
                if (cpuadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {cadd} where productname = '인텔i3-10세대'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '인텔i3-10세대'";
            }

            if (cpucombo.SelectedIndex == 3)
            {
                if (cpuadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {cadd} where productname = 'AMD 라이젠7-3세대'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'AMD 라이젠7-3세대'";
            }

            if (cpucombo.SelectedIndex == 4)
            {
                if (cpuadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {cadd} where productname = 'AMD 라이젠5-3세대'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'AMD 라이젠5-3세대'";
            }

            // 하드 수량
            if (hdcombo.SelectedIndex == 0)
            {
                if (hdadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {hadd} where productname = '250GB'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '250GB'";
            }

            else if (hdcombo.SelectedIndex == 1)
            {
                if (hdadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {hadd} where productname = '500GB'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '500GB'";
            }
            else if (hdcombo.SelectedIndex == 2)
            {
                if (hdadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {hadd} where productname = '1TB'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '1TB'";
            }

            // 파워 수량
            if (pwcombo.SelectedIndex == 0)
            {
                if (pwadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {padd} where productname = '450W'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '450W'";
            }
            else if (pwcombo.SelectedIndex == 1)
            {
                if (pwadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {padd} where productname = '500W'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '500W'";
            }
            else if (pwcombo.SelectedIndex == 2)
            {
                if (pwadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {padd} where productname = '600W'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '600W'";
            }
            else if (pwcombo.SelectedIndex == 3)
            {
                if (pwadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {padd} where productname = '700W'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '700W'";
            }
            // 메모리 수량
            if (memorycombo.SelectedIndex == 0)
            {
                if (memoryadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {meadd} where productname = '8G'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '8G'";
            }
            else if (memorycombo.SelectedIndex == 1)
            {
                if (memoryadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {meadd} where productname = '16G'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '16G'";
            }
            else if (memorycombo.SelectedIndex == 2)
            {
                if (memoryadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {meadd} where productname = '32G'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where '32G'";
            }

            // 케이스 수량
            if (casecombo.SelectedIndex == 0)
            {
                if (caseadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {shelladd} where productname = 'Gaming'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'Gaming'";
            }
            else if (casecombo.SelectedIndex == 1)
            {
                if (caseadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {shelladd} where productname = 'Office'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'Office'";
            }
            else if (casecombo.SelectedIndex == 2)
            {
                if (caseadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {shelladd} where productname = 'Server'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'Server'";
            }
            else if (casecombo.SelectedIndex == 3)
            {
                if (caseadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {shelladd} where productname = 'Video_Edit'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'Video_Edit'";
            }
            else if (casecombo.SelectedIndex == 4)
            {
                if (caseadd.Text != "")
                {
                    cmd.CommandText = $"UPDATE elements set stock= stock+ {shelladd} where productname = 'Web_Surfing'";
                    cmd.ExecuteNonQuery();
                }
                else
                    cmd.CommandText = $"UPDATE elements set stock= stock+0 where 'Web_Surfing'";
            }
            MessageBox.Show("변경이 완료되었습니다.");

            FieldClear();

        }
    } // End of Form1
} // End of 재고관리
