// Screen Sound
using System.Collections;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

string mensagemDeBoasVindas = "Boas vindas ao Screen Sound \n";
//List<string> listaDasBandas = new List<string> { "U2", "The Beatles", "Calypso"};

#region Dicionarios

Dictionary<string, List<double>> listaDasBandas = new Dictionary<string, List<double>>();
listaDasBandas.Add("U2",                    new List<double>{ 4.0, 8.6 });
listaDasBandas.Add("The Beatles",           new List<double>{ 8.32, 10, 2 });
listaDasBandas.Add("Calypso",               new List<double>{ 5.99 });
listaDasBandas.Add("Ink Spots",             new List<double>{ 7.45, 8.63, 5 });
listaDasBandas.Add("Lawfey",                new List<double>{ 2 });
listaDasBandas.Add("The Andrew Sisters",    new List<double>{ 6.8, 5.2 });
listaDasBandas.Add("Erik Satie",            new List<double>());

Dictionary<string, List<string>> alfabetoASCII = new Dictionary<string, List<string>> { 
    { "a", new List<string> { "░█████╗░", "██╔══██╗", "███████║", "██╔══██║", "██║░░██║", "╚═╝░░╚═╝" }  },
    { "b", new List<string> { "██████╗░", "██╔══██╗", "██████╦╝", "██╔══██╗", "██████╦╝", "╚═════╝░" } },
    { "c", new List<string> { "░█████╗░", "██╔══██╗", "██║░░╚═╝", "██║░░██╗", "╚█████╔╝", "░╚════╝░" } },
    { "d", new List<string> { "██████╗░", "██╔══██╗", "██║░░██║", "██║░░██║", "██████╔╝", "╚═════╝░" } },
    { "e", new List<string> { "███████╗", "██╔════╝", "█████╗░░" ,"██╔══╝░░" ,"███████╗", "╚══════╝" } },
    { "f", new List<string> { "███████╗", "██╔════╝", "█████╗░░", "██╔══╝░░", "██║░░░░░", "╚═╝░░░░░" } },
    { "g", new List<string> { "░██████╗░", "██╔════╝░", "██║░░██╗░", "██║░░╚██╗", "╚██████╔╝", "░╚═════╝░" } },
    { "h", new List<string> { "██╗░░██╗", "██║░░██║", "███████║", "██╔══██║", "██║░░██║", "╚═╝░░╚═╝" } },
    { "i", new List<string> { "██╗", "██║", "██║", "██║", "██║", "╚═╝" } },
    { "j", new List<string> { "░░░░░██╗", "░░░░░██║", "░░░░░██║", "██╗░░██║", "╚█████╔╝", "░╚════╝░" } },
    { "k", new List<string> { "██╗░░██╗", "██║░██╔╝", "█████═╝░", "██╔═██╗░", "██║░╚██╗", "╚═╝░░╚═╝" } },
    { "l", new List<string> { "██╗░░░░░", "██║░░░░░", "██║░░░░░", "██║░░░░░", "███████╗", "╚══════╝" } },
    { "m", new List<string> { "███╗░░░███╗", "████╗░████║", "██╔████╔██║", "██║╚██╔╝██║", "██║░╚═╝░██║", "╚═╝░░░░░╚═╝" } },
    { "n", new List<string> { "███╗░░██╗", "████╗░██║", "██╔██╗██║", "██║╚████║", "██║░╚███║", "╚═╝░░╚══╝" } },
    {  "o", new List<string> { "░█████╗░", "██╔══██╗", "██║░░██║", "██║░░██║", "╚█████╔╝", "░╚════╝░" } },
    { "p", new List<string> { "██████╗░", "██╔══██╗", "██████╔╝", "██╔═══╝░", "██║░░░░░", "╚═╝░░░░░" } },
    { "q", new List<string> { "░██████╗░", "██╔═══██╗", "██║██╗██║", "╚██████╔╝", "░╚═██╔═╝░", "░░░╚═╝░░░" } },
    { "r", new List<string> { "██████╗░", "██╔══██╗", "██████╔╝", "██╔══██╗", "██║░░██║", "╚═╝░░╚═╝" } },
    { "s", new List<string> { "░██████╗", "██╔════╝", "╚█████╗░", "░╚═══██╗", "██████╔╝", "╚═════╝░" } },
    { "t", new List<string> { "████████╗", "╚══██╔══╝", "░░░██║░░░", "░░░██║░░░", "░░░██║░░░", "░░░╚═╝░░░" } },
    { "u", new List<string> { "██╗░░░██╗", "██║░░░██║", "██║░░░██║", "██║░░░██║", "╚██████╔╝", "░╚═════╝░" } },
    { "v", new List<string> { "██╗░░░██╗", "██║░░░██║", "╚██╗░██╔╝", "░╚████╔╝░", "░░╚██╔╝░░", "░░░╚═╝░░░" } },
    { "w", new List<string> { "░██╗░░░░░░░██╗", "░██║░░██╗░░██║", "░╚██╗████╗██╔╝", "░░████╔═████║░", "░░╚██╔╝░╚██╔╝░", "░░░╚═╝░░░╚═╝░░" } },
    { "x", new List<string> { "██╗░░██╗", "╚██╗██╔╝", "░╚███╔╝░", "░██╔██╗░", "██╔╝╚██╗", "╚═╝░░╚═╝" } },
    { "y", new List<string> { "██╗░░░██╗", "╚██╗░██╔╝", "░╚████╔╝░", "░░╚██╔╝░░", "░░░██║░░░", "░░░╚═╝░░░" } },
    { "z", new List<string> { "███████╗", "╚════██║", "░░███╔═╝", "██╔══╝░░", "███████╗", "╚══════╝" } }
    // { "Ana", new Dictionary<string, List<int>> { { "C#", new List<int> { 8, 7, 6 } }, { "Java", new List<int> { 7, 6, 5 } }, { "Python", new List<int> { 9, 8, 8 } } }},
}; alfabetoASCII.Add(" ", new List<string> { "  " });

