
namespace WinFormsApp
{
    partial class FrmLicenca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLicenca));
            this.btnLicenca = new System.Windows.Forms.Button();
            this.txtLicenca = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLicenca
            // 
            this.btnLicenca.Location = new System.Drawing.Point(12, 25);
            this.btnLicenca.Name = "btnLicenca";
            this.btnLicenca.Size = new System.Drawing.Size(185, 73);
            this.btnLicenca.TabIndex = 0;
            this.btnLicenca.Text = "Obter Licença";
            this.btnLicenca.UseVisualStyleBackColor = true;
            this.btnLicenca.Click += new System.EventHandler(this.btnLicenca_Click);
            // 
            // txtLicenca
            // 
            this.txtLicenca.Location = new System.Drawing.Point(13, 116);
            this.txtLicenca.Name = "txtLicenca";
            this.txtLicenca.Size = new System.Drawing.Size(521, 26);
            this.txtLicenca.TabIndex = 1;
            this.txtLicenca.Text = "Digite a chave";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(549, 113);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(138, 33);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmLicenca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtLicenca);
            this.Controls.Add(this.btnLicenca);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLicenca";
            this.Text = "FrmSilenca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLicenca;
        private System.Windows.Forms.TextBox txtLicenca;
        private System.Windows.Forms.Button btnRegistrar;
    }
}