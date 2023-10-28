using System.Globalization;

namespace AprovacaoDeAlunos
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();
            bool sair = true;
           
            while (sair = true) { 
            Console.Write("Digite o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite as 3 notas dos Aluno");
            aluno.NotaA = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.NotaB = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            aluno.NotaC = int.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine("Nota Final = " + aluno.Media().ToString("f2", CultureInfo.InvariantCulture));
            Console.WriteLine();
            if (aluno.Media() > 50.00)
            {
                Console.WriteLine("Aprovador");
            }
            else
            {
                Console.WriteLine("Reprovador");
            }
                Console.Write("Novo Dados [1] Novo ou [0] Sair: ");
                string s = Console.ReadLine();
                Console.Clear();
                if (s == "0" ) 
                { 
                   break; 
                    Console.Clear();
                } else 
                {
                    Console.Write("informe Dados [1] Novo ou [0] Sair: ");
                    s = Console.ReadLine();
                }               
            }
            Console.WriteLine("Ate logo");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }


    }
}