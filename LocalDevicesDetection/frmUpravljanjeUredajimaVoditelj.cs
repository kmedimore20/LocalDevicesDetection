using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocalDevicesDetection.Models;
using LocalDevicesDetection.Repositories;

namespace LocalDevicesDetection
{
    public partial class frmUpravljanjeUredajimaVoditelj : Form
    {
        public frmUpravljanjeUredajimaVoditelj()
        {
            InitializeComponent();
        }

        private void frmUpravljanjeUredajima_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kmedimore20_DBDataSet.Dopusteni_uredaji' table. You can move, or remove it, as needed.
            this.dopusteni_uredajiTableAdapter.Fill(this.kmedimore20_DBDataSet.Dopusteni_uredaji);

        }

        private void PrikazUredaja()
        {
            var uredaji = PoznatiUredajiRepository.GetUredaj();
            dgvDopusteniUredaji.DataSource = uredaji;

            dgvDopusteniUredaji.Columns["ID_uredaja"].DisplayIndex = 0;
            dgvDopusteniUredaji.Columns["Prezime"].DisplayIndex = 1;
            dgvDopusteniUredaji.Columns["Ime"].DisplayIndex = 2;
            dgvDopusteniUredaji.Columns["Uloga"].DisplayIndex = 3;
        }

        private void btnDodajNoviUredaj_Click(object sender, EventArgs e)
        {
            frmDodavanjeUredaja frmdodavanjeuredaja = new frmDodavanjeUredaja();
            Hide();
            frmdodavanjeuredaja.ShowDialog();
            Close();
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            frmIzbornik frmizbornik = new frmIzbornik();
            Hide();
            frmizbornik.ShowDialog();
            Close();
        }
    }
}
