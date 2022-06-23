namespace Exercicio02
{
    internal class Empregado
    {
        public string Nome;
        public string Cargo;
        public double SalarioMensal;

        public Empregado(string nome, string cargo, double salarioMensal)
        {
            Nome = nome;
            Cargo = cargo;
            SalarioMensal = salarioMensal;

            AumentoDeSalario();
        }

        public double ConfigurarSalario()
        {
            if (SalarioMensal < 0)
            {
                SalarioMensal = 0.0;
            }
            return SalarioMensal;
        }

        public void AumentoDeSalario()
        {
            SalarioMensal = ConfigurarSalario();

            Console.Write($"\nFuncionário(a): {Nome}\nCargo: {Cargo}\nSalário inicial: R${SalarioMensal}");

            if (SalarioMensal <= 400.00)
            {
                SalarioMensal = SalarioMensal * 1.15;
            }
            else if (SalarioMensal <= 800.00)
            {
                SalarioMensal = SalarioMensal * 1.12;
            }
            else if (SalarioMensal <= 1200.00)
            {
                SalarioMensal = SalarioMensal * 1.10;
            }
            else if (SalarioMensal <= 2000.00)
            {
                SalarioMensal = SalarioMensal * 1.04;
            }
            else
            {
                SalarioMensal = SalarioMensal * 1.07;
            }

            Console.WriteLine($"\nSalário com reajuste: R${SalarioMensal}");
        }
    }
}
