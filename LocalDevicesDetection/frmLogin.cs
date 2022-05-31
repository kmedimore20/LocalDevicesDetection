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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string usernameVoditelj = "Voditelj";
        string passwordVoditelj = "voditelj";
        string usernameZastitar = "Zastitar";
        string passwordZastitar = "zastitar";

        private void btnPrijava_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "")
            {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtLozinka.Text == "")
            {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (txtKorIme.Text == usernameVoditelj && txtLozinka.Text == passwordVoditelj)
                {
                    frmIzbornik frmizbornik = new frmIzbornik();
                    Hide();
                    frmizbornik.ShowDialog();
                    Close();
                }
                else if(txtKorIme.Text == usernameZastitar && txtLozinka.Text == passwordZastitar)
                {
                    frmPracenjeUredajaZastitar frmpracenjeuredajazastitar = new frmPracenjeUredajaZastitar();
                    Hide();
                    frmpracenjeuredajazastitar.ShowDialog();
                    Close();
                }
                else
                {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
