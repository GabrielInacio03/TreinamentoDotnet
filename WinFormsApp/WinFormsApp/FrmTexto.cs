using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class FrmTexto : Form
    {
        public FrmTexto()
        {
            InitializeComponent();
        }
        public void SalvarArquivoTXT()
        {
            File.WriteAllText(@"C:\workspace\textForms" + DateTime.Now.ToString("dd_MM_yyyy") + ".txt", txtArquivo.Text);
            MessageBox.Show("Arquivo Salvo");
            txtArquivo.Text = string.Empty;
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.SalvarArquivoTXT();
        }
    }
}
