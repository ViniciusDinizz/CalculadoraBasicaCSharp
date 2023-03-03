using System.ComponentModel.Design;

double n1, n2;
int opcao = 0;

void Menu()
{
    Console.Clear();
    Console.WriteLine("1-Somar");
    Console.WriteLine("2-Subtrair");
    Console.WriteLine("3-Multiplicar");
    Console.WriteLine("4-Dividir");
    Console.WriteLine("5-Sair");
    Console.Write("Escolha uma opção: ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        default:
            Console.WriteLine("Opção invalida.");
            Console.ReadLine();
            break;

            case 1: Console.WriteLine($"{n1+n2}");
            Console.ReadLine();
                break;
            case 2: Console.WriteLine($"{n1-n2}");
            Console.ReadLine();
                break;
            case 3: Console.WriteLine($"{n1*n2}");
            Console.ReadLine();
                break;
            case 4: Console.WriteLine($"{n1/n2}");
            Console.ReadLine();
                break;
            case 5:
            Console.WriteLine("Até logo.");
            Console.ReadLine();
            break;
    }
}

Console.WriteLine("Informe o primeiro número: ");
n1 = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo número: ");
n2 = double.Parse(Console.ReadLine());

while (opcao != 5)
{
    Menu();
}