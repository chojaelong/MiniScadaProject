namespace ClaDropbox_1
{
    partial class Product
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mbstock = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mbadd = new System.Windows.Forms.TextBox();
            this.mbcombo = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cpustock = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cpuadd = new System.Windows.Forms.TextBox();
            this.cpucombo = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.hdstock = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.hdadd = new System.Windows.Forms.TextBox();
            this.hdcombo = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pwadd = new System.Windows.Forms.TextBox();
            this.pwcombo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.memoryadd = new System.Windows.Forms.TextBox();
            this.memorycombo = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.caseadd = new System.Windows.Forms.TextBox();
            this.casecombo = new System.Windows.Forms.ComboBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.confirm = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.casestock = new System.Windows.Forms.TextBox();
            this.memorystock = new System.Windows.Forms.TextBox();
            this.pwstock = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mbstock);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.mbadd);
            this.groupBox1.Controls.Add(this.mbcombo);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(16, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "메인보드";
            // 
            // mbstock
            // 
            this.mbstock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mbstock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.mbstock.ForeColor = System.Drawing.SystemColors.Control;
            this.mbstock.Location = new System.Drawing.Point(64, 200);
            this.mbstock.Name = "mbstock";
            this.mbstock.Size = new System.Drawing.Size(96, 27);
            this.mbstock.TabIndex = 5;
            this.mbstock.TextChanged += new System.EventHandler(this.mdstock_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 20);
            this.label13.TabIndex = 4;
            this.label13.Text = "재고 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "수량 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "종류 :";
            // 
            // mbadd
            // 
            this.mbadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mbadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.mbadd.ForeColor = System.Drawing.SystemColors.Control;
            this.mbadd.Location = new System.Drawing.Point(64, 168);
            this.mbadd.Name = "mbadd";
            this.mbadd.Size = new System.Drawing.Size(96, 27);
            this.mbadd.TabIndex = 2;
            // 
            // mbcombo
            // 
            this.mbcombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.mbcombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.mbcombo.ForeColor = System.Drawing.SystemColors.Control;
            this.mbcombo.FormattingEnabled = true;
            this.mbcombo.Location = new System.Drawing.Point(64, 136);
            this.mbcombo.Name = "mbcombo";
            this.mbcombo.Size = new System.Drawing.Size(96, 28);
            this.mbcombo.TabIndex = 1;
            this.mbcombo.DropDown += new System.EventHandler(this.mbcombo_DropDown);
            this.mbcombo.SelectedIndexChanged += new System.EventHandler(this.mbcombo_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cpustock);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cpuadd);
            this.groupBox2.Controls.Add(this.cpucombo);
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(192, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 240);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CPU";
            // 
            // cpustock
            // 
            this.cpustock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cpustock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.cpustock.ForeColor = System.Drawing.SystemColors.Control;
            this.cpustock.Location = new System.Drawing.Point(64, 200);
            this.cpustock.Name = "cpustock";
            this.cpustock.Size = new System.Drawing.Size(96, 27);
            this.cpustock.TabIndex = 6;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 200);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 20);
            this.label14.TabIndex = 5;
            this.label14.Text = "재고 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "수량 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "종류 :";
            // 
            // cpuadd
            // 
            this.cpuadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cpuadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.cpuadd.ForeColor = System.Drawing.SystemColors.Control;
            this.cpuadd.Location = new System.Drawing.Point(64, 168);
            this.cpuadd.Name = "cpuadd";
            this.cpuadd.Size = new System.Drawing.Size(96, 27);
            this.cpuadd.TabIndex = 2;
            // 
            // cpucombo
            // 
            this.cpucombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cpucombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.cpucombo.ForeColor = System.Drawing.SystemColors.Control;
            this.cpucombo.FormattingEnabled = true;
            this.cpucombo.Location = new System.Drawing.Point(64, 136);
            this.cpucombo.Name = "cpucombo";
            this.cpucombo.Size = new System.Drawing.Size(96, 28);
            this.cpucombo.TabIndex = 1;
            this.cpucombo.DropDown += new System.EventHandler(this.cpucombo_DropDown);
            this.cpucombo.SelectedIndexChanged += new System.EventHandler(this.cpucombo_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.hdstock);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.hdadd);
            this.groupBox3.Controls.Add(this.hdcombo);
            this.groupBox3.Controls.Add(this.pictureBox3);
            this.groupBox3.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(368, 32);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 240);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "하드";
            // 
            // hdstock
            // 
            this.hdstock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hdstock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.hdstock.ForeColor = System.Drawing.SystemColors.Control;
            this.hdstock.Location = new System.Drawing.Point(64, 200);
            this.hdstock.Name = "hdstock";
            this.hdstock.Size = new System.Drawing.Size(96, 27);
            this.hdstock.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(8, 200);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 20);
            this.label15.TabIndex = 6;
            this.label15.Text = "재고 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "수량 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "종류 :";
            // 
            // hdadd
            // 
            this.hdadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hdadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.hdadd.ForeColor = System.Drawing.SystemColors.Control;
            this.hdadd.Location = new System.Drawing.Point(64, 168);
            this.hdadd.Name = "hdadd";
            this.hdadd.Size = new System.Drawing.Size(96, 27);
            this.hdadd.TabIndex = 2;
            // 
            // hdcombo
            // 
            this.hdcombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.hdcombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.hdcombo.ForeColor = System.Drawing.SystemColors.Control;
            this.hdcombo.FormattingEnabled = true;
            this.hdcombo.Location = new System.Drawing.Point(64, 136);
            this.hdcombo.Name = "hdcombo";
            this.hdcombo.Size = new System.Drawing.Size(96, 28);
            this.hdcombo.TabIndex = 1;
            this.hdcombo.SelectedIndexChanged += new System.EventHandler(this.hdcombo_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.pwadd);
            this.groupBox4.Controls.Add(this.pwcombo);
            this.groupBox4.Controls.Add(this.pictureBox4);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(8, 312);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 240);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "파워";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "수량 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "종류 :";
            // 
            // pwadd
            // 
            this.pwadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pwadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.pwadd.ForeColor = System.Drawing.SystemColors.Control;
            this.pwadd.Location = new System.Drawing.Point(64, 168);
            this.pwadd.Name = "pwadd";
            this.pwadd.Size = new System.Drawing.Size(96, 27);
            this.pwadd.TabIndex = 2;
            // 
            // pwcombo
            // 
            this.pwcombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pwcombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.pwcombo.ForeColor = System.Drawing.SystemColors.Control;
            this.pwcombo.FormattingEnabled = true;
            this.pwcombo.Location = new System.Drawing.Point(64, 136);
            this.pwcombo.Name = "pwcombo";
            this.pwcombo.Size = new System.Drawing.Size(96, 28);
            this.pwcombo.TabIndex = 1;
            this.pwcombo.SelectedIndexChanged += new System.EventHandler(this.pwcombo_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.memoryadd);
            this.groupBox5.Controls.Add(this.memorycombo);
            this.groupBox5.Controls.Add(this.pictureBox5);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(184, 312);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(168, 240);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "메모리";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "수량 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 136);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "종류 :";
            // 
            // memoryadd
            // 
            this.memoryadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memoryadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.memoryadd.ForeColor = System.Drawing.SystemColors.Control;
            this.memoryadd.Location = new System.Drawing.Point(64, 168);
            this.memoryadd.Name = "memoryadd";
            this.memoryadd.Size = new System.Drawing.Size(96, 27);
            this.memoryadd.TabIndex = 2;
            // 
            // memorycombo
            // 
            this.memorycombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memorycombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.memorycombo.ForeColor = System.Drawing.SystemColors.Control;
            this.memorycombo.FormattingEnabled = true;
            this.memorycombo.Location = new System.Drawing.Point(64, 136);
            this.memorycombo.Name = "memorycombo";
            this.memorycombo.Size = new System.Drawing.Size(96, 28);
            this.memorycombo.TabIndex = 1;
            this.memorycombo.SelectedIndexChanged += new System.EventHandler(this.memorycombo_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.caseadd);
            this.groupBox6.Controls.Add(this.casecombo);
            this.groupBox6.Controls.Add(this.pictureBox6);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(360, 312);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(168, 240);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "케이스";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 3;
            this.label11.Text = "수량 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 3;
            this.label12.Text = "종류 :";
            // 
            // caseadd
            // 
            this.caseadd.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.caseadd.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.caseadd.ForeColor = System.Drawing.SystemColors.Control;
            this.caseadd.Location = new System.Drawing.Point(64, 168);
            this.caseadd.Name = "caseadd";
            this.caseadd.Size = new System.Drawing.Size(96, 27);
            this.caseadd.TabIndex = 2;
            // 
            // casecombo
            // 
            this.casecombo.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.casecombo.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.casecombo.ForeColor = System.Drawing.SystemColors.Control;
            this.casecombo.FormattingEnabled = true;
            this.casecombo.Location = new System.Drawing.Point(64, 136);
            this.casecombo.Name = "casecombo";
            this.casecombo.Size = new System.Drawing.Size(96, 28);
            this.casecombo.TabIndex = 1;
            this.casecombo.SelectedIndexChanged += new System.EventHandler(this.casecombo_SelectedIndexChanged);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox4);
            this.groupBox7.Controls.Add(this.groupBox5);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Location = new System.Drawing.Point(8, 8);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(544, 600);
            this.groupBox7.TabIndex = 2;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "재고관리";
            // 
            // confirm
            // 
            this.confirm.Location = new System.Drawing.Point(384, 568);
            this.confirm.Name = "confirm";
            this.confirm.Size = new System.Drawing.Size(75, 31);
            this.confirm.TabIndex = 3;
            this.confirm.Text = "완료";
            this.confirm.UseVisualStyleBackColor = true;
            this.confirm.Click += new System.EventHandler(this.confirm_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(464, 568);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "취소";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(24, 520);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(48, 20);
            this.label16.TabIndex = 7;
            this.label16.Text = "재고 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(200, 520);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 20);
            this.label17.TabIndex = 8;
            this.label17.Text = "재고 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(376, 520);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(48, 20);
            this.label18.TabIndex = 9;
            this.label18.Text = "재고 :";
            // 
            // casestock
            // 
            this.casestock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.casestock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.casestock.ForeColor = System.Drawing.SystemColors.Control;
            this.casestock.Location = new System.Drawing.Point(432, 520);
            this.casestock.Name = "casestock";
            this.casestock.Size = new System.Drawing.Size(96, 27);
            this.casestock.TabIndex = 7;
            // 
            // memorystock
            // 
            this.memorystock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.memorystock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.memorystock.ForeColor = System.Drawing.SystemColors.Control;
            this.memorystock.Location = new System.Drawing.Point(256, 520);
            this.memorystock.Name = "memorystock";
            this.memorystock.Size = new System.Drawing.Size(96, 27);
            this.memorystock.TabIndex = 8;
            // 
            // pwstock
            // 
            this.pwstock.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pwstock.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.pwstock.ForeColor = System.Drawing.SystemColors.Control;
            this.pwstock.Location = new System.Drawing.Point(80, 520);
            this.pwstock.Name = "pwstock";
            this.pwstock.Size = new System.Drawing.Size(96, 27);
            this.pwstock.TabIndex = 9;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::ClaDropbox_1.Properties.Resources.disk;
            this.pictureBox3.Location = new System.Drawing.Point(8, 24);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 96);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ClaDropbox_1.Properties.Resources.cpu;
            this.pictureBox2.Location = new System.Drawing.Point(8, 24);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(152, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ClaDropbox_1.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(8, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::ClaDropbox_1.Properties.Resources.power;
            this.pictureBox4.Location = new System.Drawing.Point(8, 24);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(152, 96);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::ClaDropbox_1.Properties.Resources.ram;
            this.pictureBox5.Location = new System.Drawing.Point(8, 24);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(152, 96);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::ClaDropbox_1.Properties.Resources._case;
            this.pictureBox6.Location = new System.Drawing.Point(8, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(152, 96);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(561, 617);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.casestock);
            this.Controls.Add(this.memorystock);
            this.Controls.Add(this.pwstock);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mbadd;
        private System.Windows.Forms.ComboBox mbcombo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cpuadd;
        private System.Windows.Forms.ComboBox cpucombo;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox hdadd;
        private System.Windows.Forms.ComboBox hdcombo;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox pwadd;
        private System.Windows.Forms.ComboBox pwcombo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox memoryadd;
        private System.Windows.Forms.ComboBox memorycombo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox caseadd;
        private System.Windows.Forms.ComboBox casecombo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button confirm;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox mbstock;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox cpustock;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox hdstock;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox casestock;
        private System.Windows.Forms.TextBox memorystock;
        private System.Windows.Forms.TextBox pwstock;
    }
}

