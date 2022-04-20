using System;
using System.Collections.Generic;
namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Maria");
            list.Add("Geovane");
            list.Add("Zé");
            list.Add("João");
            list.Insert(1, "Gabriel");

            foreach(string nome in list)
            {
                Console.WriteLine(nome);
            }

            Console.WriteLine("List Size: " +list.Count);

            string s1 = list.Find(letra => letra[0] == 'G');
            Console.WriteLine("First 'G': " + s1);

            string s2 = list.FindLast(letra => letra[0] == 'J');
            Console.WriteLine("Last 'J': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'G');
            Console.WriteLine("First position 'G': "+ pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'G');
            Console.WriteLine("Last position 'G': " + pos2);

            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("----------------------");
            foreach(string obj in list2)
            {
                Console.WriteLine(obj);
            }
            //list.RemoveRange(2, 2); remove a partir da posição inicial, quantos valores infomados no segundo parâmetro
            //list.RemoveAt(2); remove pela posição
            list.Remove("Zé");
            Console.WriteLine("----------------");
            foreach(string obj in list)
            {
                Console.WriteLine(obj);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("----------------");
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


        }
        static bool Teste(string s)
        {
            return s[0] == 'A';
        }
    }
}
