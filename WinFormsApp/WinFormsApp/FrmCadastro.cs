using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                int numero = int.Parse(txtNumero.Text);
                numero += 100;
                MessageBox.Show($"Olá {nome}, o valor do número mais 100 é de: {numero}");
            }
            catch (FormatException fx)
            {
                Console.WriteLine($"FormatException.Error -> {fx.Message}");
                MessageBox.Show("Não foi possível realizar essa operação, revise os campos do formulário.");
                txtNumero.Focus();
            }
            catch (ErrorDeProposito ex)
            {
                Console.WriteLine($"ErrorDeProposito.Erro -> {ex.Message}");
                MessageBox.Show("ErrorDeProposito -> Não foi possível realizar essa operação, tente novamente mais tarde.");
            }catch (Exception ex)
            {
                Console.WriteLine($"Exception.Erro -> {ex.Message}");
                MessageBox.Show("Não foi possível realizar essa operação, tente novamente mais tarde.");
            }
            
            
        }
    }
}
