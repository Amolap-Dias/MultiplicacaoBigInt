using System.Numerics;

namespace MultiplicacaoBigInt
{
    public class Program
    {
        public static void Main(string[] args)
        {

            BigInteger fator1, fator2, produto;

            void multiplicacaoBigInt()
            {
                Console.WriteLine("Digite um número: \n");
                fator1 = BigInteger.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite um número: \n");
                fator2 = BigInteger.Parse(Console.ReadLine());

                produto = fator1 * fator2;

                Console.WriteLine("\nResultado da multiplicação: \n" + produto);

            }

            multiplicacaoBigInt();

        }

    }
}