using System;
using System.Globalization;


namespace FuncionarioSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();

            Console.Write("Nome: ");
            emp.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            emp.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            emp.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Funcionário: " + emp);
            Console.WriteLine("Digite a porcentagem para aumentar o salário:");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            emp.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + emp);
        }
    }
}
