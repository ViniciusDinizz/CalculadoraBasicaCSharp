internal class Program
{
    private static void Main(string[] args)
    {
        float N1, N2;
        Console.WriteLine("Digite um número: ");
        N1 = float.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        N2 = float.Parse(Console.ReadLine());
        Console.WriteLine("A soma dos valores é: " + (N1 + N2));
        Console.WriteLine("A subtração dos valores é: " + (N1 - N2));
        Console.WriteLine("A multiplicação dos valores é: " + (N1 * N2));
        if (N2 == 0)
        {
            Console.WriteLine("Ímpossivel dividir por zero!");
        }
        else
        {
            Console.WriteLine("A divisão enre o valores vale: " + (N1 / N2));
        }
    }
}