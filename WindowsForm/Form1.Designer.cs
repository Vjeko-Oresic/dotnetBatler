namespace WindowsForm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bDodaj1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAdresaDomjenak = new System.Windows.Forms.TextBox();
            this.cbKlijent = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbAdresa2 = new System.Windows.Forms.TextBox();
            this.tbTel2 = new System.Windows.Forms.TextBox();
            this.tbImePrezime2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAdresa1 = new System.Windows.Forms.TextBox();
            this.tbTel1 = new System.Windows.Forms.TextBox();
            this.tbImePrezime1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.nudVrijeme2 = new System.Windows.Forms.NumericUpDown();
            this.nudVrijeme1 = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.tbKapara = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbCijena = new System.Windows.Forms.TextBox();
            this.bDodaj2 = new System.Windows.Forms.Button();
            this.nudKonobari = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.nudBrojLjudi = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cbVrijeme = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.nudKolicina1 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.comboInvertar = new System.Windows.Forms.ComboBox();
            this.comboKlijent = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bDodaj3 = new System.Windows.Forms.Button();
            this.nudCijena = new System.Windows.Forms.NumericUpDown();
            this.nudKolicina2 = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.bOk = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVrijeme2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVrijeme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKonobari)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojLjudi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 513);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bDodaj1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbAdresaDomjenak);
            this.tabPage1.Controls.Add(this.cbKlijent);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(368, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klijent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bDodaj1
            // 
            this.bDodaj1.Location = new System.Drawing.Point(265, 441);
            this.bDodaj1.Name = "bDodaj1";
            this.bDodaj1.Size = new System.Drawing.Size(75, 23);
            this.bDodaj1.TabIndex = 10;
            this.bDodaj1.Text = "&Dodaj";
            this.bDodaj1.UseVisualStyleBackColor = true;
            this.bDodaj1.Click += new System.EventHandler(this.bDodaj1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 388);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Adresa domjenka";
            // 
            // tbAdresaDomjenak
            // 
            this.tbAdresaDomjenak.Location = new System.Drawing.Point(138, 385);
            this.tbAdresaDomjenak.Name = "tbAdresaDomjenak";
            this.tbAdresaDomjenak.Size = new System.Drawing.Size(176, 20);
            this.tbAdresaDomjenak.TabIndex = 8;
            // 
            // cbKlijent
            // 
            this.cbKlijent.AutoSize = true;
            this.cbKlijent.Location = new System.Drawing.Point(103, 185);
            this.cbKlijent.Name = "cbKlijent";
            this.cbKlijent.Size = new System.Drawing.Size(138, 17);
            this.cbKlijent.TabIndex = 2;
            this.cbKlijent.Text = "Dodaj dodatnog klijenta";
            this.cbKlijent.UseVisualStyleBackColor = true;
            this.cbKlijent.CheckStateChanged += new System.EventHandler(this.cbKlijent_CheckStateChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbAdresa2);
            this.groupBox2.Controls.Add(this.tbTel2);
            this.groupBox2.Controls.Add(this.tbImePrezime2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(21, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 139);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Klijent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresa";
            // 
            // tbAdresa2
            // 
            this.tbAdresa2.Location = new System.Drawing.Point(117, 89);
            this.tbAdresa2.Name = "tbAdresa2";
            this.tbAdresa2.Size = new System.Drawing.Size(176, 20);
            this.tbAdresa2.TabIndex = 4;
            // 
            // tbTel2
            // 
            this.tbTel2.Location = new System.Drawing.Point(117, 63);
            this.tbTel2.Name = "tbTel2";
            this.tbTel2.Size = new System.Drawing.Size(176, 20);
            this.tbTel2.TabIndex = 3;
            // 
            // tbImePrezime2
            // 
            this.tbImePrezime2.Location = new System.Drawing.Point(117, 37);
            this.tbImePrezime2.Name = "tbImePrezime2";
            this.tbImePrezime2.Size = new System.Drawing.Size(176, 20);
            this.tbImePrezime2.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Broj telefona";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ime i prezime";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbAdresa1);
            this.groupBox1.Controls.Add(this.tbTel1);
            this.groupBox1.Controls.Add(this.tbImePrezime1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(319, 139);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klijent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Adresa";
            // 
            // tbAdresa1
            // 
            this.tbAdresa1.Location = new System.Drawing.Point(117, 89);
            this.tbAdresa1.Name = "tbAdresa1";
            this.tbAdresa1.Size = new System.Drawing.Size(176, 20);
            this.tbAdresa1.TabIndex = 4;
            // 
            // tbTel1
            // 
            this.tbTel1.Location = new System.Drawing.Point(117, 63);
            this.tbTel1.Name = "tbTel1";
            this.tbTel1.Size = new System.Drawing.Size(176, 20);
            this.tbTel1.TabIndex = 3;
            // 
            // tbImePrezime1
            // 
            this.tbImePrezime1.Location = new System.Drawing.Point(117, 37);
            this.tbImePrezime1.Name = "tbImePrezime1";
            this.tbImePrezime1.Size = new System.Drawing.Size(176, 20);
            this.tbImePrezime1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Broj telefona";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ime i prezime";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.nudVrijeme2);
            this.tabPage3.Controls.Add(this.nudVrijeme1);
            this.tabPage3.Controls.Add(this.label20);
            this.tabPage3.Controls.Add(this.tbKapara);
            this.tabPage3.Controls.Add(this.label19);
            this.tabPage3.Controls.Add(this.tbCijena);
            this.tabPage3.Controls.Add(this.bDodaj2);
            this.tabPage3.Controls.Add(this.nudKonobari);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.nudBrojLjudi);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.cbVrijeme);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.datePicker);
            this.tabPage3.Controls.Add(this.nudKolicina1);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.comboInvertar);
            this.tabPage3.Controls.Add(this.comboKlijent);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(368, 487);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Domjenak";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // nudVrijeme2
            // 
            this.nudVrijeme2.DecimalPlaces = 2;
            this.nudVrijeme2.Enabled = false;
            this.nudVrijeme2.Location = new System.Drawing.Point(126, 204);
            this.nudVrijeme2.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudVrijeme2.Name = "nudVrijeme2";
            this.nudVrijeme2.Size = new System.Drawing.Size(207, 20);
            this.nudVrijeme2.TabIndex = 34;
            // 
            // nudVrijeme1
            // 
            this.nudVrijeme1.DecimalPlaces = 2;
            this.nudVrijeme1.Location = new System.Drawing.Point(126, 139);
            this.nudVrijeme1.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudVrijeme1.Name = "nudVrijeme1";
            this.nudVrijeme1.Size = new System.Drawing.Size(207, 20);
            this.nudVrijeme1.TabIndex = 33;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(40, 383);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 13);
            this.label20.TabIndex = 32;
            this.label20.Text = "Kapara";
            // 
            // tbKapara
            // 
            this.tbKapara.Location = new System.Drawing.Point(126, 380);
            this.tbKapara.Name = "tbKapara";
            this.tbKapara.ReadOnly = true;
            this.tbKapara.Size = new System.Drawing.Size(207, 20);
            this.tbKapara.TabIndex = 31;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(40, 357);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(36, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Cijena";
            // 
            // tbCijena
            // 
            this.tbCijena.Location = new System.Drawing.Point(126, 354);
            this.tbCijena.Name = "tbCijena";
            this.tbCijena.ReadOnly = true;
            this.tbCijena.Size = new System.Drawing.Size(207, 20);
            this.tbCijena.TabIndex = 29;
            // 
            // bDodaj2
            // 
            this.bDodaj2.Location = new System.Drawing.Point(265, 448);
            this.bDodaj2.Name = "bDodaj2";
            this.bDodaj2.Size = new System.Drawing.Size(75, 23);
            this.bDodaj2.TabIndex = 28;
            this.bDodaj2.Text = "&Dodaj";
            this.bDodaj2.UseVisualStyleBackColor = true;
            this.bDodaj2.Click += new System.EventHandler(this.bDodaj2_Click);
            // 
            // nudKonobari
            // 
            this.nudKonobari.Location = new System.Drawing.Point(126, 278);
            this.nudKonobari.Name = "nudKonobari";
            this.nudKonobari.Size = new System.Drawing.Size(207, 20);
            this.nudKonobari.TabIndex = 27;
            this.nudKonobari.ValueChanged += new System.EventHandler(this.nudKonobari_ValueChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(40, 280);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 13);
            this.label18.TabIndex = 26;
            this.label18.Text = "Broj konobara";
            // 
            // nudBrojLjudi
            // 
            this.nudBrojLjudi.Location = new System.Drawing.Point(126, 252);
            this.nudBrojLjudi.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudBrojLjudi.Name = "nudBrojLjudi";
            this.nudBrojLjudi.Size = new System.Drawing.Size(207, 20);
            this.nudBrojLjudi.TabIndex = 25;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 254);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(46, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Broj ljudi";
            // 
            // cbVrijeme
            // 
            this.cbVrijeme.AutoSize = true;
            this.cbVrijeme.Location = new System.Drawing.Point(101, 175);
            this.cbVrijeme.Name = "cbVrijeme";
            this.cbVrijeme.Size = new System.Drawing.Size(174, 17);
            this.cbVrijeme.TabIndex = 23;
            this.cbVrijeme.Text = "Dodaj vrijeme dodatnog klijenta";
            this.cbVrijeme.UseVisualStyleBackColor = true;
            this.cbVrijeme.CheckStateChanged += new System.EventHandler(this.cbVrijeme_CheckStateChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(40, 204);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 13);
            this.label16.TabIndex = 22;
            this.label16.Text = "Vrijeme";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(40, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 20;
            this.label15.Text = "Vrijeme";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Datum";
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(126, 113);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(207, 20);
            this.datePicker.TabIndex = 17;
            // 
            // nudKolicina1
            // 
            this.nudKolicina1.Location = new System.Drawing.Point(126, 87);
            this.nudKolicina1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKolicina1.Name = "nudKolicina1";
            this.nudKolicina1.Size = new System.Drawing.Size(207, 20);
            this.nudKolicina1.TabIndex = 16;
            this.nudKolicina1.ValueChanged += new System.EventHandler(this.nudKolicina1_ValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 89);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 15;
            this.label13.Text = "Količina";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Invertar";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Klijent";
            // 
            // comboInvertar
            // 
            this.comboInvertar.FormattingEnabled = true;
            this.comboInvertar.Location = new System.Drawing.Point(126, 60);
            this.comboInvertar.Name = "comboInvertar";
            this.comboInvertar.Size = new System.Drawing.Size(207, 21);
            this.comboInvertar.TabIndex = 1;
            // 
            // comboKlijent
            // 
            this.comboKlijent.FormattingEnabled = true;
            this.comboKlijent.Location = new System.Drawing.Point(126, 33);
            this.comboKlijent.Name = "comboKlijent";
            this.comboKlijent.Size = new System.Drawing.Size(207, 21);
            this.comboKlijent.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bDodaj3);
            this.tabPage2.Controls.Add(this.nudCijena);
            this.tabPage2.Controls.Add(this.nudKolicina2);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbNaziv);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(368, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invertar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bDodaj3
            // 
            this.bDodaj3.Location = new System.Drawing.Point(265, 148);
            this.bDodaj3.Name = "bDodaj3";
            this.bDodaj3.Size = new System.Drawing.Size(75, 23);
            this.bDodaj3.TabIndex = 16;
            this.bDodaj3.Text = "&Dodaj";
            this.bDodaj3.UseVisualStyleBackColor = true;
            this.bDodaj3.Click += new System.EventHandler(this.bDodaj3_Click);
            // 
            // nudCijena
            // 
            this.nudCijena.DecimalPlaces = 2;
            this.nudCijena.Location = new System.Drawing.Point(131, 84);
            this.nudCijena.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCijena.Name = "nudCijena";
            this.nudCijena.Size = new System.Drawing.Size(176, 20);
            this.nudCijena.TabIndex = 15;
            // 
            // nudKolicina2
            // 
            this.nudKolicina2.Location = new System.Drawing.Point(131, 56);
            this.nudKolicina2.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudKolicina2.Name = "nudKolicina2";
            this.nudKolicina2.Size = new System.Drawing.Size(176, 20);
            this.nudKolicina2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(34, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Cijena";
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(131, 29);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(176, 20);
            this.tbNaziv.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(34, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Količina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Naziv";
            // 
            // bOk
            // 
            this.bOk.Location = new System.Drawing.Point(278, 528);
            this.bOk.Name = "bOk";
            this.bOk.Size = new System.Drawing.Size(75, 23);
            this.bOk.TabIndex = 1;
            this.bOk.Text = "&OK";
            this.bOk.UseVisualStyleBackColor = true;
            this.bOk.Click += new System.EventHandler(this.bOk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 563);
            this.Controls.Add(this.bOk);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dodaj novo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudVrijeme2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudVrijeme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKonobari)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBrojLjudi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCijena)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKolicina2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bDodaj1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAdresaDomjenak;
        private System.Windows.Forms.CheckBox cbKlijent;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbAdresa2;
        private System.Windows.Forms.TextBox tbTel2;
        private System.Windows.Forms.TextBox tbImePrezime2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAdresa1;
        private System.Windows.Forms.TextBox tbTel1;
        private System.Windows.Forms.TextBox tbImePrezime1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bOk;
        private System.Windows.Forms.Button bDodaj3;
        private System.Windows.Forms.NumericUpDown nudCijena;
        private System.Windows.Forms.NumericUpDown nudKolicina2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.NumericUpDown nudKolicina1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboInvertar;
        private System.Windows.Forms.ComboBox comboKlijent;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.CheckBox cbVrijeme;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button bDodaj2;
        private System.Windows.Forms.NumericUpDown nudKonobari;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown nudBrojLjudi;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbKapara;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbCijena;
        private System.Windows.Forms.NumericUpDown nudVrijeme2;
        private System.Windows.Forms.NumericUpDown nudVrijeme1;
    }
}

