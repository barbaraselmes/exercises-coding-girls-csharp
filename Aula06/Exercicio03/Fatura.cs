namespace Exercicio03
{
    internal class Fatura
    {
        private int numero;
        private string descricaoDosProdutos;
        private int quantidadeComprada;
        private double preco;

        public Fatura(int numero, string descricaoDosProdutos, int quantidadeComprada, double preco)
        {
            Numero = numero;
            DescricaoDosProdutos = descricaoDosProdutos;
            QuantidadeComprada = quantidadeComprada;
            Preco = preco;
            FaturaTotal();
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string DescricaoDosProdutos
        {
            get { return descricaoDosProdutos; }
            set { descricaoDosProdutos = value; }
        }

        public int QuantidadeComprada
        {
            get { return quantidadeComprada; }
            set { quantidadeComprada = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public void FaturaTotal()
        {
            double faturaTotal = QuantidadeComprada * Preco;
            Console.WriteLine($"A fatura total é R${faturaTotal:0.00}");
        }
    }
}
