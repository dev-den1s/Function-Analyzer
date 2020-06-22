namespace Project3_Savchenko51908
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dsPlikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dsZapiszPlikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dsOdczytajplikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.dsExitPlikMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dslabel1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dslbX = new System.Windows.Forms.Label();
            this.dsgbWykress = new System.Windows.Forms.GroupBox();
            this.dstbGruboscLinii = new System.Windows.Forms.TrackBar();
            this.dscbStylLinii = new System.Windows.Forms.ComboBox();
            this.dscmKolorTla = new System.Windows.Forms.ComboBox();
            this.dscbKolorLinii = new System.Windows.Forms.ComboBox();
            this.dstbX = new System.Windows.Forms.TextBox();
            this.dstbH = new System.Windows.Forms.TextBox();
            this.dstbXg = new System.Windows.Forms.TextBox();
            this.dstbXd = new System.Windows.Forms.TextBox();
            this.dstbEps = new System.Windows.Forms.TextBox();
            this.dslbEps = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dsgbOs = new System.Windows.Forms.GroupBox();
            this.dsrbZOpisem = new System.Windows.Forms.RadioButton();
            this.dsrbBezOpisu = new System.Windows.Forms.RadioButton();
            this.dstbXdCalk = new System.Windows.Forms.TextBox();
            this.dstbEpsCalk = new System.Windows.Forms.TextBox();
            this.dstbXgCalk = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.dscbMetodaCalk = new System.Windows.Forms.ComboBox();
            this.dsbtnCalka = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.dstbObliczonaCalka = new System.Windows.Forms.TextBox();
            this.dsbtnObliczWartosc = new System.Windows.Forms.Button();
            this.dsbtnTabela = new System.Windows.Forms.Button();
            this.dsbtnGraphic = new System.Windows.Forms.Button();
            this.dsbtnResetuj = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dsdgv = new System.Windows.Forms.DataGridView();
            this.dslicz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsfx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsch = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dslbWartosc = new System.Windows.Forms.Label();
            this.dstbWynikFunkcji = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.dsgbWykress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstbGruboscLinii)).BeginInit();
            this.dsgbOs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsPlikMenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1214, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dsPlikMenu
            // 
            this.dsPlikMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dsZapiszPlikMenu,
            this.dsOdczytajplikMenu,
            this.dsExitPlikMenu});
            this.dsPlikMenu.Name = "dsPlikMenu";
            this.dsPlikMenu.Size = new System.Drawing.Size(37, 20);
            this.dsPlikMenu.Text = "&Plik";
            // 
            // dsZapiszPlikMenu
            // 
            this.dsZapiszPlikMenu.Name = "dsZapiszPlikMenu";
            this.dsZapiszPlikMenu.Size = new System.Drawing.Size(192, 22);
            this.dsZapiszPlikMenu.Text = "Zapisz tablice w pliku";
            this.dsZapiszPlikMenu.Click += new System.EventHandler(this.dsZapiszPlikMenu_Click);
            // 
            // dsOdczytajplikMenu
            // 
            this.dsOdczytajplikMenu.Name = "dsOdczytajplikMenu";
            this.dsOdczytajplikMenu.Size = new System.Drawing.Size(192, 22);
            this.dsOdczytajplikMenu.Text = "Odczytaj tablice z pliku";
            this.dsOdczytajplikMenu.Click += new System.EventHandler(this.dsOdczytajplikMenu_Click);
            // 
            // dsExitPlikMenu
            // 
            this.dsExitPlikMenu.Name = "dsExitPlikMenu";
            this.dsExitPlikMenu.Size = new System.Drawing.Size(192, 22);
            this.dsExitPlikMenu.Text = "Exit";
            this.dsExitPlikMenu.Click += new System.EventHandler(this.dsExitPlikMenu_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dslabel1
            // 
            this.dslabel1.AutoSize = true;
            this.dslabel1.BackColor = System.Drawing.Color.Black;
            this.dslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dslabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.dslabel1.Location = new System.Drawing.Point(464, 24);
            this.dslabel1.Name = "dslabel1";
            this.dslabel1.Size = new System.Drawing.Size(303, 31);
            this.dslabel1.TabIndex = 2;
            this.dslabel1.Text = "Analizator funkcji F(X)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(121, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kolor linii wykresu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(441, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kolor tla dla wykresu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(758, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Styl linii wykresu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(1016, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Grubosc linii wykresu";
            // 
            // dslbX
            // 
            this.dslbX.AutoSize = true;
            this.dslbX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dslbX.Location = new System.Drawing.Point(23, 184);
            this.dslbX.Name = "dslbX";
            this.dslbX.Size = new System.Drawing.Size(260, 13);
            this.dslbX.TabIndex = 7;
            this.dslbX.Text = "Wartosc zmiennej niezaleznej X (-0,2<X<0,2)";
            // 
            // dsgbWykress
            // 
            this.dsgbWykress.Controls.Add(this.dstbGruboscLinii);
            this.dsgbWykress.Controls.Add(this.dscbStylLinii);
            this.dsgbWykress.Controls.Add(this.dscmKolorTla);
            this.dsgbWykress.Controls.Add(this.dscbKolorLinii);
            this.dsgbWykress.Controls.Add(this.label1);
            this.dsgbWykress.Controls.Add(this.label2);
            this.dsgbWykress.Controls.Add(this.label3);
            this.dsgbWykress.Controls.Add(this.label4);
            this.dsgbWykress.Enabled = false;
            this.dsgbWykress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsgbWykress.Location = new System.Drawing.Point(12, 58);
            this.dsgbWykress.Name = "dsgbWykress";
            this.dsgbWykress.Size = new System.Drawing.Size(1202, 100);
            this.dsgbWykress.TabIndex = 9;
            this.dsgbWykress.TabStop = false;
            this.dsgbWykress.Text = "Styl wykresu";
            // 
            // dstbGruboscLinii
            // 
            this.dstbGruboscLinii.BackColor = System.Drawing.Color.Black;
            this.dstbGruboscLinii.Location = new System.Drawing.Point(1016, 31);
            this.dstbGruboscLinii.Maximum = 4;
            this.dstbGruboscLinii.Minimum = 1;
            this.dstbGruboscLinii.Name = "dstbGruboscLinii";
            this.dstbGruboscLinii.Size = new System.Drawing.Size(174, 45);
            this.dstbGruboscLinii.TabIndex = 5;
            this.dstbGruboscLinii.Value = 4;
            this.dstbGruboscLinii.Scroll += new System.EventHandler(this.dstbGruboscLinii_Scroll);
            // 
            // dscbStylLinii
            // 
            this.dscbStylLinii.BackColor = System.Drawing.Color.Black;
            this.dscbStylLinii.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dscbStylLinii.FormattingEnabled = true;
            this.dscbStylLinii.Items.AddRange(new object[] {
            "Dash",
            "Dot",
            "Dash-Dot",
            "Solid"});
            this.dscbStylLinii.Location = new System.Drawing.Point(733, 31);
            this.dscbStylLinii.Name = "dscbStylLinii";
            this.dscbStylLinii.Size = new System.Drawing.Size(197, 25);
            this.dscbStylLinii.TabIndex = 12;
            this.dscbStylLinii.Text = "Wybierz styl linii wykresu";
            this.dscbStylLinii.SelectedIndexChanged += new System.EventHandler(this.dscbStylLinii_SelectedIndexChanged);
            // 
            // dscmKolorTla
            // 
            this.dscmKolorTla.BackColor = System.Drawing.Color.Black;
            this.dscmKolorTla.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dscmKolorTla.FormattingEnabled = true;
            this.dscmKolorTla.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Blue",
            "Yellow"});
            this.dscmKolorTla.Location = new System.Drawing.Point(430, 31);
            this.dscmKolorTla.Name = "dscmKolorTla";
            this.dscmKolorTla.Size = new System.Drawing.Size(197, 25);
            this.dscmKolorTla.TabIndex = 11;
            this.dscmKolorTla.Text = "Wybierz kolor tla wykresu";
            this.dscmKolorTla.SelectedIndexChanged += new System.EventHandler(this.dscmKolorTla_SelectedIndexChanged);
            // 
            // dscbKolorLinii
            // 
            this.dscbKolorLinii.BackColor = System.Drawing.Color.Black;
            this.dscbKolorLinii.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dscbKolorLinii.FormattingEnabled = true;
            this.dscbKolorLinii.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Blue",
            "Yellow"});
            this.dscbKolorLinii.Location = new System.Drawing.Point(98, 31);
            this.dscbKolorLinii.Name = "dscbKolorLinii";
            this.dscbKolorLinii.Size = new System.Drawing.Size(197, 25);
            this.dscbKolorLinii.TabIndex = 10;
            this.dscbKolorLinii.Text = "Wybierz kolor linii wykresu";
            this.dscbKolorLinii.SelectedIndexChanged += new System.EventHandler(this.dscbKolorLinii_SelectedIndexChanged);
            // 
            // dstbX
            // 
            this.dstbX.Location = new System.Drawing.Point(26, 200);
            this.dstbX.Name = "dstbX";
            this.dstbX.Size = new System.Drawing.Size(183, 20);
            this.dstbX.TabIndex = 10;
            // 
            // dstbH
            // 
            this.dstbH.Location = new System.Drawing.Point(26, 485);
            this.dstbH.Name = "dstbH";
            this.dstbH.Size = new System.Drawing.Size(183, 20);
            this.dstbH.TabIndex = 11;
            // 
            // dstbXg
            // 
            this.dstbXg.Location = new System.Drawing.Point(25, 415);
            this.dstbXg.Name = "dstbXg";
            this.dstbXg.Size = new System.Drawing.Size(183, 20);
            this.dstbXg.TabIndex = 12;
            // 
            // dstbXd
            // 
            this.dstbXd.Location = new System.Drawing.Point(26, 329);
            this.dstbXd.Name = "dstbXd";
            this.dstbXd.Size = new System.Drawing.Size(183, 20);
            this.dstbXd.TabIndex = 13;
            // 
            // dstbEps
            // 
            this.dstbEps.Location = new System.Drawing.Point(25, 259);
            this.dstbEps.Name = "dstbEps";
            this.dstbEps.Size = new System.Drawing.Size(183, 20);
            this.dstbEps.TabIndex = 14;
            // 
            // dslbEps
            // 
            this.dslbEps.AutoSize = true;
            this.dslbEps.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dslbEps.Location = new System.Drawing.Point(22, 234);
            this.dslbEps.Name = "dslbEps";
            this.dslbEps.Size = new System.Drawing.Size(222, 13);
            this.dslbEps.TabIndex = 15;
            this.dslbEps.Text = "Dokladnosc obliczen Eps (0<Eps<1.0)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(23, 291);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Xd - dolna granica przedzialu zmian X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(23, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(196, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "(w przedziale zbieznosci szeregu)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(23, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(221, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Xg - gorna granica przedzialu zmian X";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(23, 389);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(193, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "spelniajacego warunek: Xd<=Xg)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(815, 523);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Dolna granica calkowania";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(23, 376);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "(w przedziale zbieznosci szeregu,";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(23, 456);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "zmian wartosci zmiennej";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(23, 469);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 23;
            this.label13.Text = "niezaleznej X";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(23, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(213, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Krok (przyrost) h (0.0<h<=(Xg-Xd)/2)";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dsgbOs
            // 
            this.dsgbOs.Controls.Add(this.dsrbZOpisem);
            this.dsgbOs.Controls.Add(this.dsrbBezOpisu);
            this.dsgbOs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsgbOs.Location = new System.Drawing.Point(110, 523);
            this.dsgbOs.Name = "dsgbOs";
            this.dsgbOs.Size = new System.Drawing.Size(346, 100);
            this.dsgbOs.TabIndex = 25;
            this.dsgbOs.TabStop = false;
            this.dsgbOs.Text = "Wykreslianie osi ukladu wspolrzednych i ich opisu";
            // 
            // dsrbZOpisem
            // 
            this.dsrbZOpisem.AutoSize = true;
            this.dsrbZOpisem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsrbZOpisem.Location = new System.Drawing.Point(34, 52);
            this.dsrbZOpisem.Name = "dsrbZOpisem";
            this.dsrbZOpisem.Size = new System.Drawing.Size(287, 19);
            this.dsrbZOpisem.TabIndex = 30;
            this.dsrbZOpisem.Text = "Linie osi ukladu wspolrzednych z opisem";
            this.dsrbZOpisem.UseVisualStyleBackColor = true;
            // 
            // dsrbBezOpisu
            // 
            this.dsrbBezOpisu.AutoSize = true;
            this.dsrbBezOpisu.Checked = true;
            this.dsrbBezOpisu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsrbBezOpisu.Location = new System.Drawing.Point(34, 27);
            this.dsrbBezOpisu.Name = "dsrbBezOpisu";
            this.dsrbBezOpisu.Size = new System.Drawing.Size(291, 19);
            this.dsrbBezOpisu.TabIndex = 29;
            this.dsrbBezOpisu.TabStop = true;
            this.dsrbBezOpisu.Text = "Linie osi ukladu wspolrzednych bez opisu";
            this.dsrbBezOpisu.UseVisualStyleBackColor = true;
            // 
            // dstbXdCalk
            // 
            this.dstbXdCalk.Location = new System.Drawing.Point(818, 539);
            this.dstbXdCalk.Name = "dstbXdCalk";
            this.dstbXdCalk.Size = new System.Drawing.Size(124, 20);
            this.dstbXdCalk.TabIndex = 31;
            // 
            // dstbEpsCalk
            // 
            this.dstbEpsCalk.Location = new System.Drawing.Point(818, 614);
            this.dstbEpsCalk.Name = "dstbEpsCalk";
            this.dstbEpsCalk.Size = new System.Drawing.Size(124, 20);
            this.dstbEpsCalk.TabIndex = 32;
            // 
            // dstbXgCalk
            // 
            this.dstbXgCalk.Location = new System.Drawing.Point(818, 576);
            this.dstbXgCalk.Name = "dstbXgCalk";
            this.dstbXgCalk.Size = new System.Drawing.Size(124, 20);
            this.dstbXgCalk.TabIndex = 33;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(815, 559);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(155, 13);
            this.label16.TabIndex = 34;
            this.label16.Text = "Gorna granica calkowania";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(815, 598);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(125, 13);
            this.label17.TabIndex = 35;
            this.label17.Text = "Dokladnosc obliczen";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dscbMetodaCalk
            // 
            this.dscbMetodaCalk.BackColor = System.Drawing.Color.Black;
            this.dscbMetodaCalk.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.dscbMetodaCalk.FormattingEnabled = true;
            this.dscbMetodaCalk.Items.AddRange(new object[] {
            "Metoda Prostokatowa",
            "Metoda Trapezow"});
            this.dscbMetodaCalk.Location = new System.Drawing.Point(630, 524);
            this.dscbMetodaCalk.Name = "dscbMetodaCalk";
            this.dscbMetodaCalk.Size = new System.Drawing.Size(159, 21);
            this.dscbMetodaCalk.TabIndex = 13;
            this.dscbMetodaCalk.Text = "Wybierz metode calkowania";
            // 
            // dsbtnCalka
            // 
            this.dsbtnCalka.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnCalka.Location = new System.Drawing.Point(637, 559);
            this.dsbtnCalka.Name = "dsbtnCalka";
            this.dsbtnCalka.Size = new System.Drawing.Size(152, 24);
            this.dsbtnCalka.TabIndex = 36;
            this.dsbtnCalka.Text = "Oblicz Calke";
            this.dsbtnCalka.UseVisualStyleBackColor = true;
            this.dsbtnCalka.Click += new System.EventHandler(this.dsbtnCalka_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(669, 598);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(98, 13);
            this.label18.TabIndex = 37;
            this.label18.Text = "Obliczona calka";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dstbObliczonaCalka
            // 
            this.dstbObliczonaCalka.Location = new System.Drawing.Point(653, 614);
            this.dstbObliczonaCalka.Name = "dstbObliczonaCalka";
            this.dstbObliczonaCalka.Size = new System.Drawing.Size(136, 20);
            this.dstbObliczonaCalka.TabIndex = 38;
            // 
            // dsbtnObliczWartosc
            // 
            this.dsbtnObliczWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnObliczWartosc.Location = new System.Drawing.Point(1031, 266);
            this.dsbtnObliczWartosc.Name = "dsbtnObliczWartosc";
            this.dsbtnObliczWartosc.Size = new System.Drawing.Size(152, 62);
            this.dsbtnObliczWartosc.TabIndex = 39;
            this.dsbtnObliczWartosc.Text = "Obliczenie wartosci funkcji F(X)";
            this.dsbtnObliczWartosc.UseVisualStyleBackColor = true;
            this.dsbtnObliczWartosc.Click += new System.EventHandler(this.dsbtnObliczWartosc_Click);
            // 
            // dsbtnTabela
            // 
            this.dsbtnTabela.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnTabela.Location = new System.Drawing.Point(1031, 339);
            this.dsbtnTabela.Name = "dsbtnTabela";
            this.dsbtnTabela.Size = new System.Drawing.Size(152, 60);
            this.dsbtnTabela.TabIndex = 40;
            this.dsbtnTabela.Text = "Tabelaryczna wizualizacja wartosci funkcji F(X)";
            this.dsbtnTabela.UseVisualStyleBackColor = true;
            this.dsbtnTabela.Click += new System.EventHandler(this.dsbtnTabela_Click);
            // 
            // dsbtnGraphic
            // 
            this.dsbtnGraphic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnGraphic.Location = new System.Drawing.Point(1031, 408);
            this.dsbtnGraphic.Name = "dsbtnGraphic";
            this.dsbtnGraphic.Size = new System.Drawing.Size(152, 60);
            this.dsbtnGraphic.TabIndex = 41;
            this.dsbtnGraphic.Text = "Graficzna wizualizacja wartosci funkcji F(X)";
            this.dsbtnGraphic.UseVisualStyleBackColor = true;
            this.dsbtnGraphic.Click += new System.EventHandler(this.dsbtnGraphic_Click);
            // 
            // dsbtnResetuj
            // 
            this.dsbtnResetuj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dsbtnResetuj.Location = new System.Drawing.Point(1031, 474);
            this.dsbtnResetuj.Name = "dsbtnResetuj";
            this.dsbtnResetuj.Size = new System.Drawing.Size(152, 40);
            this.dsbtnResetuj.TabIndex = 42;
            this.dsbtnResetuj.Text = "RESETUJ";
            this.dsbtnResetuj.UseVisualStyleBackColor = true;
            this.dsbtnResetuj.Click += new System.EventHandler(this.dsbtnResetuj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(415, 176);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(437, 306);
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            // 
            // dsdgv
            // 
            this.dsdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dsdgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dslicz,
            this.dsX,
            this.dsfx});
            this.dsdgv.Location = new System.Drawing.Point(456, 184);
            this.dsdgv.Name = "dsdgv";
            this.dsdgv.Size = new System.Drawing.Size(349, 295);
            this.dsdgv.TabIndex = 44;
            this.dsdgv.Visible = false;
            // 
            // dslicz
            // 
            this.dslicz.HeaderText = "Wartosc X";
            this.dslicz.Name = "dslicz";
            // 
            // dsX
            // 
            this.dsX.HeaderText = "Wartosc F(X)";
            this.dsX.Name = "dsX";
            // 
            // dsfx
            // 
            this.dsfx.HeaderText = "Licznik";
            this.dsfx.Name = "dsfx";
            // 
            // dsch
            // 
            chartArea1.Name = "ChartArea1";
            this.dsch.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.dsch.Legends.Add(legend1);
            this.dsch.Location = new System.Drawing.Point(289, 173);
            this.dsch.Name = "dsch";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.dsch.Series.Add(series1);
            this.dsch.Size = new System.Drawing.Size(729, 309);
            this.dsch.TabIndex = 45;
            this.dsch.Text = "chart1";
            this.dsch.Visible = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // dslbWartosc
            // 
            this.dslbWartosc.AutoSize = true;
            this.dslbWartosc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dslbWartosc.Location = new System.Drawing.Point(1024, 184);
            this.dslbWartosc.Name = "dslbWartosc";
            this.dslbWartosc.Size = new System.Drawing.Size(159, 17);
            this.dslbWartosc.TabIndex = 13;
            this.dslbWartosc.Text = "Wartosc Funkcji F(X)";
            this.dslbWartosc.Visible = false;
            // 
            // dstbWynikFunkcji
            // 
            this.dstbWynikFunkcji.Location = new System.Drawing.Point(1031, 214);
            this.dstbWynikFunkcji.Name = "dstbWynikFunkcji";
            this.dstbWynikFunkcji.Size = new System.Drawing.Size(139, 20);
            this.dstbWynikFunkcji.TabIndex = 46;
            this.dstbWynikFunkcji.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1214, 646);
            this.Controls.Add(this.dstbWynikFunkcji);
            this.Controls.Add(this.dslbWartosc);
            this.Controls.Add(this.dsch);
            this.Controls.Add(this.dsdgv);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dsbtnResetuj);
            this.Controls.Add(this.dsbtnGraphic);
            this.Controls.Add(this.dsbtnTabela);
            this.Controls.Add(this.dsbtnObliczWartosc);
            this.Controls.Add(this.dstbObliczonaCalka);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.dsbtnCalka);
            this.Controls.Add(this.dscbMetodaCalk);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dstbXgCalk);
            this.Controls.Add(this.dstbEpsCalk);
            this.Controls.Add(this.dstbXdCalk);
            this.Controls.Add(this.dsgbOs);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dslbEps);
            this.Controls.Add(this.dstbEps);
            this.Controls.Add(this.dstbXd);
            this.Controls.Add(this.dstbXg);
            this.Controls.Add(this.dstbH);
            this.Controls.Add(this.dstbX);
            this.Controls.Add(this.dsgbWykress);
            this.Controls.Add(this.dslbX);
            this.Controls.Add(this.dslabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Analizator Funkcji F(X)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Zamkniecie_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.dsgbWykress.ResumeLayout(false);
            this.dsgbWykress.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dstbGruboscLinii)).EndInit();
            this.dsgbOs.ResumeLayout(false);
            this.dsgbOs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsdgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dsPlikMenu;
        private System.Windows.Forms.ToolStripMenuItem dsZapiszPlikMenu;
        private System.Windows.Forms.ToolStripMenuItem dsOdczytajplikMenu;
        private System.Windows.Forms.ToolStripMenuItem dsExitPlikMenu;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
       private System.Windows.Forms.Label dslabel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label dslbX;
        private System.Windows.Forms.GroupBox dsgbWykress;
        private System.Windows.Forms.ComboBox dscbKolorLinii;
        private System.Windows.Forms.TrackBar dstbGruboscLinii;
        private System.Windows.Forms.ComboBox dscbStylLinii;
        private System.Windows.Forms.ComboBox dscmKolorTla;
        private System.Windows.Forms.TextBox dstbX;
        private System.Windows.Forms.TextBox dstbH;
        private System.Windows.Forms.TextBox dstbXg;
        private System.Windows.Forms.TextBox dstbXd;
        private System.Windows.Forms.TextBox dstbEps;
        private System.Windows.Forms.Label dslbEps;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox dsgbOs;
        private System.Windows.Forms.RadioButton dsrbBezOpisu;
        private System.Windows.Forms.RadioButton dsrbZOpisem;
        private System.Windows.Forms.TextBox dstbXdCalk;
        private System.Windows.Forms.TextBox dstbEpsCalk;
        private System.Windows.Forms.TextBox dstbXgCalk;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox dscbMetodaCalk;
        private System.Windows.Forms.Button dsbtnCalka;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox dstbObliczonaCalka;
        private System.Windows.Forms.Button dsbtnObliczWartosc;
        private System.Windows.Forms.Button dsbtnTabela;
        private System.Windows.Forms.Button dsbtnGraphic;
        private System.Windows.Forms.Button dsbtnResetuj;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dsdgv;
        private System.Windows.Forms.DataVisualization.Charting.Chart dsch;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.TextBox dstbWynikFunkcji;
        private System.Windows.Forms.Label dslbWartosc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dslicz;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsX;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsfx;
    }
}

