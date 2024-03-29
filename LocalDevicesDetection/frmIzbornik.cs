﻿using System;
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
    public partial class frmIzbornik : Form
    {
        public frmIzbornik()
        {
            InitializeComponent();
        }

        private void btnUpravljanjeUredajima_Click(object sender, EventArgs e)
        {
            frmUpravljanjeUredajimaVoditelj frmupravljanjeuredajima = new frmUpravljanjeUredajimaVoditelj();
            Hide();
            frmupravljanjeuredajima.ShowDialog();
            Close();
        }

        private void btnOdjava_Click(object sender, EventArgs e)
        {
            frmLogin frmlogin = new frmLogin();
            Hide();
            frmlogin.ShowDialog();
            Close();
        }

        private void btnOdabirObjekta_Click(object sender, EventArgs e)
        {
            frmOdabirObjekta frmodabirobjekta = new frmOdabirObjekta();
            Hide();
            frmodabirobjekta.ShowDialog();
            Close();
        }
    }
}
