
namespace WinFormsApp
{
    partial class FormShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShow));
            this.labelShow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelShow
            // 
            this.labelShow.AutoSize = true;
            this.labelShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShow.Location = new System.Drawing.Point(297, 271);
            this.labelShow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelShow.Name = "labelShow";
            this.labelShow.Size = new System.Drawing.Size(495, 55);
            this.labelShow.TabIndex = 0;
            this.labelShow.Text = "escrever em run time";
            this.labelShow.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 692);
            this.Controls.Add(this.labelShow);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormShow";
            this.Text = "FormShow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelShow;
    }
}