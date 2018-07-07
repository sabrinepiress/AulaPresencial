using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Controllers.DAL;

namespace Controllers
{
    public class AlunosController
    {
        Contexto contexto = new Contexto();

        public void Inserir(Aluno novoAluno)
        {
            contexto.Alunos.Add(novoAluno);
            contexto.SaveChanges();
        }

        public List<Aluno> ListarTodos()
        {
            return contexto.Alunos.ToList();
        }


        public Aluno BuscarMatricula(int matricula) 
        {
            //usando LINQ
            var aluno = from a in contexto.Alunos
                          where a.Matricula == matricula
                          select a;

            return (Aluno)aluno;
        }

        public Aluno BuscarNome(string nome)
        {
            //usando LINQ
            var aluno = from a in contexto.Alunos
                        where a.Nome == nome
                        select a;

            return (Aluno)aluno;
        }

        public Aluno BuscarPorID(int idAluno)
        {
            return contexto.Alunos.Find(idAluno); //Pesquisa por chave primaria
        }

        public void Atualizar(Aluno aluno)
        {
            contexto.Entry(aluno).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir (int idAluno)
        {
            Aluno aluno = BuscarPorID(idAluno);
            contexto.Alunos.Remove(aluno);
            contexto.SaveChanges();
        }
    }
}
