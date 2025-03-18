namespace ClassificadorDeTriangulosConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("____________________________________________");
                Console.WriteLine("       Classificador de Triângulos");
                Console.WriteLine("____________________________________________");

                int ladoX;

                while (true)
                {
                    Console.Write("Informe o valor do lado X: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoX);
                    if (conseguiuConverter)
                        break;
                }

                int ladoY;

                while (true)
                {
                    Console.Write("Informe o valor do lado y: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoY);
                    if (conseguiuConverter)
                        break;
                }

                int ladoZ;

                while (true)
                {
                    Console.Write("Informe o valor do lado X: ");
                    bool conseguiuConverter = int.TryParse(Console.ReadLine(), out ladoZ);
                    if (conseguiuConverter)
                        break;
                }

                Console.WriteLine("____________________________________________");
                Console.WriteLine("           Valores Informados");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado X: " + ladoY);
                Console.WriteLine("Lado X: " + ladoZ);

                bool medidasTrianguloValidas =
                    ladoX + ladoY > ladoZ && ladoX + ladoZ > ladoY && ladoZ + ladoY > ladoX;
                if (medidasTrianguloValidas == true)
                {
                    Console.WriteLine("Triângulo é válido");
                    string tipoTriangulo = "Não classificado";
                    if (ladoX == ladoY && ladoY == ladoZ)
                        tipoTriangulo = "Equilátero";
                    else if (ladoX != ladoY && ladoY != ladoZ && ladoX != ladoZ)
                        tipoTriangulo = "Escaleno";
                    else
                        tipoTriangulo = "Isóceles";
                    Console.WriteLine($"{tipoTriangulo}");
                }
                else
                    Console.WriteLine("Triângulo é inválido");

                Console.WriteLine("____________________________________________");
                Console.Write("Deseja Continuar? (s/n)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
