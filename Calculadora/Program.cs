namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador2 = 0;
            string[] historico = new string[100];
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
                Console.WriteLine("5 - Tabuada");
                Console.WriteLine("6 - Histórico de operações");
                Console.WriteLine("S - Sair");

                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                string opcao = Console.ReadLine();

                string opcaoValidada = opcao.ToUpper();

                if (opcaoValidada == "S")
                    break;

                else if (opcao == "5")
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("Tabuada");
                    Console.WriteLine("------------------------------------");

                    Console.Write("Digite o número: ");
                    int numeroTabuada = Convert.ToInt32(Console.ReadLine());

                    for (int contador1 = 1; contador1 <= 10; contador1++)
                    {
                        int resultadoTabuada = numeroTabuada * contador1;

                        Console.WriteLine($"{numeroTabuada} x {contador1} = {resultadoTabuada}");
                        historico[contador2] = $"Tabuada do: {numeroTabuada}";
                    }

                    Console.ReadLine();

                    continue;
                }

                else if (opcao == "6")
                {
                    foreach (var item in historico)
                    {
                        if (item is not null)
                            Console.WriteLine(item);
                    }
                    Console.ReadKey();
                    continue;
                }

                Console.Write("Digite o primeiro número:");
                int primeiroNumeroString = Convert.ToInt32(Console.ReadLine());
                decimal primeiroNumero = Convert.ToDecimal(primeiroNumeroString);

                Console.Write("Digite o segundo número:");
                int segundoNumeroString = Convert.ToInt32(Console.ReadLine());
                decimal segundoNumero = Convert.ToDecimal(segundoNumeroString);

                decimal resultado = 0;

                if (opcao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                    historico[contador2] = $"{primeiroNumero} + {segundoNumero} = {resultado}";
                }

                else if (opcao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                    historico[contador2] = $"{primeiroNumero} - {segundoNumero} = {resultado}";
                }

                else if (opcao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                    historico[contador2] = $"{primeiroNumero} X {segundoNumero} = {resultado}";
                }

                else if (opcao == "4")
                {
                    if (segundoNumero == 0)
                    {
                        Console.WriteLine("Não é possivel dividir um número por zero.");
                        Console.ReadLine();
                        continue;
                    }

                    resultado = primeiroNumero / segundoNumero;
                    historico[contador2] = $"{primeiroNumero} / {segundoNumero} = {resultado}";

                    //while (segundoNumero == 0)
                    //{
                    //    Console.Write("Não é possível dividir por 0\n Digite o segundo número novamente -> ");
                    //    segundoNumero = Convert.ToDecimal(Console.ReadLine());
                    //}
                    //resultado = primeiroNumero / segundoNumero;
                }
                    
                
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Resultado: " + resultado.ToString("F2"));
                Console.WriteLine("------------------------------------");
                
                contador2++;

                Console.Write("Deseja continuar? (S/N): ");
                string opcaoContinuar = Console.ReadLine().ToUpper();
                
                if (opcaoContinuar != "S")
                    break;

                Console.ReadLine();
            }
        }
    }
}
