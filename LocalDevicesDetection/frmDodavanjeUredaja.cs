using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBLayer;
using LocalDevicesDetection.Models;
using LocalDevicesDetection.Repositories;

namespace LocalDevicesDetection
{
    public partial class frmDodavanjeUredaja : Form
    {
        public frmDodavanjeUredaja()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            frmUpravljanjeUredajimaVoditelj frmupravljanjeuredajima = new frmUpravljanjeUredajimaVoditelj();
            Hide();
            frmupravljanjeuredajima.ShowDialog();
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtIDuredaja.TextLength == 8)
            {
                string sql = $"INSERT INTO Dopusteni_uredaji (ID_uredaja, Prezime_vlasnika, Ime_vlasnika, Uloga) VALUES ('{txtIDuredaja.Text}', '{txtPrezime.Text}', '{txtIme.Text}', '{txtUloga.Text}')";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show("Poznati uređaj je dodan!");
                frmUpravljanjeUredajimaVoditelj frmUpravljanjeUredajimaVoditelj = new frmUpravljanjeUredajimaVoditelj();
                Hide();
                frmUpravljanjeUredajimaVoditelj.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("ID uređaja mora imati 8 znakova!");
            }
        }
    }
}
