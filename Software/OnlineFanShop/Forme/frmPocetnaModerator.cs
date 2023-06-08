using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineFanShop.Klase;
using OnlineFanShop.Entities;

namespace OnlineFanShop
{
    public partial class frmPocetnaModerator : Form
    {
        RepozitorijPonuda PregledPonude = new RepozitorijPonuda();
        RepozitorijListaZelja repozitorijListaZelja = new RepozitorijListaZelja();
        public float cijenaMin { get; set; }
        public float cijenaMax { get; set; }
        public string vrsta { get; set; }
        public string fransiza { get; set; }
        public string velicina { get; set; }
        public frmPocetnaModerator()
        {
            InitializeComponent();
        }
        private void FrmPocetnaModerator_Load(object sender, EventArgs e)
        {
            OsvjeziPopisPonude();

            cmbFranšiza.DataSource = PregledPonude.PopuniFransizaCMB();
            cmbFranšiza.DisplayMember = "nazivFransize";
            cmbVeličina.DataSource = PregledPonude.PopuniVelicinaCMB();
            cmbVeličina.DisplayMember = "nazivVelicine";
            cmbVrsta.DataSource = PregledPonude.PopuniVrstaCMB();
            cmbVrsta.DisplayMember = "nazivVrste";

            PopuniSortiranje();
            btnPrikaziDetalje.Enabled = false;
            cmbFranšiza.Text = "";
            cmbVrsta.Text = "";
            cmbVeličina.Text = "";

            lblDodano.Visible = false;
        }

        private void OsvjeziPopisPonude()
        {
            dgvPonuda.DataSource = PregledPonude.PopuniPonudaDGV();
            dgvPonuda.Columns["ID_ponuda"].Visible = false;

            dgvPonuda.Columns[1].HeaderText = "Naziv proizvoda";
            dgvPonuda.Columns[2].HeaderText = "Vrsta proizvoda";
            dgvPonuda.Columns[3].HeaderText = "Franšiza proizvoda";
            dgvPonuda.Columns[4].HeaderText = "Veličina";
            dgvPonuda.Columns[5].HeaderText = "Ocjena";
            dgvPonuda.Columns[6].HeaderText = "Količina";
            dgvPonuda.Columns[7].HeaderText = "Cijena (HRK)";
        }

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            frmPrijava prijava = new frmPrijava();
            prijava.ShowDialog();

        }

        private void btnFiltriraj_Click(object sender, EventArgs e)
        {
            DohvatiFiltere();
            dgvPonuda.DataSource = PregledPonude.Filtriraj(cijenaMin, cijenaMax, fransiza, velicina, vrsta);
            dgvPonuda.Columns["ID_ponuda"].Visible = false;
        }

        private void btnResetiraj_Click(object sender, EventArgs e)
        {
            dgvPonuda.DataSource = PregledPonude.PopuniPonudaDGV();
            cmbSortiranje.Text = "";
            txtPretrazi.Text = "";
            cmbFranšiza.Text = "";
            cmbVrsta.Text = "";
            cmbVeličina.Text = "";
        }

        private void btnPrikaziDetalje_Click(object sender, EventArgs e)
        {
            PopisPonude selektiranaPonuda = dgvPonuda.CurrentRow.DataBoundItem as PopisPonude;
            int id_korisnik = 2;
            frmDetaljiPonude form = new frmDetaljiPonude(selektiranaPonuda, id_korisnik);
            form.ShowDialog();
            OsvjeziPopisPonude();
        }

        private void cmbSortiranje_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sort = cmbSortiranje.Text.ToString();
            dgvPonuda.DataSource = PregledPonude.Sortiraj(sort);
            dgvPonuda.Columns["ID_ponuda"].Visible = false;
        }

        private void DohvatiFiltere()
        {
            cijenaMin = 0;
            cijenaMax = 999999;
            if (txtCijenaMin.Text != "")
            {
                cijenaMin = float.Parse(txtCijenaMin.Text);
            }
            if (txtCijenaMax.Text != "")
            {
                cijenaMax = float.Parse(txtCijenaMax.Text);
            }

            vrsta = cmbVrsta.Text;
            fransiza = cmbFranšiza.Text;
            velicina = cmbVeličina.Text;
        }

        private void PopuniSortiranje()
        {
            cmbSortiranje.Items.Add("Po vrsti");
            cmbSortiranje.Items.Add("Po franšizi");
            cmbSortiranje.Items.Add("Po ocjeni");
            cmbSortiranje.Items.Add("Po cijeni");
        }

        private void txtPretrazi_TextChanged(object sender, EventArgs e)
        {
            string naziv = txtPretrazi.Text.ToString();
            dgvPonuda.DataSource = PregledPonude.Pretrazi(naziv);
            dgvPonuda.Columns["ID_ponuda"].Visible = false;
        }

        private void btnKosarica_Click(object sender, EventArgs e)
        {
            frmKosarica form = new frmKosarica(2);
            form.ShowDialog();
        }

        private void dgvPonuda_SelectionChanged(object sender, EventArgs e)
        {
            lblDodano.Visible = false;

            if (dgvPonuda.SelectedRows.Count == 0)
            {
                btnPrikaziDetalje.Enabled = false;
                btnDodajNaListuZelja.Enabled = false;
            }
            else
            {
                btnPrikaziDetalje.Enabled = true;
                btnDodajNaListuZelja.Enabled = true;
            }
        }

        private void btnZaprimanjeRobe_Click(object sender, EventArgs e)
        {
            frmZaprimanjeRobe form = new frmZaprimanjeRobe();
            form.ShowDialog();
        }

        private void btnListaZelja_Click(object sender, EventArgs e)
        {
            frmListaZelja form = new frmListaZelja(2);
            form.ShowDialog();
        }

        private void btnDodajNaListuZelja_Click(object sender, EventArgs e)
        {
            int selektiranaPonuda = (dgvPonuda.CurrentRow.DataBoundItem as PopisPonude).ID_ponuda;
            int id_korisnik = 2;
            try
            {
                repozitorijListaZelja.DodajNaListuZelja(id_korisnik, selektiranaPonuda);
                lblDodano.Visible = true;
            }
            catch
            {
                MessageBox.Show("Već je na listi želja!");
            }
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
