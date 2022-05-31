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
    public partial class frmBrisanjeUredaja : Form
    {
        public frmBrisanjeUredaja()
        {
            InitializeComponent();
        }
        private void btnObrisi_Click(object sender, EventArgs e)
        {
            if (txtID.TextLength == 8)
            {
                string sql = $"DELETE FROM Dopusteni_uredaji WHERE ID_uredaja = '{txtID.Text}'";
                DB.OpenConnection();
                DB.ExecuteCommand(sql);
                DB.CloseConnection();
                MessageBox.Show("Uređaj je uspješno izbrisan!");
                Hide();
                frmUpravljanjeUredajimaVoditelj frmUpravljanjeUredajimaVoditelj = new frmUpravljanjeUredajimaVoditelj();
                frmUpravljanjeUredajimaVoditelj.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("ID uređaja sastoji se od točno 8 znakova!");
            }
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            Hide();
            frmUpravljanjeUredajimaVoditelj frmUpravljanjeUredajimaVoditelj = new frmUpravljanjeUredajimaVoditelj();
            frmUpravljanjeUredajimaVoditelj.ShowDialog();
            Close();
        }
    }
}
