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
    public partial class frmPracenjeUredajaZastitar : Form
    {
        public frmPracenjeUredajaZastitar()
        {
            InitializeComponent();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            Hide();
            frmlogin.ShowDialog();
            Close();
        }
    }
}
