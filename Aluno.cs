using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPOOMediaAluno
{
    public class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public bool Aprovado;

        public Aluno()
        {
            Aprovado = false;
        }

        public double CalcularNotaFinal()
        {
            double notafinal = Nota1 + Nota2 + Nota3;
            if (notafinal >= 60)
                Aprovado = true;
            return notafinal;
        }

    }
}
