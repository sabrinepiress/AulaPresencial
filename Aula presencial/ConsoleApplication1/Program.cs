using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controllers;
using Modelos;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController alunosController = new AlunosController();

            //Cadastrando Aluno 

            Aluno a = CadastrarAluno();
            alunosController.Inserir(a);

            Aluno b = CadastrarAluno();
            alunosController.Inserir(b);

            Aluno c = CadastrarAluno();
            alunosController.Inserir(c);

            foreach (Aluno aluno in alunosController.ListarTodos())
            {
                ImprimeDadosAluno(aluno);
            }

            Console.ReadKey();

        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();
            Console.Write("Digite o nome do aluno");
            a.Nome = Console.ReadLine();//set

            Console.Write("Digite o numero da matricula:");
            a.Matricula = int.Parse(Console.ReadLine());//set
            return a;
        }

        private static void ImprimeDadosAluno(Aluno a)
        {
            Console.Write("Aluno:" + a.Nome + "\nMatricula:" + a.Matricula);

           ProfessoresController professoresController = new ProfessoresController();

            //Cadastrando Professor 

            Professor a = CadastrarProfessor();
            professorController.Inserir(a);

          Professor b = CadastrarProfessor();
            professorController.Inserir(b);

         Professor c = CadastrarProfessor();
            professorController.Inserir(c);

            foreach (Professor professor in professoresController.ListarTodos())
            {
                ImprimeDadosProfessores(professor);
            }

            Console.ReadKey();

        }

        private static Professor CadastrarProfessor()
        {
            Professor a = new Professor();
            Console.Write("Digite o nome do Professor");
            a.Nome = Console.ReadLine();//set

            Console.Write("Digite o nome da diciplina:");
            a.Disciplina = int.Parse(Console.ReadLine());//set
            return a;
        }
    }
}