#endregion

void MeioTempo() { Console.Write("\n..."); Console.ReadKey(); }

void ExibirLogo(string titulo) {
    int linha = 0;
    string[] linhas = new string[6];
    string[] quebraDeLinha = new string[6];
    
    // olha se o a letra[i] do titulo é igual a letra[y] do alfabeto
    bool TemMesmaLetra(int j, int i) => alfabetoASCII.ElementAt(j).Key.Contains(titulo[i].ToString().ToLower());

    // tamanho da linha é > que 65 e se a linha NÃO contem " "
    bool TemLetraEnaoTemEspacoApos65Char(int j, int i) => (TemMesmaLetra(j,i) && (linhas[linha]?.Length>65 ? !(linhas[linha]?.IndexOf(" ", 65) > -1) : true));
        
    while (linha < 6) {
        // Pega a 1ª letra de titulo e procura ela para pegar sua copia em ASCII
        for (int i = 0; i < titulo.Length; i++) for (int j = 0; j < alfabetoASCII.Count(); j++) 
                if (TemLetraEnaoTemEspacoApos65Char(j,i))
                    linhas[linha] += alfabetoASCII[titulo[i].ToString().ToLower()][(titulo[i].ToString().Equals(" ")) ? 0 : linha];
                else if(TemMesmaLetra(j,i))
                    quebraDeLinha[linha] += alfabetoASCII[titulo[i].ToString().ToLower()][(titulo[i].ToString().Equals(" ")) ? 0 : linha];
        linha++;
    }

    foreach (string unidade in linhas) Console.WriteLine(unidade);
    foreach (string unidade in quebraDeLinha) if(unidade != null) Console.WriteLine(unidade);


    Console.WriteLine();
    Console.WriteLine(mensagemDeBoasVindas);
}

