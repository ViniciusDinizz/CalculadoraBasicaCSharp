using System.ComponentModel.Design;
using System.Runtime.Serialization;

double n1, n2;
int opcao = 0;

double somar()
{
    Console.Clear();
    return n1  + n2;
}

double subtrair()
{
    Console.Clear();
    return n1 - n2;
}

double multiplicar()
{
    Console.Clear();
    return n1 * n2;
}

double dividir()
{
    Console.Clear();
    return n1 / n2;
}
int Menu()
{
    Console.Clear();
    Console.WriteLine("1-Somar");
    Console.WriteLine("2-Subtrair");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    return opcao;
}

Console.Write("Informe o primeiro número1: ");
n1 = double.Parse(Console.ReadLine());
Console.Write("Informe o segundo número2: ");
n2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    Menu();
    switch (opcao)
    {
        default:
            Console.Clear();
            Console.WriteLine("Opção invalida.");
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 1:
            Console.WriteLine($"Soma = {somar()}");
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 2:
            Console.WriteLine($"Soma = {subtrair()}");
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 3:
            Console.WriteLine($"Soma = {multiplicar()}");
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 4:
            if (n2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Não é possivel dividir por 0.");
                Console.Write("Informe o segundo número: ");
                n2 = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"Soma = {dividir()}");
                Console.Write("Enter continue...");
                Console.ReadLine();
            }
            break;
        case 5:
            Console.Write("Até logo.");
            Console.ReadLine();
            break;
    }
}