namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora Tabajara 2025");

            Console.Write("Digite o primeiro número:");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            int resultado = primeiroNumero + segundoNumero;

            Console.WriteLine(resultado);

            Console.ReadLine();

        }
    }
}
