//Screen Sound 

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound!";
//List<string> bandas = new List <string> {"aaa", "bbbb"};

Dictionary<string, List<int>> BandasRegistradas = new Dictionary<string, List<int>>(); //lista vazia
BandasRegistradas.Add("Linkin Park", new List<int> { 10, 8, 6 });
BandasRegistradas.Add("Beatles", new List<int>()); 


void ExibirLogo() //pascal case, primeira letra da palavra de uma nomenclatura de funcao começa com maiúscula
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para REGISTRAR UMA BANDA");
    Console.WriteLine("Digite 2 para MOSTRAR TODAS AS BANDAS");
    Console.WriteLine("Digite 3 para AVALIAR UMA BANDA");
    Console.WriteLine("Digite 4 para EXIBIR A MÉDIA DA BANDA");
    Console.WriteLine("Digite -1 para SAIR DO MENU");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBandas(); 
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4: Console.WriteLine("Voce escolheu a opcao " + opcaoEscolhida);
            break;
        case -1: Console.WriteLine("Tchau :)");
            break;
        default: Console.WriteLine("Opção inválida");
            break;
    }
}

void RegistrarBandas() //funcao do tipo void é funcao que nao retorna nada, ou seja, o procedimento la em portugol
{
    Console.Clear(); //limpa todo o conteudo do console;
    Console.WriteLine(@"

██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░  ██████╗░███████╗
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗  ██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝██║░░██║  ██║░░██║█████╗░░
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║  ██║░░██║██╔══╝░░
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝  ██████╔╝███████╗
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░  ╚═════╝░╚══════╝

██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");
    ExibirTituloDaOpcao("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    BandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.Write($"A banda {nomeDaBanda} foi registrado com sucesso!");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    Console.WriteLine(@"
██████╗░░█████╗░███╗░░██╗██████╗░░█████╗░░██████╗
██╔══██╗██╔══██╗████╗░██║██╔══██╗██╔══██╗██╔════╝
██████╦╝███████║██╔██╗██║██║░░██║███████║╚█████╗░
██╔══██╗██╔══██║██║╚████║██║░░██║██╔══██║░╚═══██╗
██████╦╝██║░░██║██║░╚███║██████╔╝██║░░██║██████╔╝
╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═════╝░╚═╝░░╚═╝╚═════╝░

██████╗░███████╗░██████╗░██╗░██████╗████████╗██████╗░░█████╗░██████╗░░█████╗░░██████╗
██╔══██╗██╔════╝██╔════╝░██║██╔════╝╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝
██████╔╝█████╗░░██║░░██╗░██║╚█████╗░░░░██║░░░██████╔╝███████║██║░░██║███████║╚█████╗░
██╔══██╗██╔══╝░░██║░░╚██╗██║░╚═══██╗░░░██║░░░██╔══██╗██╔══██║██║░░██║██╔══██║░╚═══██╗
██║░░██║███████╗╚██████╔╝██║██████╔╝░░░██║░░░██║░░██║██║░░██║██████╔╝██║░░██║██████╔╝
╚═╝░░╚═╝╚══════╝░╚═════╝░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░
");
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas ");
    /*for (int i = 0; i<bandas.Count; i++)
    {
        Console.WriteLine($"banda: {bandas[i]}");
    }*/
    foreach (string banda in BandasRegistradas.Keys)
    {
        Console.WriteLine($"banda: {banda}");
    }
    Console.WriteLine("\nDigite Alguma tecla para voltar ao Menu Principal: ");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void ExibirTituloDaOpcao(string titulo)//titulo com asteriscos
{ 
    int quantidadeDeLetras = titulo.Length; //pega o tamanho do titulo, uma variavel que vai receber uma frase
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras,'*'); //preenchendo uma string vazia, a partir da esquerda, de acordo com o tamanho do titulo. Vai preencher o que? asteriscos
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos+"\n");
}


void AvaliarUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar uma banda!");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDaBanda = Console.ReadLine()!;
    if (BandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Digite uma nota para a banda {nomeDaBanda}: ");
        int notaDaBanda = int.Parse(Console.ReadLine()!);
        BandasRegistradas[nomeDaBanda].Add(notaDaBanda);
        Console.WriteLine($"\nA nota {notaDaBanda} foi registrada com sucesso para a banda {nomeDaBanda}!");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"\nbanda {nomeDaBanda} não foi encontrada. Tente novamente!");
        Console.WriteLine("Digite uma tecla qualquer para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
MostrarBandasRegistradas();

