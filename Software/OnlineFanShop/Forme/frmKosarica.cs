using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineFanShop.Entities;
using OnlineFanShop.Klase;

namespace OnlineFanShop
{
    public partial class frmKosarica : Form
    {
        RepozitorijKosarica repozitorijKosarica = new RepozitorijKosarica();
        public int korisnik { get; set; }
        public frmKosarica(int korisnikID)
        {
            korisnik = korisnikID;
            InitializeComponent();
        }

        private void frmKosarica_Load(object sender, EventArgs e)
        {
            OsvijeziKosaricu();
            if (dgvKosarica.Rows.Count > 0)
            {
                btnFanKviz.Enabled = true;
            }
            else
            {
                btnFanKviz.Enabled = false;
            }
        }
            private void OsvijeziKosaricu()
        {
            dgvKosarica.DataSource = repozitorijKosarica.DohvatiSadrzajKosarice(korisnik);
            dgvKosarica.Columns["Korisnik"].Visible = false;
            dgvKosarica.Columns["Ponuda"].Visible = false;
        }

        private void btnFanKviz_Click(object sender, EventArgs e)
        {
                Kosarica odabranaStavka = dgvKosarica.CurrentRow.DataBoundItem as Kosarica;
                frmFanKviz form = new frmFanKviz(repozitorijKosarica.DohvatiFransizuProizvodaIzKosarice(odabranaStavka), korisnik);
                form.ShowDialog();
                OsvijeziKosaricu();
                btnFanKviz.Enabled = false;
        }
    }
}
