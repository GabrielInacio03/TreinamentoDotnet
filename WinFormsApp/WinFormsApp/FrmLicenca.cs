using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmLicenca : Form
    {
        public FrmLicenca()
        {
            InitializeComponent();
        }

        private void btnLicenca_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.torneseumprogramador.com.br/");
            string guidKey = new Guid().ToString();
            txtLicenca.Text = guidKey;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa Registrado");
        }
    }
}
