using System;

namespace SintaxeLacoForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "Maria", "João", "Alex" };

            foreach(string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
