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

                Console.Write("Informe o valor do lado X: ");
                int ladoX = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado X: ");
                int ladoY = Convert.ToInt32(Console.ReadLine());

                Console.Write("Informe o valor do lado X: ");
                int ladoZ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("____________________________________________");
                Console.WriteLine("           Valores Informados");
                Console.WriteLine("Lado X: " + ladoX);
                Console.WriteLine("Lado X: " + ladoY);
                Console.WriteLine("Lado X: " + ladoZ);

                Console.WriteLine("____________________________________________");
                Console.Write("Deseja Continuar? (s/n)");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();

                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
