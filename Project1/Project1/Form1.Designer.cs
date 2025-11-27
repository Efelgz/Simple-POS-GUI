namespace Project1
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblDate = new DevExpress.XtraEditors.LabelControl();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnGiris = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton14 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton9 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton12 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton11 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton10 = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.lblClock = new DevExpress.XtraEditors.LabelControl();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.TextBoxPin = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Appearance.Options.UseFont = true;
            this.lblDate.Location = new System.Drawing.Point(1554, 25);
            this.lblDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(61, 29);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Tarih";
            // 
            // timerClock
            // 
            this.timerClock.Enabled = true;
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick_1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(2, 2);
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.71648F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.56705F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.btnGiris, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton14, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton9, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton11, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton5, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.simpleButton10, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSil, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1242, 201);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(637, 554);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btnGiris
            // 
            this.btnGiris.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGiris.Appearance.BackColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnGiris.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.btnGiris.Appearance.Options.UseBackColor = true;
            this.btnGiris.Appearance.Options.UseBorderColor = true;
            this.btnGiris.Appearance.Options.UseFont = true;
            this.btnGiris.Appearance.Options.UseForeColor = true;
            this.btnGiris.AppearanceDisabled.BackColor = System.Drawing.Color.DarkRed;
            this.btnGiris.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnGiris.AppearanceDisabled.Options.UseBackColor = true;
            this.btnGiris.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnGiris.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnGiris.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnGiris.AppearanceHovered.Options.UseBackColor = true;
            this.btnGiris.AppearanceHovered.Options.UseBorderColor = true;
            this.btnGiris.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnGiris.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.btnGiris.AppearancePressed.Options.UseBackColor = true;
            this.btnGiris.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnGiris.Location = new System.Drawing.Point(426, 417);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(208, 134);
            this.btnGiris.TabIndex = 8;
            this.btnGiris.Text = "GİRİŞ";
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // simpleButton14
            // 
            this.simpleButton14.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton14.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton14.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton14.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton14.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton14.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton14.Appearance.Options.UseBackColor = true;
            this.simpleButton14.Appearance.Options.UseBorderColor = true;
            this.simpleButton14.Appearance.Options.UseFont = true;
            this.simpleButton14.Appearance.Options.UseForeColor = true;
            this.simpleButton14.AppearanceDisabled.BackColor = System.Drawing.Color.DarkRed;
            this.simpleButton14.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.simpleButton14.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.simpleButton14.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton14.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton14.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton14.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton14.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton14.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton14.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton14.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton14.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton14.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton14.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton14.Location = new System.Drawing.Point(218, 417);
            this.simpleButton14.Name = "simpleButton14";
            this.simpleButton14.Size = new System.Drawing.Size(202, 134);
            this.simpleButton14.TabIndex = 9;
            this.simpleButton14.Text = "0";
            this.simpleButton14.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton9
            // 
            this.simpleButton9.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton9.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton9.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton9.Appearance.Options.UseBackColor = true;
            this.simpleButton9.Appearance.Options.UseFont = true;
            this.simpleButton9.Appearance.Options.UseForeColor = true;
            this.simpleButton9.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton9.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton9.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton9.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton9.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton9.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton9.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton9.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton9.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton9.Location = new System.Drawing.Point(426, 279);
            this.simpleButton9.Name = "simpleButton9";
            this.simpleButton9.Size = new System.Drawing.Size(208, 132);
            this.simpleButton9.TabIndex = 7;
            this.simpleButton9.Text = "9";
            this.simpleButton9.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton12
            // 
            this.simpleButton12.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton12.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton12.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton12.Appearance.Options.UseBackColor = true;
            this.simpleButton12.Appearance.Options.UseFont = true;
            this.simpleButton12.Appearance.Options.UseForeColor = true;
            this.simpleButton12.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton12.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton12.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton12.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton12.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton12.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton12.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton12.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton12.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton12.Location = new System.Drawing.Point(426, 141);
            this.simpleButton12.Name = "simpleButton12";
            this.simpleButton12.Size = new System.Drawing.Size(208, 132);
            this.simpleButton12.TabIndex = 10;
            this.simpleButton12.Text = "6";
            this.simpleButton12.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton4.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton4.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton4.Appearance.Options.UseBackColor = true;
            this.simpleButton4.Appearance.Options.UseFont = true;
            this.simpleButton4.Appearance.Options.UseForeColor = true;
            this.simpleButton4.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton4.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton4.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton4.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton4.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton4.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton4.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton4.Location = new System.Drawing.Point(426, 3);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(208, 132);
            this.simpleButton4.TabIndex = 3;
            this.simpleButton4.Text = "3";
            this.simpleButton4.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton11
            // 
            this.simpleButton11.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton11.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton11.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton11.Appearance.Options.UseBackColor = true;
            this.simpleButton11.Appearance.Options.UseFont = true;
            this.simpleButton11.Appearance.Options.UseForeColor = true;
            this.simpleButton11.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton11.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton11.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton11.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton11.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton11.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton11.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton11.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton11.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton11.Location = new System.Drawing.Point(218, 279);
            this.simpleButton11.Name = "simpleButton11";
            this.simpleButton11.Size = new System.Drawing.Size(202, 132);
            this.simpleButton11.TabIndex = 9;
            this.simpleButton11.Text = "8";
            this.simpleButton11.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton3.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton3.Appearance.Options.UseBackColor = true;
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Appearance.Options.UseForeColor = true;
            this.simpleButton3.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton3.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton3.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton3.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton3.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton3.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton3.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton3.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton3.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton3.Location = new System.Drawing.Point(3, 141);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(209, 132);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "4";
            this.simpleButton3.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.Appearance.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseBorderColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.AppearanceDisabled.BackColor = System.Drawing.Color.DarkRed;
            this.simpleButton1.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton1.AppearanceDisabled.Options.UseBorderColor = true;
            this.simpleButton1.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.simpleButton1.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton1.AppearanceHovered.Options.UseBorderColor = true;
            this.simpleButton1.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton1.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton1.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(3, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(209, 132);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "1";
            this.simpleButton1.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton2.Appearance.BackColor2 = System.Drawing.Color.White;
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton2.Appearance.Options.UseBackColor = true;
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.Appearance.Options.UseForeColor = true;
            this.simpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(218, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(202, 132);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "2";
            this.simpleButton2.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton5.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton5.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton5.Appearance.Options.UseBackColor = true;
            this.simpleButton5.Appearance.Options.UseFont = true;
            this.simpleButton5.Appearance.Options.UseForeColor = true;
            this.simpleButton5.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton5.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton5.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton5.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton5.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton5.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton5.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton5.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton5.Location = new System.Drawing.Point(218, 141);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(202, 132);
            this.simpleButton5.TabIndex = 3;
            this.simpleButton5.Text = "5";
            this.simpleButton5.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // simpleButton10
            // 
            this.simpleButton10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton10.Appearance.BackColor = System.Drawing.Color.White;
            this.simpleButton10.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton10.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton10.Appearance.Options.UseBackColor = true;
            this.simpleButton10.Appearance.Options.UseFont = true;
            this.simpleButton10.Appearance.Options.UseForeColor = true;
            this.simpleButton10.AppearanceDisabled.BackColor = System.Drawing.Color.White;
            this.simpleButton10.AppearanceDisabled.Options.UseBackColor = true;
            this.simpleButton10.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.simpleButton10.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.simpleButton10.AppearanceHovered.Options.UseBackColor = true;
            this.simpleButton10.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.simpleButton10.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.simpleButton10.AppearancePressed.Options.UseBackColor = true;
            this.simpleButton10.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton10.Location = new System.Drawing.Point(3, 279);
            this.simpleButton10.Name = "simpleButton10";
            this.simpleButton10.Size = new System.Drawing.Size(209, 132);
            this.simpleButton10.TabIndex = 8;
            this.simpleButton10.Text = "7";
            this.simpleButton10.Click += new System.EventHandler(this.Numpad_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Appearance.BackColor = System.Drawing.Color.White;
            this.btnSil.Appearance.BackColor2 = System.Drawing.Color.White;
            this.btnSil.Appearance.BorderColor = System.Drawing.Color.White;
            this.btnSil.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnSil.Appearance.Options.UseBackColor = true;
            this.btnSil.Appearance.Options.UseBorderColor = true;
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.Appearance.Options.UseForeColor = true;
            this.btnSil.AppearanceDisabled.BackColor = System.Drawing.Color.DarkRed;
            this.btnSil.AppearanceDisabled.BackColor2 = System.Drawing.Color.White;
            this.btnSil.AppearanceDisabled.BorderColor = System.Drawing.Color.White;
            this.btnSil.AppearanceDisabled.Options.UseBackColor = true;
            this.btnSil.AppearanceDisabled.Options.UseBorderColor = true;
            this.btnSil.AppearanceHovered.BackColor = System.Drawing.Color.White;
            this.btnSil.AppearanceHovered.BackColor2 = System.Drawing.Color.White;
            this.btnSil.AppearanceHovered.BorderColor = System.Drawing.Color.White;
            this.btnSil.AppearanceHovered.Options.UseBackColor = true;
            this.btnSil.AppearanceHovered.Options.UseBorderColor = true;
            this.btnSil.AppearancePressed.BackColor = System.Drawing.Color.White;
            this.btnSil.AppearancePressed.BackColor2 = System.Drawing.Color.White;
            this.btnSil.AppearancePressed.Options.UseBackColor = true;
            this.btnSil.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSil.Location = new System.Drawing.Point(3, 417);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(209, 134);
            this.btnSil.TabIndex = 10;
            this.btnSil.Text = "SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblClock
            // 
            this.lblClock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblClock.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClock.Appearance.Options.UseFont = true;
            this.lblClock.Location = new System.Drawing.Point(1948, 25);
            this.lblClock.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(53, 29);
            this.lblClock.TabIndex = 7;
            this.lblClock.Text = "Saat";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.ForeColor = System.Drawing.Color.DimGray;
            this.textBox1.Location = new System.Drawing.Point(4, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 48);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "PİN :";
            // 
            // panelControl1
            // 
            this.panelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.panelControl1.Controls.Add(this.lblClock);
            this.panelControl1.Controls.Add(this.lblDate);
            this.panelControl1.Location = new System.Drawing.Point(-316, -1);
            this.panelControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(2242, 71);
            this.panelControl1.TabIndex = 11;
            // 
            // TextBoxPin
            // 
            this.TextBoxPin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxPin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBoxPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextBoxPin.Location = new System.Drawing.Point(120, 4);
            this.TextBoxPin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TextBoxPin.Name = "TextBoxPin";
            this.TextBoxPin.PasswordChar = '*';
            this.TextBoxPin.Size = new System.Drawing.Size(511, 45);
            this.TextBoxPin.TabIndex = 12;
            this.TextBoxPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 517F));
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TextBoxPin, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1242, 113);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(634, 53);
            this.tableLayoutPanel2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelControl1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblDate;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton9;
        private DevExpress.XtraEditors.SimpleButton simpleButton10;
        private DevExpress.XtraEditors.SimpleButton simpleButton12;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton11;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.LabelControl lblClock;
        private DevExpress.XtraEditors.SimpleButton btnGiris;
        private DevExpress.XtraEditors.SimpleButton simpleButton14;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox TextBoxPin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

