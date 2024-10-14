string ExibirMensagemDeBoasVindas = ("Bem-vindo ao sistema de estoque!");
Dictionary<string, List<int>> EstoqueItens = new Dictionary<string, List<int>>();

void ExibirLogo()
{
    Console.WriteLine(@"
███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝
");
    Console.WriteLine(ExibirMensagemDeBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("Escolha uma das opções abaixo: ");
    Console.WriteLine("1-Adicionar itens ao estoque\n2-Verificar estoque de itens");
    string x = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(x);

    switch (opcaoEscolhida)
    {
        case 1: AdicionarItens();
            break;
        case 2: VerificarEstoque();
            break;
        default: Console.WriteLine("Atente-se as opções de escolha!");
            break;
    }
}

void AdicionarItens()
{
    Console.Clear();
    Console.WriteLine(@"
░█████╗░██████╗░██╗░█████╗░██╗░█████╗░███╗░░██╗░█████╗░██████╗░  ██╗████████╗███████╗███╗░░██╗░██████╗
██╔══██╗██╔══██╗██║██╔══██╗██║██╔══██╗████╗░██║██╔══██╗██╔══██╗  ██║╚══██╔══╝██╔════╝████╗░██║██╔════╝
███████║██║░░██║██║██║░░╚═╝██║██║░░██║██╔██╗██║███████║██████╔╝  ██║░░░██║░░░█████╗░░██╔██╗██║╚█████╗░
██╔══██║██║░░██║██║██║░░██╗██║██║░░██║██║╚████║██╔══██║██╔══██╗  ██║░░░██║░░░██╔══╝░░██║╚████║░╚═══██╗
██║░░██║██████╔╝██║╚█████╔╝██║╚█████╔╝██║░╚███║██║░░██║██║░░██║  ██║░░░██║░░░███████╗██║░╚███║██████╔╝
╚═╝░░╚═╝╚═════╝░╚═╝░╚════╝░╚═╝░╚════╝░╚═╝░░╚══╝╚═╝░░╚═╝╚═╝░░╚═╝  ╚═╝░░░╚═╝░░░╚══════╝╚═╝░░╚══╝╚═════╝░
");

    string escolha = "s";
    //igual aprendi na faculdade. Pra voce nao precisar verificar se for S ou s, voce ja converte em minusculo
    while(escolha.ToLower() == "s") 
    {
        Console.WriteLine("Digite o item que você deseja adicionar ao estoque: ");
        string nomeItem = Console.ReadLine()!;

        if (!EstoqueItens.ContainsKey(nomeItem))
        {
            EstoqueItens.Add(nomeItem, new List<int>());
            Console.WriteLine($"Informe a quantidade de {nomeItem} para o estoque: ");
            string x = Console.ReadLine()!;
            int quantidadeItem = int.Parse(x);
            EstoqueItens[nomeItem].Add(quantidadeItem);
            Console.WriteLine($"{quantidadeItem} quantidades do item {nomeItem} foram registradas ao estoque! ");  
        } else
        {
            Console.WriteLine("Item já registrado em estoque!");
        }
        Console.Write("Deseja continuar ou voltar ao menu? (s/n): ");
        escolha = Console.ReadLine()!; //aq n coloca string escolha, pq ela ja foi declarada fora do escopo. Se colocarmos string escolha = Console.ReadLine() estaríamos redeclarando-a
    }
    
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}


void VerificarEstoque()
{
    Console.Clear();
    Console.WriteLine(@"
███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝
");
    string escolha = "s";
    while (escolha.ToLower() == "s")
    {
        Console.Write("Digite o nome do produto que deseja verificar no estoque: ");
        string nomeItem = Console.ReadLine()!;
        if (EstoqueItens.ContainsKey(nomeItem))
        {
            int quantidadeTotal = EstoqueItens[nomeItem].Sum();
            Console.WriteLine($"{nomeItem} = {quantidadeTotal} unidades no estoque.");
        }
        else
        {
            Console.WriteLine($"{nomeItem} não encontrado no estoque. Tente novamente!");
            Console.WriteLine("Digite alguma tecla para voltar ao menu principal");
            Console.ReadKey();
            Thread.Sleep(4000);
            Console.Clear();
            ExibirOpcoesMenu();
        }

        Console.WriteLine("Deseja fazer uma verificação ao estoque novamente? (s/n) ");
        escolha = Console.ReadLine()!;
    }

    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

ExibirOpcoesMenu();



