using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upisivanjapodataka_u_csv
{
    public partial class Form1 : Form
    {
        List<osoba> listaosoba = new List<osoba>();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            txtEmail.Clear();
            txtGod.Clear();
            txtIme.Clear();
            txtPrezime.Clear();
        }

        private void btnUpis_Click(object sender, EventArgs e)
        {
            //osoba Osoba = new osoba();
            try
            {
                
                osoba Osoba = new osoba(txtIme.Text,
                    txtPrezime.Text, txtEmail.Text,
                    Convert.ToInt16(txtGod.Text));
                /*
                Osoba.Ime = txtIme.Text;
                Osoba.Prezime = txtPrezime.Text;
                Osoba.Email = txtEmail.Text;
                Osoba.GodinaRodjenja = Convert.ToInt16(txtGod.Text);
                */
                txtEmail.Clear();
                txtGod.Clear();
                txtIme.Clear();
                txtPrezime.Clear();
                txtIme.Focus();
                DialogResult upit = MessageBox.Show("Želite li unesti još podataka?", "Upit",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                switch(upit)
                {
                    case DialogResult.Yes:
                        {
                            listaosoba.Add(Osoba);
                            break;
                        }
                    case DialogResult.No:
                        {
                            listaosoba.Add(Osoba);
                            txtIme.Enabled = false;
                            txtPrezime.Enabled = false;
                            txtGod.Enabled = false;
                            txtEmail.Enabled = false;
                            break;
                        }
                }
            }
            catch (Exception greska) { 
                MessageBox.Show(greska.Message, "Pogrešan unos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            /*
            // txtispisa.Text = Osoba.ToString();
            txtispisa.Text = "Ime,Prezime,Email,GodinaRođenja" + Environment.NewLine;
            foreach(osoba Osoba in listaosoba)
            {
                txtispisa.AppendText(Osoba.ToString()+Environment.NewLine);
            }
            */
            string putanjaDoDatoteke = "C:\\Users\\Ucenik\\Documents\\textCVC\\osobe.csv";
            try
            {
                using (StreamWriter sw = new StreamWriter(putanjaDoDatoteke))
                {
                    sw.WriteLine("Ime,Prezime,Email,GodinaRođenja");
                    foreach(osoba osoba in listaosoba)
                    {
                        sw.WriteLine($"{osoba.Ime},{osoba.Prezime},{osoba.Email}," + $"{osoba.GodinaRodjenja}");
                    }
                }
                MessageBox.Show("Podaci su uspješno spremljeni u CSV datoteku!", "Uspjeh",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Došlo je do pogreške prilikom spremanja podataka:" + ex.Message, "Pogreška",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
