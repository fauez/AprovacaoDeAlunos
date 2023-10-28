using System.Globalization;


namespace AprovacaoDeAlunos
{
    internal class Aluno
    {
        public string Nome;
        public double NotaA;
        public double NotaB;
        public double NotaC;

        public double Media()
        {
            return (NotaA+NotaB+NotaC)/3;

        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
