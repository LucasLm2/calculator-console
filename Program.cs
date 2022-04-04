
menu();

static void menu()
{
    Console.Clear();
    bool continuar = true;
    do
    {
        Console.WriteLine("Qual operação você deseja executar?");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Divisão");
        Console.WriteLine("4 - Multiplicação");
        Console.WriteLine("0 - Sair");

        Console.WriteLine("--------------");
        Console.WriteLine("Digite uma opção:");
        short opcao = short.Parse(Console.ReadLine());

        switch (opcao)
        {
            case 1: Soma(); break;
            case 2: Subtracao(); break;
            case 3: Divisao(); break;
            case 4: Multiplicacao(); break;
            case 0: continuar = false; break;
            default: menu(); break;
        }
    } while (continuar);
}

static void Soma()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor: ");
    float valorUm = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor: ");
    float valorDois = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = valorUm + valorDois;
    Console.WriteLine($"O resultado da soma é {resultado}");
    Console.ReadKey();
}

static void Subtracao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float valorUm = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float valorDois = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = valorUm - valorDois;
    Console.WriteLine($"O resultado da subtração é {resultado}");
    Console.ReadKey();
}

static void Divisao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float valorUm = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float valorDois = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = valorUm / valorDois;
    Console.WriteLine($"O resultado da divisão é {resultado}");
    Console.ReadKey();
}

static void Multiplicacao()
{
    Console.Clear();
    Console.WriteLine("Primeiro valor:");
    float valorUm = float.Parse(Console.ReadLine());

    Console.WriteLine("Segundo valor:");
    float valorDois = float.Parse(Console.ReadLine());

    Console.WriteLine("");

    float resultado = valorUm * valorDois;
    Console.WriteLine($"O resultado da multiplicação é {resultado}");
    Console.ReadKey();
}
