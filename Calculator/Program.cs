using System.ComponentModel.Design;
using System.Runtime.Serialization;

double num1, num2;
int opcao = 0;

double somar()
{
    Console.Clear();
    return num1 + num2;
}

double subtrair()
{
    Console.Clear();
    return num1 - num2;
}

double multiplicar()
{
    Console.Clear();
    return num1 * num2;
}

double dividir()
{
    Console.Clear();
    return num1 / num2;
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

    return opcao = int.Parse(Console.ReadLine());
}

Console.Write("Informe o primeiro número1: ");
num1 = double.Parse(Console.ReadLine());
Console.Write("Informe o segundo número2: ");
num2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    Menu();
    switch (opcao)
    {
        default:
            Console.Clear();
            Console.WriteLine("Opção invalida.");
            break;
        case 1:
            Console.WriteLine($"Soma {num1} + {num2} = {somar()}");
            break;
        case 2:
            Console.WriteLine($"Subtração {num1} = {num2} = {subtrair()}");
            break;
        case 3:
            Console.WriteLine($"Multiplicação {num1} * {num2} = {multiplicar()}");
            break;
        case 4:
            if (num2 == 0)
            {
                Console.Clear();
                Console.WriteLine("Não é possivel dividir por 0.");
                Console.Write("Informe o segundo número: ");
                num2 = double.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine($"Divisão {num1} / {num2} = {dividir()}");
            }
            break;
        case 5:
            Console.Write("Até logo.");
            break;
    }
    Console.Write("Enter continue...");
    Console.ReadLine();
}