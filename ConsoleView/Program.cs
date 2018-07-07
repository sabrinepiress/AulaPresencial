using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Controllers;


namespace ConsoleView
{
    class Program
    {
        static void Main(string[] args)
        {
            AlunosController alunosController = new AlunosController();
            ProfessorController professorController = new ProfessorController();
            DisciplinaController disciplinaController = new DisciplinaController();


            //Cadastrando alunos
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

            //Cadastrando Professores
            Professor d = CadastrarProfessor();
            professorController.Inserir(d);

            Professor e = CadastrarProfessor();
            professorController.Inserir(e);

            Professor f = CadastrarProfessor();
            professorController.Inserir(f); 

            foreach (Professor professor in professorController.ListarTodos())
            {
                ImprimeDadosProfessor(professor);
            }

            //Cadastrando disciplina
            Disciplina g = CadastrarDisciplina();
            disciplinaController.Inserir(g);

            Disciplina h = CadastrarDisciplina();
            disciplinaController.Inserir(h);

            Disciplina i = CadastrarDisciplina();
            disciplinaController.Inserir(i);

            foreach (Disciplina disciplina in disciplinaController.ListarTodos())
            {
                ImprimeDadosDisciplina(disciplina);
            }

            Console.ReadKey();
        }
        

        private static void ImprimeDadosAluno(Aluno a)
        {
            Console.Write("Aluno: " + a.Nome);
            Console.WriteLine();
            Console.Write("Matrícula: " + a.Matricula + "\n");
            Console.Write("======================================================");
            Console.WriteLine();
        }

        private static Aluno CadastrarAluno()
        {
            Aluno a = new Aluno();

            Console.Write("Digite o nome do aluno: \n");
            a.Nome = Console.ReadLine();

            Console.Write("Digite a matrícula do aluno(NUMÉRICO): \n");
            a.Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            return a;
        }

        private static void ImprimeDadosProfessor(Professor p)
        {
            Console.Write("Professor: " + p.Nome);
            Console.WriteLine();

            Console.Write("Matrícula: " + p.Matricula);
            Console.WriteLine();

            Console.Write("Formação: " + p.Disciplina + "\n");
            Console.Write("======================================================");
            Console.WriteLine();

        }

        private static Professor CadastrarProfessor()
        {
            Professor p = new Professor();

            Console.WriteLine();
            Console.Write("Digite o nome do professor: \n");
            p.Nome = Console.ReadLine();

            Console.Write("Digite a matrícula do professor(NUMÉRICO): \n");
            p.Matricula = int.Parse(Console.ReadLine());

            Console.Write("Formação: \n");
            p.Disciplina = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine();

            return p;
        }

        private static void ImprimeDadosDisciplina(Disciplina m)
        {
            Console.Write("Título: " + m.Titulo);
            Console.WriteLine();

            Console.Write("Código: " + m.Codigo+"\n");
            Console.WriteLine("======================================================");
            Console.WriteLine();

        }

        private static Disciplina CadastrarDisciplina()
        {
            Disciplina m = new Disciplina();

            Console.WriteLine();
            Console.Write("Digite o nome da disciplina: \n");
            m.Titulo = Console.ReadLine();

            Console.Write("Digite o código da disciplina(NUMÉRICO): \n");
            m.Codigo = int.Parse(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine();

            return m;
        }

    }
}
