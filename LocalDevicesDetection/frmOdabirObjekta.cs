using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LocalDevicesDetection
{
    public partial class frmOdabirObjekta : Form
    {
        public frmOdabirObjekta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIzbornik frmizbornik = new frmIzbornik();
            Hide();
            frmizbornik.ShowDialog();
            Close();
        }

        private void btnZatvorPrizemlje_Click(object sender, EventArgs e)
        {
            frmPracenjeUredajaVoditelj frmpracenjeuredajavoditelj = new frmPracenjeUredajaVoditelj();
            Hide();
            frmpracenjeuredajavoditelj.ShowDialog();
            Close();
        }
    }
}
