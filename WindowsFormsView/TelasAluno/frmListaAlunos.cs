using System;
using System.Windows.Forms;
using Controllers;

namespace WindowsFormsView.TelasAluno
{
    public partial class frmListaAlunos : Form
    {
        public frmListaAlunos()
        {
            InitializeComponent();
        }

        private void frmListaAlunos_Load(object sender, EventArgs e)
        {
            AlunosController alunosController = new AlunosController();
            dvgAlunos.DataSource = alunosController.ListarTodos();
        }
    }
}
