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
    public partial class Form1 : Form
    {
        private BatlerEntities db;

        public Form1()
        {
            InitializeComponent();
            db = new BatlerEntities();
            tbCijena.Text = "0";
            tbKapara.Text = "0";
        }

        private void bOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbKlijent_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbKlijent.Checked == true)
                groupBox2.Enabled = true;
            else
                groupBox2.Enabled = false;
        }

        private void cbVrijeme_CheckStateChanged(object sender, EventArgs e)
        {
            if (cbVrijeme.Checked == true)
                nudVrijeme2.Enabled = true;
            else
                nudVrijeme2.Enabled = false;
        }

        private void bDodaj1_Click(object sender, EventArgs e)
        {
            var context = new BatlerEntities();

            try
            {
                if (cbKlijent.Checked == true)
                {
                    var klijent = new Klijent
                    {
                        imePrezime1 = tbImePrezime1.Text,
                        brojTel1 = Convert.ToInt32(tbTel1.Text),
                        adresa1 = tbAdresa1.Text,
                        imePrezime2 = tbImePrezime2.Text,
                        brojTel2 = Convert.ToInt32(tbTel2.Text),
                        adresa2 = tbAdresa2.Text,
                        adresa_domjenak = tbAdresaDomjenak.Text
                    };
                    context.Klijent.Add(klijent);
                    context.SaveChanges();
                    MessageBox.Show("Dodan novi klijent!");
                }
                else
                {
                    var klijent = new Klijent
                    {
                        imePrezime1 = tbImePrezime1.Text,
                        brojTel1 = Convert.ToInt32(tbTel1.Text),
                        adresa1 = tbAdresa1.Text,
                        imePrezime2 = null,
                        brojTel2 = null,
                        adresa2 = null,
                        adresa_domjenak = tbAdresaDomjenak.Text
                    };
                    context.Klijent.Add(klijent);
                    context.SaveChanges();
                    MessageBox.Show("Dodan novi klijent!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dodavanje klijenta nije uspijelo!!!");
            }
        }

        private void bDodaj2_Click(object sender, EventArgs e)
        {
            var context = new BatlerEntities();
            string ime = comboKlijent.SelectedItem.ToString();
            string naziv = comboInvertar.SelectedItem.ToString();

            int idKlijent = (from k in db.Klijent where k.imePrezime1 == ime select k.id_klijent).First();
            int idInvertar = (from i in db.Invertar where i.naziv == naziv select i.id_invertar).First();
 
            try
            {
                if (cbVrijeme.Checked == true) { 
                    var domjenak = new Domjenak
                    {
                        id_klijent = idKlijent,
                        id_invertar = idInvertar,
                        kolicina = Convert.ToInt32(nudKolicina1.Value),
                        datum = datePicker.Value,
                        vrijeme1 = nudVrijeme1.Value,
                        vrijeme2 = nudVrijeme2.Value,
                        brojLjudi = Convert.ToInt32(nudBrojLjudi.Value),
                        brojKonobara = Convert.ToInt32(nudKonobari.Value),
                        ukupnaCijena = Convert.ToDecimal(tbCijena.Text),
                        kapara = Convert.ToDecimal(tbKapara.Text),
                        klijent = ime,
                        invertar = naziv
                    };
                    context.Domjenak.Add(domjenak);
                    context.SaveChanges();
                    MessageBox.Show("Dodan novi domjenak!");
                }
                else
                {
                    var domjenak = new Domjenak
                    {
                        id_klijent = idKlijent,
                        id_invertar = idInvertar,
                        kolicina = Convert.ToInt32(nudKolicina1.Value),
                        datum = datePicker.Value,
                        vrijeme1 = nudVrijeme1.Value,
                        vrijeme2 = null,
                        brojLjudi = Convert.ToInt32(nudBrojLjudi.Value),
                        brojKonobara = Convert.ToInt32(nudKonobari.Value),
                        ukupnaCijena = Convert.ToDecimal(tbCijena.Text),
                        kapara = Convert.ToDecimal(tbKapara.Text),
                        klijent = ime,
                        invertar = naziv
                    };
                    context.Domjenak.Add(domjenak);
                    context.SaveChanges();
                    MessageBox.Show("Dodan novi domjenak!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dodavanje domjenka nije uspijelo!!!");
            }
        }

        private void bDodaj3_Click(object sender, EventArgs e)
        {
            var context = new BatlerEntities();

            try
            {
                var invertar = new Invertar
                {
                    naziv = tbNaziv.Text,
                    kolicina = Convert.ToInt32(nudKolicina2.Value),
                    cijena = nudCijena.Value
                };
                context.Invertar.Add(invertar);
                context.SaveChanges();
                MessageBox.Show("Dodan novi invertar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dodavanje invertara nije uspijelo!!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboKlijent.DropDownStyle = ComboBoxStyle.DropDownList;
            var klijent = from k in db.Klijent select k.imePrezime1;
            List<string> listKlijent = new List<string>(klijent.Distinct());
            this.comboKlijent.DataSource = listKlijent.ToList();

            this.comboInvertar.DropDownStyle = ComboBoxStyle.DropDownList;
            var invertar = from i in db.Invertar select i.naziv;
            List<string> listInvertar = new List<string>(invertar.Distinct());
            this.comboInvertar.DataSource = listInvertar.ToList();
        }

        private void nudKolicina1_ValueChanged(object sender, EventArgs e)
        {
            decimal uCijena;
            decimal kapara;

            string naziv = comboInvertar.SelectedItem.ToString();
            decimal cijena = (from i in db.Invertar where i.naziv == naziv select (decimal)i.cijena).Single();

            uCijena = cijena * nudKolicina1.Value;
            kapara = uCijena * 0.3m;

            tbCijena.Text = uCijena.ToString();
            tbKapara.Text = kapara.ToString();
        }

        private void nudKonobari_ValueChanged(object sender, EventArgs e)
        {
            decimal uCijena = Convert.ToDecimal(tbCijena.Text);
            decimal kapara = Convert.ToDecimal(tbKapara.Text);

            uCijena = uCijena + nudKonobari.Value*500;
            kapara = uCijena * 0.3m;

            tbCijena.Text = uCijena.ToString();
            tbKapara.Text = kapara.ToString();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            Form1_Load(sender,e);
        }
    }
}
