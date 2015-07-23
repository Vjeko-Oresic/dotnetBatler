namespace WindowsForm
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgKlijent = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgDomjenak = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgInvertar = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajNovoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oAplikacijiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izlazToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklijentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezime1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imePrezime2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTel1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojTel2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresa2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresadomjenakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domjenakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domjenakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idinvertarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nazivDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domjenakDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invertarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iddomjenakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idklijentDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.klijent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idinvertarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invertar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicinaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijeme1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vrijeme2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojLjudiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojKonobaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ukupnaCijenaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kaparaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijent)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDomjenak)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgInvertar)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domjenakBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invertarBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(9, 24);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 628);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgKlijent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(958, 602);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Klijent";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgKlijent
            // 
            this.dgKlijent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgKlijent.AutoGenerateColumns = false;
            this.dgKlijent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKlijent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idklijentDataGridViewTextBoxColumn,
            this.imePrezime1DataGridViewTextBoxColumn,
            this.imePrezime2DataGridViewTextBoxColumn,
            this.brojTel1DataGridViewTextBoxColumn,
            this.brojTel2DataGridViewTextBoxColumn,
            this.adresa1DataGridViewTextBoxColumn,
            this.adresa2DataGridViewTextBoxColumn,
            this.adresadomjenakDataGridViewTextBoxColumn,
            this.domjenakDataGridViewTextBoxColumn});
            this.dgKlijent.DataSource = this.klijentBindingSource;
            this.dgKlijent.Location = new System.Drawing.Point(0, 0);
            this.dgKlijent.Name = "dgKlijent";
            this.dgKlijent.ReadOnly = true;
            this.dgKlijent.Size = new System.Drawing.Size(958, 603);
            this.dgKlijent.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgDomjenak);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(958, 602);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Domjenak";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgDomjenak
            // 
            this.dgDomjenak.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgDomjenak.AutoGenerateColumns = false;
            this.dgDomjenak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDomjenak.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iddomjenakDataGridViewTextBoxColumn,
            this.idklijentDataGridViewTextBoxColumn1,
            this.klijent,
            this.idinvertarDataGridViewTextBoxColumn,
            this.invertar,
            this.kolicinaDataGridViewTextBoxColumn,
            this.datumDataGridViewTextBoxColumn,
            this.vrijeme1DataGridViewTextBoxColumn,
            this.vrijeme2DataGridViewTextBoxColumn,
            this.brojLjudiDataGridViewTextBoxColumn,
            this.brojKonobaraDataGridViewTextBoxColumn,
            this.ukupnaCijenaDataGridViewTextBoxColumn,
            this.kaparaDataGridViewTextBoxColumn});
            this.dgDomjenak.DataSource = this.domjenakBindingSource;
            this.dgDomjenak.Location = new System.Drawing.Point(0, 0);
            this.dgDomjenak.Name = "dgDomjenak";
            this.dgDomjenak.ReadOnly = true;
            this.dgDomjenak.Size = new System.Drawing.Size(958, 603);
            this.dgDomjenak.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgInvertar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 602);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Invertar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgInvertar
            // 
            this.dgInvertar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgInvertar.AutoGenerateColumns = false;
            this.dgInvertar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgInvertar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idinvertarDataGridViewTextBoxColumn1,
            this.nazivDataGridViewTextBoxColumn,
            this.kolicinaDataGridViewTextBoxColumn1,
            this.cijenaDataGridViewTextBoxColumn,
            this.domjenakDataGridViewTextBoxColumn1});
            this.dgInvertar.DataSource = this.invertarBindingSource;
            this.dgInvertar.Location = new System.Drawing.Point(0, 0);
            this.dgInvertar.Name = "dgInvertar";
            this.dgInvertar.ReadOnly = true;
            this.dgInvertar.Size = new System.Drawing.Size(958, 603);
            this.dgInvertar.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(984, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dodajNovoToolStripMenuItem,
            this.oAplikacijiToolStripMenuItem,
            this.izlazToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // dodajNovoToolStripMenuItem
            // 
            this.dodajNovoToolStripMenuItem.Name = "dodajNovoToolStripMenuItem";
            this.dodajNovoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.dodajNovoToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.dodajNovoToolStripMenuItem.Text = "Dodaj &novo";
            this.dodajNovoToolStripMenuItem.Click += new System.EventHandler(this.dodajNovoToolStripMenuItem_Click);
            // 
            // oAplikacijiToolStripMenuItem
            // 
            this.oAplikacijiToolStripMenuItem.Name = "oAplikacijiToolStripMenuItem";
            this.oAplikacijiToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.oAplikacijiToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.oAplikacijiToolStripMenuItem.Text = "&O aplikaciji";
            this.oAplikacijiToolStripMenuItem.Click += new System.EventHandler(this.oAplikacijiToolStripMenuItem_Click);
            // 
            // izlazToolStripMenuItem
            // 
            this.izlazToolStripMenuItem.Name = "izlazToolStripMenuItem";
            this.izlazToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.izlazToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.izlazToolStripMenuItem.Text = "&Izlaz";
            this.izlazToolStripMenuItem.Click += new System.EventHandler(this.izlazToolStripMenuItem_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Klijent";
            this.dataGridViewTextBoxColumn1.HeaderText = "Klijent";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Klijent";
            this.dataGridViewTextBoxColumn2.HeaderText = "Klijent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // idklijentDataGridViewTextBoxColumn
            // 
            this.idklijentDataGridViewTextBoxColumn.DataPropertyName = "id_klijent";
            this.idklijentDataGridViewTextBoxColumn.HeaderText = "id_klijent";
            this.idklijentDataGridViewTextBoxColumn.Name = "idklijentDataGridViewTextBoxColumn";
            this.idklijentDataGridViewTextBoxColumn.ReadOnly = true;
            this.idklijentDataGridViewTextBoxColumn.Visible = false;
            // 
            // imePrezime1DataGridViewTextBoxColumn
            // 
            this.imePrezime1DataGridViewTextBoxColumn.DataPropertyName = "imePrezime1";
            this.imePrezime1DataGridViewTextBoxColumn.HeaderText = "Ime i prezime 1. klijent";
            this.imePrezime1DataGridViewTextBoxColumn.Name = "imePrezime1DataGridViewTextBoxColumn";
            this.imePrezime1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // imePrezime2DataGridViewTextBoxColumn
            // 
            this.imePrezime2DataGridViewTextBoxColumn.DataPropertyName = "imePrezime2";
            this.imePrezime2DataGridViewTextBoxColumn.HeaderText = "Ime i prezime 2. klijent";
            this.imePrezime2DataGridViewTextBoxColumn.Name = "imePrezime2DataGridViewTextBoxColumn";
            this.imePrezime2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojTel1DataGridViewTextBoxColumn
            // 
            this.brojTel1DataGridViewTextBoxColumn.DataPropertyName = "brojTel1";
            this.brojTel1DataGridViewTextBoxColumn.HeaderText = "Broj telefona 1. klijent";
            this.brojTel1DataGridViewTextBoxColumn.Name = "brojTel1DataGridViewTextBoxColumn";
            this.brojTel1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojTel2DataGridViewTextBoxColumn
            // 
            this.brojTel2DataGridViewTextBoxColumn.DataPropertyName = "brojTel2";
            this.brojTel2DataGridViewTextBoxColumn.HeaderText = "Broj telefona 2. klijent";
            this.brojTel2DataGridViewTextBoxColumn.Name = "brojTel2DataGridViewTextBoxColumn";
            this.brojTel2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresa1DataGridViewTextBoxColumn
            // 
            this.adresa1DataGridViewTextBoxColumn.DataPropertyName = "adresa1";
            this.adresa1DataGridViewTextBoxColumn.HeaderText = "Adresa 1. klijent";
            this.adresa1DataGridViewTextBoxColumn.Name = "adresa1DataGridViewTextBoxColumn";
            this.adresa1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresa2DataGridViewTextBoxColumn
            // 
            this.adresa2DataGridViewTextBoxColumn.DataPropertyName = "adresa2";
            this.adresa2DataGridViewTextBoxColumn.HeaderText = "Adresa 2. klijent";
            this.adresa2DataGridViewTextBoxColumn.Name = "adresa2DataGridViewTextBoxColumn";
            this.adresa2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adresadomjenakDataGridViewTextBoxColumn
            // 
            this.adresadomjenakDataGridViewTextBoxColumn.DataPropertyName = "adresa_domjenak";
            this.adresadomjenakDataGridViewTextBoxColumn.HeaderText = "Adresa domjenka";
            this.adresadomjenakDataGridViewTextBoxColumn.Name = "adresadomjenakDataGridViewTextBoxColumn";
            this.adresadomjenakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domjenakDataGridViewTextBoxColumn
            // 
            this.domjenakDataGridViewTextBoxColumn.DataPropertyName = "Domjenak";
            this.domjenakDataGridViewTextBoxColumn.HeaderText = "Domjenak";
            this.domjenakDataGridViewTextBoxColumn.Name = "domjenakDataGridViewTextBoxColumn";
            this.domjenakDataGridViewTextBoxColumn.ReadOnly = true;
            this.domjenakDataGridViewTextBoxColumn.Visible = false;
            // 
            // klijentBindingSource
            // 
            this.klijentBindingSource.DataSource = typeof(WindowsForm.Klijent);
            // 
            // domjenakBindingSource
            // 
            this.domjenakBindingSource.DataSource = typeof(WindowsForm.Domjenak);
            // 
            // idinvertarDataGridViewTextBoxColumn1
            // 
            this.idinvertarDataGridViewTextBoxColumn1.DataPropertyName = "id_invertar";
            this.idinvertarDataGridViewTextBoxColumn1.HeaderText = "id_invertar";
            this.idinvertarDataGridViewTextBoxColumn1.Name = "idinvertarDataGridViewTextBoxColumn1";
            this.idinvertarDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idinvertarDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            this.nazivDataGridViewTextBoxColumn.DataPropertyName = "naziv";
            this.nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            this.nazivDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn1
            // 
            this.kolicinaDataGridViewTextBoxColumn1.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn1.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn1.Name = "kolicinaDataGridViewTextBoxColumn1";
            this.kolicinaDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // cijenaDataGridViewTextBoxColumn
            // 
            this.cijenaDataGridViewTextBoxColumn.DataPropertyName = "cijena";
            this.cijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.cijenaDataGridViewTextBoxColumn.Name = "cijenaDataGridViewTextBoxColumn";
            this.cijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // domjenakDataGridViewTextBoxColumn1
            // 
            this.domjenakDataGridViewTextBoxColumn1.DataPropertyName = "Domjenak";
            this.domjenakDataGridViewTextBoxColumn1.HeaderText = "Domjenak";
            this.domjenakDataGridViewTextBoxColumn1.Name = "domjenakDataGridViewTextBoxColumn1";
            this.domjenakDataGridViewTextBoxColumn1.ReadOnly = true;
            this.domjenakDataGridViewTextBoxColumn1.Visible = false;
            // 
            // invertarBindingSource
            // 
            this.invertarBindingSource.DataSource = typeof(WindowsForm.Invertar);
            // 
            // iddomjenakDataGridViewTextBoxColumn
            // 
            this.iddomjenakDataGridViewTextBoxColumn.DataPropertyName = "id_domjenak";
            this.iddomjenakDataGridViewTextBoxColumn.HeaderText = "id_domjenak";
            this.iddomjenakDataGridViewTextBoxColumn.Name = "iddomjenakDataGridViewTextBoxColumn";
            this.iddomjenakDataGridViewTextBoxColumn.ReadOnly = true;
            this.iddomjenakDataGridViewTextBoxColumn.Visible = false;
            // 
            // idklijentDataGridViewTextBoxColumn1
            // 
            this.idklijentDataGridViewTextBoxColumn1.DataPropertyName = "id_klijent";
            this.idklijentDataGridViewTextBoxColumn1.HeaderText = "id_klijent";
            this.idklijentDataGridViewTextBoxColumn1.Name = "idklijentDataGridViewTextBoxColumn1";
            this.idklijentDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idklijentDataGridViewTextBoxColumn1.Visible = false;
            // 
            // klijent
            // 
            this.klijent.DataPropertyName = "klijent";
            this.klijent.HeaderText = "Klijent";
            this.klijent.Name = "klijent";
            this.klijent.ReadOnly = true;
            // 
            // idinvertarDataGridViewTextBoxColumn
            // 
            this.idinvertarDataGridViewTextBoxColumn.DataPropertyName = "id_invertar";
            this.idinvertarDataGridViewTextBoxColumn.HeaderText = "id_invertar";
            this.idinvertarDataGridViewTextBoxColumn.Name = "idinvertarDataGridViewTextBoxColumn";
            this.idinvertarDataGridViewTextBoxColumn.ReadOnly = true;
            this.idinvertarDataGridViewTextBoxColumn.Visible = false;
            // 
            // invertar
            // 
            this.invertar.DataPropertyName = "invertar";
            this.invertar.HeaderText = "Invertar";
            this.invertar.Name = "invertar";
            this.invertar.ReadOnly = true;
            // 
            // kolicinaDataGridViewTextBoxColumn
            // 
            this.kolicinaDataGridViewTextBoxColumn.DataPropertyName = "kolicina";
            this.kolicinaDataGridViewTextBoxColumn.HeaderText = "Količina";
            this.kolicinaDataGridViewTextBoxColumn.Name = "kolicinaDataGridViewTextBoxColumn";
            this.kolicinaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datumDataGridViewTextBoxColumn
            // 
            this.datumDataGridViewTextBoxColumn.DataPropertyName = "datum";
            this.datumDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.datumDataGridViewTextBoxColumn.Name = "datumDataGridViewTextBoxColumn";
            this.datumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijeme1DataGridViewTextBoxColumn
            // 
            this.vrijeme1DataGridViewTextBoxColumn.DataPropertyName = "vrijeme1";
            this.vrijeme1DataGridViewTextBoxColumn.HeaderText = "Vrijeme 1. klijent";
            this.vrijeme1DataGridViewTextBoxColumn.Name = "vrijeme1DataGridViewTextBoxColumn";
            this.vrijeme1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vrijeme2DataGridViewTextBoxColumn
            // 
            this.vrijeme2DataGridViewTextBoxColumn.DataPropertyName = "vrijeme2";
            this.vrijeme2DataGridViewTextBoxColumn.HeaderText = "Vrijeme 2. klijent";
            this.vrijeme2DataGridViewTextBoxColumn.Name = "vrijeme2DataGridViewTextBoxColumn";
            this.vrijeme2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojLjudiDataGridViewTextBoxColumn
            // 
            this.brojLjudiDataGridViewTextBoxColumn.DataPropertyName = "brojLjudi";
            this.brojLjudiDataGridViewTextBoxColumn.HeaderText = "Broj ljudi";
            this.brojLjudiDataGridViewTextBoxColumn.Name = "brojLjudiDataGridViewTextBoxColumn";
            this.brojLjudiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // brojKonobaraDataGridViewTextBoxColumn
            // 
            this.brojKonobaraDataGridViewTextBoxColumn.DataPropertyName = "brojKonobara";
            this.brojKonobaraDataGridViewTextBoxColumn.HeaderText = "Broj konobara";
            this.brojKonobaraDataGridViewTextBoxColumn.Name = "brojKonobaraDataGridViewTextBoxColumn";
            this.brojKonobaraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ukupnaCijenaDataGridViewTextBoxColumn
            // 
            this.ukupnaCijenaDataGridViewTextBoxColumn.DataPropertyName = "ukupnaCijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.HeaderText = "Cijena";
            this.ukupnaCijenaDataGridViewTextBoxColumn.Name = "ukupnaCijenaDataGridViewTextBoxColumn";
            this.ukupnaCijenaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kaparaDataGridViewTextBoxColumn
            // 
            this.kaparaDataGridViewTextBoxColumn.DataPropertyName = "kapara";
            this.kaparaDataGridViewTextBoxColumn.HeaderText = "Kapara";
            this.kaparaDataGridViewTextBoxColumn.Name = "kaparaDataGridViewTextBoxColumn";
            this.kaparaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batler";
            this.Activated += new System.EventHandler(this.Form2_Activated);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgKlijent)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgDomjenak)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgInvertar)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.klijentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domjenakBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invertarBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajNovoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oAplikacijiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izlazToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgKlijent;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgDomjenak;
        private System.Windows.Forms.DataGridView dgInvertar;
        private System.Windows.Forms.BindingSource klijentBindingSource;
        private System.Windows.Forms.BindingSource invertarBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklijentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn imePrezime2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTel1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojTel2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresa2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresadomjenakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domjenakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvertarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn domjenakDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource domjenakBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iddomjenakDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idklijentDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn klijent;
        private System.Windows.Forms.DataGridViewTextBoxColumn idinvertarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicinaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijeme1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vrijeme2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojLjudiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojKonobaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ukupnaCijenaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kaparaDataGridViewTextBoxColumn;
    }
}