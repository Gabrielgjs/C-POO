using System;
using System.Globalization;
using System.Collections.Generic;

namespace ListaExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos funcionários serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> list = new List<Funcionario>();

            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("Funcionario #" + i);
                Console.Write("Id:");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salario :");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Funcionario(id, nome, salario));
                Console.WriteLine();
            }

            Console.WriteLine("Entre o ID do funcionário que terá o aumento no salário: ");
            int idAumento = int.Parse(Console.ReadLine());

            Funcionario emp = list.Find(x => x.Id == idAumento);
            if ( emp != null)
            {
                Console.Write("Informe a porcentagem: ");
                double porcentagem = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                emp.AumentarSalario(porcentagem);
            }else
            {
                Console.WriteLine("Esse ID não existe!");
            }

            Console.WriteLine();
            Console.WriteLine("Lista atualizada de Funcionários: ");
            foreach(Funcionario obj in list)
            {
                Console.WriteLine(obj);
            }

        }
    }
}
