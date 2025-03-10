namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Calculadora Tabajara 2025");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("S - Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                string opcaoValidada = opcao.ToUpper();

                if (opcao == "S")
                    break;

                Console.Write("Digite o primeiro número:");
                int primeiroNumeroString = Convert.ToInt32(Console.ReadLine());
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo número:");
                int segundoNumeroString = Convert.ToInt32(Console.ReadLine());
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = 0;

                if (opcao == "1")
                    resultado = primeiroNumero + segundoNumero;
                
                else if (opcao == "2")
                    resultado = primeiroNumero - segundoNumero;
                
                else if (opcao == "3")
                    resultado = primeiroNumero * segundoNumero;
              
                else if (opcao == "4")
                    resultado = primeiroNumero / segundoNumero;
                
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("------------------------------------");

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                
                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();
            }
        }
    }
}