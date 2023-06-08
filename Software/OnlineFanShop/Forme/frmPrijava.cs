using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineFanShop
{
    public partial class frmPrijava : Form
    {
        public frmPrijava()
        {
            InitializeComponent();
        }

        private void btnPrijavaAdmin_Click(object sender, EventArgs e)
        {
            frmPocetnaAdmin form = new frmPocetnaAdmin();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnPrijavaKorisnik_Click(object sender, EventArgs e)
        {
            frmPocetnaKorisnik form = new frmPocetnaKorisnik();
            Hide();
            form.ShowDialog();
            Close();
        }

        private void btnPrijavaModerator_Click(object sender, EventArgs e)
        {
            frmPocetnaModerator form = new frmPocetnaModerator();
            Hide();
            form.ShowDialog();
            Close();
        }
    }
}
