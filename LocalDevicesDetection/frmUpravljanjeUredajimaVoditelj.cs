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
using DBLayer;

namespace LocalDevicesDetection
{
    public partial class frmUpravljanjeUredajimaVoditelj : Form
    {
        public frmUpravljanjeUredajimaVoditelj()
        {
            InitializeComponent();
            DB.SetConfiguration("kmedimore20_DB", "kmedimore20", "?Su/?Di@");
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

        private void btnBrisanje_Click(object sender, EventArgs e)
        {
            PoznatiUredaji odabrani = dgvDopusteniUredaji.CurrentRow.DataBoundItem as PoznatiUredaji;
            if (odabrani != null)
            {
                string sql = $"DELETE FROM Dopusteni_uredaji WHERE ID_uredaja = '{odabrani.ID.ToString()}'";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();

                MessageBox.Show("Uređaj je uspješno obrisan");

                frmDodavanjeUredaja frmDodavanjeUredaja = new frmDodavanjeUredaja();
                Hide();
                frmDodavanjeUredaja.ShowDialog();
                Close();
            }
        }
    }
}
