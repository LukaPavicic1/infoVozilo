using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace infoVozilo
{
    public partial class Form1 : Form
    {
        List<Vozilo> listaVozila = new List<Vozilo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            int kontrola = 0;
            if (Convert.ToInt32(txtKotač.Text) % 2 != 0)
            {
                MessageBox.Show("Unesite paran broj kotaca!",
                "Greška", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                kontrola = 1;
            }
        }

        private void btnObrada_Click(object sender, EventArgs e)
        {

        }

        private void btnIspis_Click(object sender, EventArgs e)
        {
            txtModel.Text = txtIspis.Text;
            txtGod.Text = txtIspis.Text;
            txtKotač.Text = txtIspis.Text;
        }
        class Automobil
        {

        } 
    }

}
