
namespace WinFormsApp
{
    partial class FrmDoacao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnDoacao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDoacao
            // 
            this.btnDoacao.Location = new System.Drawing.Point(243, 181);
            this.btnDoacao.Name = "btnDoacao";
            this.btnDoacao.Size = new System.Drawing.Size(296, 52);
            this.btnDoacao.TabIndex = 0;
            this.btnDoacao.Text = "Para realizar a doação clique aqui";
            this.btnDoacao.UseVisualStyleBackColor = true;
            this.btnDoacao.Click += new System.EventHandler(this.btnDoacao_Click);
            // 
            // FrmDoacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoacao);
            this.Name = "FrmDoacao";
            this.Text = "FrmDoacao";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoacao;
    }
}