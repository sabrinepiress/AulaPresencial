using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
   public class DisciplinasController
    {
        public class AlunosController
        {
            List<Disciplina> tabelaDisciplinas = new List<Disciplina>();


            public void Inserir(Disciplina a)

            { tabelaDisciplinas.Add(a); }

            public List<Disciplina> ListarTodos()
            { return tabelaDisciplinas; }

        }
    }
}