void MostrarBandas() {
InicioMostrar:
    Console.Clear();
    ExibirLogo(@"Catalogo das bandas");
    Console.WriteLine("Veja as suas bandas aqui! \n");
    Console.WriteLine("Aqui jas " + listaDasBandas.Count + " bandas! \n");

    int EncontreMaior() {
        int vlrMaior = 0;
        for (int i = 0; i < listaDasBandas.Count(); i++) {
            int vlrAtual = listaDasBandas.ElementAt(i).Key.Length;
            vlrMaior = ((vlrAtual > vlrMaior) ? vlrAtual : vlrMaior);
        }
        return vlrMaior;
    }

    void AvaliacoesLista() {
        int indentacao = EncontreMaior();
        foreach (KeyValuePair<string, List<double>> banda in listaDasBandas) {
            string msg = $"{banda.Key}: ";
            double media = (banda.Value.Count() > 0) ? (banda.Value.Aggregate((atual, proximo) => atual + proximo) / banda.Value.Count()) : 0;

            if (indentacao > banda.Key.Length) { for (int i = banda.Key.Length; i < indentacao; i++) msg += " "; }
            Console.Write(msg);
            Console.WriteLine(String.Format("[{0} Avaliações] [Média {1:0.00}]", banda.Value.Count(), media));
        }
    }

    void AvaliacoesTabela() {
        int indentacao = EncontreMaior();
        void Linhas(string x = "-", int y = 61) { Console.Write("|"); for (int i = 0; i < y; i++) Console.Write(x); Console.WriteLine("|"); } // use => somente quando for ocultar o "{corpo}", parentases.
        Linhas("=");
        Console.WriteLine(String.Format("|{0} {1," + (14 + indentacao) + "} {2,20} |", "Bandas", "Avaliações", "Média"));
        Linhas("+");
        foreach (KeyValuePair<string, List<double>> banda in listaDasBandas) {
            int tabulacao = 0;
            double media = (banda.Value.Count > 0) ? (banda.Value.Aggregate((atual, proximo) => atual + proximo) / banda.Value.Count()) : 0;
            if (indentacao > banda.Key.Length) { for (int i = banda.Key.Length; i < indentacao; i++) tabulacao++; }
            if (banda.Key != "U2") Linhas();
            Console.WriteLine(String.Format("| {0} {1," + (15 + tabulacao) + "} {2,24:0.00} |", banda.Key, banda.Value.Count(), media));
        }
        Linhas("=");
    }

    AvaliacoesLista();
    

    /*
    Console.WriteLine("Em qual formato você gostaria de ver as bandas? \nEscolha uma das opções ou digite \"0\" para voltar! \n  1 - Tabela; \n  2 - Lista;");
    int opcaoEscolhida = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine("\n\n");

    if (opcaoEscolhida == 0) return;
    else if (opcaoEscolhida == 1) { AvaliacoesTabela(); MeioTempo(); goto InicioMostrar; }
    else if (opcaoEscolhida == 2) { AvaliacoesLista(); MeioTempo(); goto InicioMostrar; }
    else { Console.WriteLine("Opção invalida! Por favor selecione uma opção!"); MeioTempo(); goto InicioMostrar; }
    */
}

void RegistrarBanda() {
    ExibirLogo(@"Registro de bandas");
    Console.WriteLine("Registre uma banda aqui!\n");
    Console.Write("Dê o nome da banda a ser registrada: ");
    string banda = Console.ReadLine()!;
    listaDasBandas.Add(banda, new List<double>());

    Console.WriteLine($"\nA {banda} foi adicionada com sucesso!");
    Console.WriteLine("\nEis aqui todas as bandas:");
    foreach(string chave in listaDasBandas.Keys) { Console.WriteLine($"  - {chave}"); }
}

void AvaliarBanda() {
    InicioAvaliacao:
    Console.Clear();
    ExibirLogo(@"Avaliacao De Bandas");
    Console.WriteLine("Avalie uma banda aqui! \n");

    // Variaveis
    KeyValuePair<string, List<Double>> PegaBanda(int i) => listaDasBandas.ElementAt(i);

    // Mostra as bandas para o usuario e pede para escolher uma
    Console.WriteLine("Qual a banda a ser avaliada? \nEscolha uma das opções ou digite \"0\" para voltar!");
    for(int i = 0; i<listaDasBandas.Count; i++) { Console.WriteLine($"  {i+1} - {PegaBanda(i).Key}"); } Console.WriteLine();
    int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();
    
    // Caso não escolha, retorna a função ou se escolher uma opção invalida/inexistente, Chama InicioAvaliacao
    if (opcao == 0) return;
    else if(opcao > listaDasBandas.Count || opcao < 0) { Console.WriteLine("Por favor escolha uma das opções!"); MeioTempo(); Console.Clear(); goto InicioAvaliacao; }

    // Espera a confirmação do usuario, quanto a sua escolha
    Console.WriteLine($"Você escolheu a {opcao}º opção, que é {PegaBanda(opcao-1).Key}. ");
    Console.WriteLine("Tem certeza? \n  0 - Sim; \n  1 - Não;"); 
    int certeza = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

    // Com base em "certeza" realiza o codigo ou volta ao inicio
    if (certeza == 0) {
        // Pede a nota a ser dada e a formata trocando "." por "," e para Double
        Console.WriteLine("Qual a nota a ser dada?");
        string avaliacao = Console.ReadLine()!;
        double avaliacaoFormatada = double.Parse((avaliacao.Contains(".")) ? avaliacao.Replace(".", ",") : avaliacao);

        if (avaliacaoFormatada < 1 || avaliacaoFormatada > 10) { Console.WriteLine("A nota deve ser de no minimo 1 e no maximo 10!"); MeioTempo(); goto InicioAvaliacao; }
        
        // Adiciona a avaliação
        listaDasBandas[PegaBanda(opcao-1).Key].Add(avaliacaoFormatada); 

        // Mostra a banda que foi avaliada
        Console.Write($"\nAvalição concluida! \n{PegaBanda(opcao-1).Key}: ");
        foreach (double nota in PegaBanda(opcao-1).Value) Console.Write($"({nota}) ");
    } else goto InicioAvaliacao;
}

