using System;

namespace AlunoSolution
{
    class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;


        public double NotaFInal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if(NotaFInal() >= 60.00)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }else
            {
                return 60.0 - NotaFInal();
            }
        }

    }
}
