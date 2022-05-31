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

namespace LocalDevicesDetection
{
    public partial class frmAzuriranje : Form
    {
        public frmAzuriranje()
        {
            InitializeComponent();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpravljanjeUredajimaVoditelj frmUpravljanjeUredajimaVoditelj = new frmUpravljanjeUredajimaVoditelj();
            frmUpravljanjeUredajimaVoditelj.ShowDialog();
            Close();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            if (txtIDstarog.TextLength == 8)
            {
                if (txtIDnovi.TextLength == 8)
                {
                    string sql = $"UPDATE Dopusteni_uredaji SET ID_uredaja = '{txtIDnovi.Text}', Prezime_vlasnika = '{txtPrezimeNovo.Text}', Ime_vlasnika = '{txtImeNovo.Text}', Uloga = '{txtRadnoMjesto.Text}' WHERE ID_uredaja = '{txtIDstarog.Text}'";
                    DB.OpenConnection();
                    DB.ExecuteCommand(sql);
                    DB.CloseConnection();
                    MessageBox.Show("Zapis je uspješno ažuriran!");
                    Hide();
                    frmUpravljanjeUredajimaVoditelj frmUpravljanjeUredajimaVoditelj = new frmUpravljanjeUredajimaVoditelj();
                    frmUpravljanjeUredajimaVoditelj.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("ID novog uređaja mora imati točno 8 znakova!");
                }
            }
            else
            {
                MessageBox.Show("ID uređaja koji želite promjeniti treba imati točno 8 znakova!");
            }
        }
    }
}
