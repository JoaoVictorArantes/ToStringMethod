namespace ToStringMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Converte um objeto para a sua representação em String para que fique adequado para exibição

            Moto minhaMoto = new Moto("Honda","PCX", 2012, "Branca");

            Console.WriteLine(minhaMoto);


            Console.ReadKey();
            Console.Beep();
        }
    }
    class Moto
    {
        String Fabricante;
        String Modelo;
        int Ano;
        String Cor;

        public Moto(String Fabricante, String Modelo, int Ano, String Cor)
        {
            this.Fabricante = Fabricante;
            this.Modelo = Modelo;
            this.Ano = Ano;
            this.Cor = Cor;
        }
        public override string ToString()
        {
            return $"A minha moto é do modelo {Modelo}, fabricado pela {Fabricante}, de cor {Cor} e do ano {Ano}";
        }

    }
}
