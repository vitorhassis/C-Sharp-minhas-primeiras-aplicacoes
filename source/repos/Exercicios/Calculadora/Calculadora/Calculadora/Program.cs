string mensagemBoasVindas = "BOAS VINDAS À CALCULADORA!";
void ExibirLogo()
{
    Console.WriteLine(@"
    ░█████╗░░█████╗░██╗░░░░░░█████╗░██╗░░░██╗██╗░░░░░░█████╗░██████╗░░█████╗░██████╗░░█████╗░
    ██╔══██╗██╔══██╗██║░░░░░██╔══██╗██║░░░██║██║░░░░░██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗
    ██║░░╚═╝███████║██║░░░░░██║░░╚═╝██║░░░██║██║░░░░░███████║██║░░██║██║░░██║██████╔╝███████║
    ██║░░██╗██╔══██║██║░░░░░██║░░██╗██║░░░██║██║░░░░░██╔══██║██║░░██║██║░░██║██╔══██╗██╔══██║
    ╚█████╔╝██║░░██║███████╗╚█████╔╝╚██████╔╝███████╗██║░░██║██████╔╝╚█████╔╝██║░░██║██║░░██║
    ░╚════╝░╚═╝░░╚═╝╚══════╝░╚════╝░░╚═════╝░╚══════╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝
    ");
    Console.WriteLine("----------------------------------------------------------------------\n");
    Console.WriteLine(mensagemBoasVindas);
}

void MenuOpcoes(){
    Console.WriteLine("Escolha uma das operações aritméticas: ");
    Console.WriteLine("\n1)SOMA\n2)SUBTRAÇÃO\n3)MULTIPLICAÇÃO\n4)DIVISÃ0\n");
    Console.WriteLine("----------------------------------------------------------------------");
    string x = Console.ReadLine();
    int escolha = int.Parse(x);
    switch (escolha)
    {
        case 1: 
            CalculoSoma();
            break;
        case 2:
            CalculoSubtracao();
            break;
        case 3:
            CalculoMultiplicacao();
            break;
        case 4:
            CalculoDivisao();
            break;
        default: Console.WriteLine("ATENTE-SE AS OPÇÕES DISPONÍVEIS");
            break;
    }   
}

void CalculoSoma()
{
    Console.Write("Digite o primeiro valor: ");
    string x = Console.ReadLine();
    float primeiroNum = float.Parse(x);
    Console.Write("Digite o segundo valor: ");
    string y = Console.ReadLine();
    float segundoNum = float.Parse(y);
    Console.WriteLine($"A soma entre {primeiroNum} e {segundoNum} é: {primeiroNum + segundoNum}");
    RetornarMenu();
}

void CalculoSubtracao()
{
    Console.Write("Digite o primeiro valor: ");
    string x = Console.ReadLine();
    float primeiroNum = float.Parse(x);
    Console.Write("Digite um segundo valor: ");
    string y = Console.ReadLine();
    float segundoNum = float.Parse(y);
    Console.WriteLine($"A subtração entre {primeiroNum} e {segundoNum} é: {primeiroNum - segundoNum}");
    RetornarMenu();
}

void CalculoMultiplicacao()
{
    Console.Write("Digite o primeiro valor: ");
    string x = Console.ReadLine();
    float primeiroNum = float.Parse(x);
    Console.Write("Digite o segundo valor: ");
    string y = Console.ReadLine();
    float segundoNum = float.Parse(y);
    Console.WriteLine($"A multiplicação entre {primeiroNum} e {segundoNum} é: {primeiroNum * segundoNum}");
    RetornarMenu();
}

void CalculoDivisao()
{
    Console.Write("Digite o primeiro valor: ");
    string x = Console.ReadLine();
    float primeiroNum = float.Parse(x);
    Console.Write("Digite o segundo valor: ");
    string y = Console.ReadLine();
    float segundoNum = float.Parse(y);
    Console.WriteLine($"A divisão entre {primeiroNum} e {segundoNum} é: {primeiroNum / segundoNum}");
    RetornarMenu();
}

void RetornarMenu()
{
    Console.WriteLine(@"----------------------------------------------------------------------");
    Console.WriteLine("Digite alguma tecla para voltar ao MENU PRINCIPAL");
    Console.WriteLine(@"----------------------------------------------------------------------");
    Console.ReadKey();
    Console.Clear();
    ExibirLogo();
    MenuOpcoes();
}


ExibirLogo();
MenuOpcoes();

