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

            //Carregamento de Dados
            CarregandoComboBoxEstados();
            CarregandoGridViewEstados();
        }
        public void CarregandoComboBoxEstados()
        {
            cbxEstados.DataSource = Estado.Lista();
            cbxEstados.Text = "[Selecione]";
            //cbxEstados.Items.Clear();

            //foreach (var item in Estado.Lista())
            //{
            //    cbxEstados.Items.Add(item);
            //}
        }
        public void CarregandoGridViewEstados()
        {
            //A classe deve ter propriedades e não atributos

            //maneira simples
            //dgvEstados.DataSource = Estado.Lista();

            //maneira intermediária
            var data = from estado in Estado.Lista()
                       orderby estado.Id
                       select new
                       {
                           Id = estado.Id,
                           Nome = estado.Nome
                       };
            dgvEstados.DataSource = data.ToList();
            //maneira complexa
            //dgvEstados.ColumnCount = 2;
            //dgvEstados.Columns[0].Name = "Id";
            //dgvEstados.Columns[1].Name = "Nome";

            //var rows = new List<string[]>();
            //foreach (var item in Estado.Lista())
            //{
            //    string[] row1 = new string[] { item.Id.ToString(), item.Nome };
            //    rows.Add(row1);
            //}

            //foreach (var item in rows)
            //{
            //    dgvEstados.Rows.Add(item);
            //}
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

        private void novoTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formText = new FrmTexto();
            formText.Show(); 
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmSobre().Show();
        }

        private void licençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmLicenca().Show();
        }

        private void doaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FrmDoacao().Show();
        }
    }
    public class Estado
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }

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
