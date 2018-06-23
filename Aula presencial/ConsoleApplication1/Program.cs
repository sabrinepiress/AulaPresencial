using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
           CadastrarAluno();

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
        }
    }
}
