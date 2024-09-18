using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Upisivanjapodataka_u_csv
{
    public partial class Form1 : Form
    {
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
                            break;
                        }
                    case DialogResult.No:
                        {
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
    }
}