//void ExibirDetalhesBandas() { } permitir mostrar tanto de uma especifica ou todas!
void AtualizarNome(int banda) {
    string bandaAntiga = listaDasBandas.ElementAt(banda - 1).Key;
    Console.WriteLine("Qual o nome você gostaria de a dar?");
    string novaBanda = Console.ReadLine()!;

    Console.WriteLine($"\n{bandaAntiga} vai ser substituido por {novaBanda} \n");

    Console.WriteLine("Tem certeza? \n  0 - Sim; \n  1 - Não;");
    int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

    if (opcao == 0) GirarChave(listaDasBandas, bandaAntiga, novaBanda);
}
void GirarChave(Dictionary<string, List<double>> dict, string velhaChave, string novaChave) {
    if (dict.ContainsKey(velhaChave)) { // Confere se existe e substitui a chave antiga pela nova
        List<double> valores = dict[velhaChave];
        dict.Remove(velhaChave);
        dict[novaChave] = valores; // dict.Add(novaChave, valores);
        Console.WriteLine("Banda atualizada com sucesso!");
    } else Console.WriteLine($"A banda {velhaChave} não foi encontrada!");
}
void GirarNota(int banda) {
    Console.WriteLine($"Qual das notas gostaria de atualizar?");

    // Variaveis
    int qtdAvalicoes = listaDasBandas.ElementAt(banda - 1).Value.Count();
    KeyValuePair<string, List<double>> bandaAtual = listaDasBandas.ElementAt(banda - 1);
    // double Nota(int i) => bandaAtual.Value[i];

    // Opções exibidas e entrada do mesmo
    for (int i = 0; i < qtdAvalicoes; i++) Console.WriteLine($"  {i + 1} - {bandaAtual.Value[i]}");
    int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();

    // Novo valor pego
    Console.WriteLine("Informe o valor a ser substituido!");
    string avaliacao = Console.ReadLine()!;

    // Formatação de "." para "," e transforma em Double
    double avaliacaoFormatada = double.Parse((avaliacao.Contains(".")) ? avaliacao.Replace(".", ",") : avaliacao);

    // Atualiza o valor na listaDasBandas
    listaDasBandas[bandaAtual.Key][opcao - 1] = avaliacaoFormatada;
    Console.WriteLine("Avalição atualizada com sucesso!");

    // Mostra a alteração feita
    Console.WriteLine($"{bandaAtual.Key} possui {qtdAvalicoes} Avalições");
    for (int i = 0; i < qtdAvalicoes; i++) Console.WriteLine($"  {i + 1} - {bandaAtual.Value[i]}");
    MeioTempo();
}

