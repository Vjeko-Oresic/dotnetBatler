using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form2 : Form
    {
        private BatlerEntities db;

        public Form2()
        {
            InitializeComponent();
            db = new BatlerEntities();
        }

        private void dodajNovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.ShowDialog(this);
        }

        private void izlazToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void oAplikacijiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.dgKlijent.DataSource = db.Klijent.ToList();
            this.dgKlijent.AutoResizeColumns();
            this.dgKlijent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
      
            this.dgDomjenak.DataSource = db.Domjenak.ToList();
            this.dgDomjenak.AutoResizeColumns();
            this.dgDomjenak.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            this.dgInvertar.DataSource = db.Invertar.ToList();
            this.dgInvertar.AutoResizeColumns();
            this.dgInvertar.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Form2_Activated(object sender, EventArgs e)
        {
            Form2_Load(sender,e);
        }
    }
}
