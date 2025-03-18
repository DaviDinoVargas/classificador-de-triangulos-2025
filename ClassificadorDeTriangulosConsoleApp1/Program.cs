namespace ClassificadorDeTriangulosConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirCabecalho();
            int ladoX = LerLado("X");
            int ladoY = LerLado("Y");
            int ladoZ = LerLado("Z");

            // exibir valores
            ExibirValoresInformado(ladoX, ladoY, ladoZ);

            bool MedidasFormamTrianguloValido = 
                ClassificadorDeTriangulos.MedidasFormamTrianguloValido(ladoX, ladoY, ladoZ);


            if (MedidasFormamTrianguloValido)
            {
                Console.WriteLine("Triângulo é válido");
                string tipoTriangulo = ClassificadorDeTriangulos.ClassificarTriangulo(ladoX, ladoY, ladoZ);
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
    static void ExibirCabecalho()
    {
        Console.Clear();
        Console.WriteLine("____________________________________________");
        Console.WriteLine("       Classificador de Triângulos");
        Console.WriteLine("____________________________________________");
    }

    static int LerLado(string nomeLado)
    {

        int valor;

        while (true)
        {
            Console.Write($"Informe o valor do lado {nomeLado}: ");
            bool conseguiuConverter = int.TryParse(Console.ReadLine(), out valor);
            if (conseguiuConverter)
                break;
        }
        return valor;
    }
    static void ExibirValoresInformado(int ladoX, int ladoY, int ladoZ)
    {
        Console.WriteLine("____________________________________________");
        Console.WriteLine("           Valores Informados");
        Console.WriteLine("Lado X: " + ladoX);
        Console.WriteLine("Lado Y: " + ladoY);
        Console.WriteLine("Lado Z: " + ladoZ);
        Console.WriteLine("____________________________________________");
    }


}
