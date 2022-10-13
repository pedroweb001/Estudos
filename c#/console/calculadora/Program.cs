bem_vindo();

void bem_vindo()
{
    Console.WriteLine("Calc radix: Seja bem-vindo!");
    menu();
}

void menu()
{
    int opcao;
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine("1: Somar");
    Console.WriteLine("2: Subtrair");
    Console.WriteLine("3: Dividir");
    Console.WriteLine("4: Multiplicar");
    opcao = int.Parse(Console.ReadLine());
    valida_opcao(opcao);
}

int valida_opcao(int opc)
{
    while (opc != 1 && opc != 2 && opc != 3 && opc != 4 && opc != 5)
    {
        Console.WriteLine("Opção inválida! escolha somente:");
        Console.WriteLine("1: Somar");
        Console.WriteLine("2: Subtrair");
        Console.WriteLine("3: Subtrair");
        Console.WriteLine("4: Multiplicar");
        opc = int.Parse(Console.ReadLine());
    }
    verifica_opcao_escolhida(opc);
    return 0;
}

int verifica_opcao_escolhida(int opcaoescolhida)
{
    float valor1, valor2;
    string validacao;
    if (opcaoescolhida is 5)
{
            Console.WriteLine("Tem certeza que deseja sair? Tecle s para sim ou n para não");
            validacao = Console.ReadLine();
            while (validacao != "s" && validacao != "n")
            {
                        Console.WriteLine("Opção inválida!");
                Console.WriteLine("Tem certeza que deseja sair? Tecle s para sim ou n para não");
                validacao = Console.ReadLine();
            }
            if (validacao is "s")
            {
                sair();
            }
}
            Console.WriteLine("Digite o primeiroi valor:");
            valor1 = float.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo valor:");
valor2 = float.Parse(Console.ReadLine());
    switch (opcaoescolhida)
    {
        case 1:
            Console.WriteLine("O resultado da soma é:" + soma(valor1, valor2));
            break;
        case 2:
            Console.WriteLine("O resultado da subtração é:" + subtracao(valor1, valor2));
            break;
        case 3:
            Console.WriteLine("O resultado da divisão é:" + divicao(valor1, valor2));
            break;
        case 4:
            Console.WriteLine("O resultado da multiplicação é:" + multiplicacao(valor1, valor2));
            break;
    }
    menu();
    return 0;
}

float soma(float v1, float v2)
{
    return (v1 + v2);
}

float subtracao(float v1, float v2)
{
    return (v1 - v2);
}

float divicao(float v1, float v2)
{
    return (v1 / v2);
}

float multiplicacao(float v1, float v2)
{
    return (v1 * v2);
}

void sair()
{
    System.Environment.Exit(0);
}