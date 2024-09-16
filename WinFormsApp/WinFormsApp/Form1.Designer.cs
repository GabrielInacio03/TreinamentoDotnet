
namespace WinFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTxt = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAbrir = new System.Windows.Forms.Button();
            this.cbxEstados = new System.Windows.Forms.ComboBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.dgvEstados = new System.Windows.Forms.DataGridView();
            this.lblDataGrid = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.licençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTxt
            // 
            this.lblTxt.AutoSize = true;
            this.lblTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblTxt.Location = new System.Drawing.Point(46, 49);
            this.lblTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTxt.Name = "lblTxt";
            this.lblTxt.Size = new System.Drawing.Size(353, 20);
            this.lblTxt.TabIndex = 0;
            this.lblTxt.Text = "Pressione OK para preencher a caixa de texto";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(50, 74);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(379, 26);
            this.txtResultado.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(48, 274);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(381, 71);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnAbrir
            // 
            this.btnAbrir.Location = new System.Drawing.Point(48, 355);
            this.btnAbrir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAbrir.Name = "btnAbrir";
            this.btnAbrir.Size = new System.Drawing.Size(381, 68);
            this.btnAbrir.TabIndex = 3;
            this.btnAbrir.Text = "Abrir Nova Janela";
            this.btnAbrir.UseVisualStyleBackColor = true;
            this.btnAbrir.Click += new System.EventHandler(this.btnAbrir_Click);
            // 
            // cbxEstados
            // 
            this.cbxEstados.FormattingEnabled = true;
            this.cbxEstados.Location = new System.Drawing.Point(50, 152);
            this.cbxEstados.Name = "cbxEstados";
            this.cbxEstados.Size = new System.Drawing.Size(380, 28);
            this.cbxEstados.TabIndex = 4;
            this.cbxEstados.Text = "[Selecione]";
            this.cbxEstados.SelectedIndexChanged += new System.EventHandler(this.cbxEstados_SelectedIndexChanged);
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.35F);
            this.lblEstados.Location = new System.Drawing.Point(46, 129);
            this.lblEstados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(70, 20);
            this.lblEstados.TabIndex = 5;
            this.lblEstados.Text = "Estados";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(52, 189);
            this.txtEstado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(379, 26);
            this.txtEstado.TabIndex = 6;
            // 
            // dgvEstados
            // 
            this.dgvEstados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstados.Location = new System.Drawing.Point(478, 74);
            this.dgvEstados.Name = "dgvEstados";
            this.dgvEstados.RowHeadersWidth = 62;
            this.dgvEstados.RowTemplate.Height = 28;
            this.dgvEstados.Size = new System.Drawing.Size(582, 349);
            this.dgvEstados.TabIndex = 7;
            // 
            // lblDataGrid
            // 
            this.lblDataGrid.AutoSize = true;
            this.lblDataGrid.Location = new System.Drawing.Point(478, 29);
            this.lblDataGrid.Name = "lblDataGrid";
            this.lblDataGrid.Size = new System.Drawing.Size(225, 20);
            this.lblDataGrid.TabIndex = 8;
            this.lblDataGrid.Text = "Dados da Coleção de Estados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1084, 33);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoTextoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoTextoToolStripMenuItem
            // 
            this.novoTextoToolStripMenuItem.Name = "novoTextoToolStripMenuItem";
            this.novoTextoToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.novoTextoToolStripMenuItem.Text = "Novo Texto";
            this.novoTextoToolStripMenuItem.Click += new System.EventHandler(this.novoTextoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(204, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.licençaToolStripMenuItem,
            this.doaçãoToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(60, 29);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // licençaToolStripMenuItem
            // 
            this.licençaToolStripMenuItem.Name = "licençaToolStripMenuItem";
            this.licençaToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.licençaToolStripMenuItem.Text = "Licença";
            this.licençaToolStripMenuItem.Click += new System.EventHandler(this.licençaToolStripMenuItem_Click);
            // 
            // doaçãoToolStripMenuItem
            // 
            this.doaçãoToolStripMenuItem.Name = "doaçãoToolStripMenuItem";
            this.doaçãoToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.doaçãoToolStripMenuItem.Text = "Doação";
            this.doaçãoToolStripMenuItem.Click += new System.EventHandler(this.doaçãoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 437);
            this.Controls.Add(this.lblDataGrid);
            this.Controls.Add(this.dgvEstados);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.cbxEstados);
            this.Controls.Add(this.btnAbrir);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblTxt);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Aplicação 1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstados)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTxt;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAbrir;
        private System.Windows.Forms.ComboBox cbxEstados;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.DataGridView dgvEstados;
        private System.Windows.Forms.Label lblDataGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem licençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
    }
}

