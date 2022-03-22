using System;
using System.Globalization;
namespace AlunoSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aln = new Aluno();

            Console.Write("Nome do aluno: ");
            aln.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: {0}", aln.Nome);
            aln.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aln.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTA FINAL = "
                + aln.NotaFInal().ToString("F2", CultureInfo.InvariantCulture));

            if (aln.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM"
                    + aln.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + "Pontos");
            }
        }
    }
}
