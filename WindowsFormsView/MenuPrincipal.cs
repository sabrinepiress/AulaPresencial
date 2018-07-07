﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsView.TelasAluno;

namespace WindowsFormsView
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            frmCadastroAluno frmaluno = new frmCadastroAluno();
            frmaluno.Show();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            frmListaAlunos listaAlunos = new frmListaAlunos();
            listaAlunos.Show();
        }
    }
}
