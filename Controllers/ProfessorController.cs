using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class ProfessorController
    {
        List<Professor> tabelaProfessor = new List<Professor>();

        public void Inserir(Professor p)
        {
            tabelaProfessor.Add(p);
        }

        public List<Professor> ListarTodos()
        {
            return tabelaProfessor;
        }

    }
}
