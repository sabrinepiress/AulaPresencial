using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;

namespace Controllers
{
    public class DisciplinaController
    {
        List<Disciplina> tabelaDisciplina = new List<Disciplina>();

        public void Inserir(Disciplina m)
        {
            tabelaDisciplina.Add(m);
        }

        public List<Disciplina> ListarTodos()
        {
            return tabelaDisciplina;
        }
    }
}