void ExibirAvaliacoes() {
    ExibirLogo("Avaliacoes");
    Console.WriteLine("Veja aqui as avaliações das bandas!");
    // Atenção é utilizada a Media Aritimética, e apenas, pois, o calculo que deve ser realizado para calcular a media das avaliações é um calculo para encontrar a nota mais comum.
    // Que é atendido apenas pela Media Aritimética.

    Console.WriteLine("Aqui jas " + listaDasBandas.Count + " bandas!");
    foreach (KeyValuePair<string, List<double>> banda in listaDasBandas) {
        // Variaveis
        string nomeDaBanda = banda.Key;
        List<double> notas = banda.Value;

        // Soma as avaliações para ser utilzado no calculo da media, senão tiver, o valor dado é "0"
        double somaAvalicoes = (banda.Value.Count()>0) ? banda.Value.Aggregate((atual, proximo)=>atual+proximo) : 0;

        // Calcula a media se houver notas, senão, o valor dado é "0"
        double media =  (notas.Count()>0) ? (somaAvalicoes / notas.Count()) : 0;

        // Formata a nota para que não tenha ","
        string formataAvaliacao(int i) => notas[i].ToString().Contains(",") ? notas[i].ToString().Replace(",", ".") : notas[i].ToString();

        // Mostra as bandas e formata a media para duas casas apos a virgula e apenas
        Console.WriteLine("\n" + nomeDaBanda + ": ");
        Console.WriteLine(String.Format("  - Media das Avaliações: {0:0.00}", media));

        // Se hover avaliações adiciona somente a string, senão, quebra a linha
        Console.Write( (notas.Count()>0) ? "  - Avaliações: " : "  - Sem avaliações;\n" );
        
        // Exibe as avalições formatadas
        for (int i = 0; i < notas.Count(); i++) Console.Write((banda.Value.Count() > i+1) ? $"({formataAvaliacao(i)}), " : $"({formataAvaliacao(i)}); \n");
        Console.WriteLine($"  - {notas.Count()} Avaliações!");
    }
}

void AtualizarRegistro() {

InicioAtualizar:
    Console.Clear();
    ExibirLogo("Atualizacao de registros");
    Console.WriteLine("Atualize aqui o nome da banda ou a nota dela! \n");

    // Mostra as bandas e pede para escolher
    Console.WriteLine("Qual das bandas você quer atualizar? \nEscolha uma das opções ou digite \"0\" para voltar!");
    for(int i=0; i<listaDasBandas.Count; i++) Console.WriteLine($"  {i+1} - {listaDasBandas.ElementAt(i).Key}; ");
    int bandaEscolhida = Console.ReadKey()!.KeyChar-'0'; Console.WriteLine();

    // Retorna se o usuario não tiver escolhido nenhuma ou volta ao inicio se a opção for invalida!
    if (bandaEscolhida == 0) return;
    else if (bandaEscolhida < 0) { Console.WriteLine("Opção invalida! \nPor favor escolha uma das opções apresentadas!"); MeioTempo(); goto InicioAtualizar; }

    // Pede que escolha o que vai atualizar
    Console.WriteLine("Atualizar o nome ou nota? \n  1 - Nome; \n  2 - Nota; \n  3 - Nome e Nota;");
    int opcao = Console.ReadKey()!.KeyChar - '0'; Console.WriteLine();
    
    // Chama a função com base na opção escolhida pelo usuario
    switch(opcao) {
        case 1: AtualizarNome(bandaEscolhida); break;
        case 2: GirarNota(bandaEscolhida); break;
        case 3: AtualizarNome(bandaEscolhida); GirarNota(bandaEscolhida); break;
    }
}

void ExibirOpcoesDoMenu() {

    Inicio:
        Console.Clear();
        ExibirLogo("Screen Sound");
    
        Console.WriteLine("Selecione uma das opções: ");
        Console.WriteLine("  1 - Registrar uma banda;");
        Console.WriteLine("  2 - Mostrar as bandas;");
        Console.WriteLine("  3 - Avaliar uma banda;");
        Console.WriteLine("  4 - Ver avaliações das bandas;");
        Console.WriteLine("  5 - Atualizar registro de uma banda;");
        Console.WriteLine("  0 - Sair;");

        int opcaoEscolhida = Console.ReadKey()!.KeyChar-'0';
        Console.Clear();

    switch (opcaoEscolhida) {
        case 1: RegistrarBanda();    MeioTempo(); goto Inicio; break;
        case 2: MostrarBandas();     MeioTempo(); goto Inicio; break;
        case 3: AvaliarBanda();      MeioTempo(); goto Inicio; break;
        case 4: ExibirAvaliacoes();  MeioTempo(); goto Inicio; break;
        case 5: AtualizarRegistro(); goto Inicio; break;
        case 0: Console.WriteLine("Tchau tchau :)"); MeioTempo(); break;
        default: Console.WriteLine("Opção inválida"); goto Inicio; break;
    }

}

ExibirOpcoesDoMenu();


// Console.WriteLine("\n\nDigite qualquer tecla para sair!");
// Console.ReadKey();

