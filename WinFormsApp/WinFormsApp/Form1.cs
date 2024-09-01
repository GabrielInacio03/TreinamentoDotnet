using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Inicializando o Formulário!!!");

            cbxEstados.Items.Clear();

            foreach (var item in Estado.Lista())
            {
                cbxEstados.Items.Add(item);
            }
            cbxEstados.DisplayMember = "Nome"; // Define o que será mostrado no ComboBox
            cbxEstados.ValueMember = "Id"; // Define o valor real por trás de cada item
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
           txtResultado.Text = "OLá, esse é seu primeiro programa WinForms";
        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            //abrir formulário
            var formShow = new FormShow();
            formShow.labelShow.Text = txtResultado.Text;
            formShow.Show();
        }

        private void cbxEstados_SelectedIndexChanged(object sender, EventArgs e)
        {
            var estadoId = 0;
            if (VerificaCbxEstados())
            {
                estadoId = ((Estado)cbxEstados.SelectedItem).Id;
            }
            txtEstado.Text = $"Você selecionou o estado {cbxEstados.Text} e o seu id é {estadoId}";
        }
        public bool VerificaCbxEstados()
        {
            if (cbxEstados.SelectedItem is Estado estadoSelecionado)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public static List<Estado> Lista()
        {
            var lista = new List<Estado>();

            lista.Add(new Estado() { Id = 1, Nome = "Bahia" });
            lista.Add(new Estado() { Id = 2, Nome = "São Paulo" });
            lista.Add(new Estado() { Id = 3, Nome = "Rio de Janeiro" });
            lista.Add(new Estado() { Id = 4, Nome = "Mato Grosso" });
            lista.Add(new Estado() { Id = 5, Nome = "Minas Gerais" });

            return lista;
        }
        public override string ToString()
        {
            return this.Nome;
        }
    }
}
