namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Calculadora Tabajara 2025");
            Console.WriteLine("------------------------------------");

            Console.WriteLine("1 - Somar");
            Console.WriteLine("2 - Subtrair");
            Console.WriteLine("S - Sair");

            Console.WriteLine();
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            string opcaoValidada = opcao.ToUpper();

            if(opcao == "S")
            {
                return;
            }

            Console.Write("Digite o primeiro número:");
            int primeiroNumero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            int segundoNumero = Convert.ToInt32(Console.ReadLine());

            int resultado = 0;

            if (opcao == "1")
            {
                resultado = primeiroNumero + segundoNumero;
            }
            else 
            {
                resultado = primeiroNumero - segundoNumero;
            }

            Console.WriteLine(resultado);

            Console.ReadLine();

        }
    }
}
