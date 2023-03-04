using System.ComponentModel.Design;
using System.Runtime.Serialization;

double n1, n2;
int opcao = 0;

void somar()
{
    Console.Clear();
    Console.WriteLine($"Soma {n1} + {n2} = {n1 + n2}");
}

void subtrair()
{
    Console.Clear();
    Console.WriteLine($"Subtração {n1} - {n2} = {n1 - n2}");
}

void multiplicar()
{
    Console.Clear();
    Console.WriteLine($"Multiplicação {n1} * {n2}  = {n1 * n2}");
}

void dividir()
{
    Console.Clear();
    Console.WriteLine($"Divisão {n1} / {n2} = {n1 / n2}");
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
            somar();
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 2:
            subtrair();
            Console.Write("Enter continue...");
            Console.ReadLine();
            break;
        case 3:
            multiplicar();
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
                dividir();
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