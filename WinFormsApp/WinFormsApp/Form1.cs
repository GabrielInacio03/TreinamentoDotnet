﻿using System;
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
    }
}
