using CadastroPessoa.Classes;

Console.Clear();

Console.WriteLine(@$"
##########################################
|   Bem vindo ao sistema de cadastro de  |
|      Pessoas Físicas e Jurídicas       |
##########################################
");

Barracarregamento ("Carregando", 600);

/*Console.BackgroundColor = ConsoleColor.DarkCyan;
Console.ForegroundColor = ConsoleColor.DarkYellow;

Console.WriteLine($"Carregando");

for (var i = 0; i < 6; i++)
{
    Console.Write(".");
    Thread.Sleep(500);
}

Console.ResetColor();*/

string? opcao;

do
{
    Console.Clear();
    Console.WriteLine(@$"
 ===================================
|   Escolha uma das opções abaixo   |
|-----------------------------------|
|       1 - Pessoa Física           |
|       2 - Pessoa Jurídica         |
|       0 - Sair                    |
 ===================================
");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.Clear();
            PessoaFisica novaPf = new PessoaFisica();
            PessoaFisica metodoPF = new PessoaFisica();
            endereco novoEnd = new endereco();

            novaPf.Nome = "novo nome";
            novaPf.dataNasc = new DateTime(2000, 01, 01);
            novaPf.Cpf = "1234567890";
            novaPf.rendimento = 5000.5f;

            novoEnd.logradouro = "Alameda";
            novoEnd.numero = 539;
            novoEnd.Complemento = "apto 423";
            novoEnd.endComercial = true;

            novaPf.Endereco = novoEnd;

            Console.WriteLine(@$"

        Nome: {novaPf.Nome}
        CPF: {novaPf.Cpf}
        Endereço: {novaPf.Endereco.logradouro}, {novaPf.Endereco.numero}
        Rendimento: {novaPf.rendimento.ToString("C")}
        Taxa de imposto R$: {metodoPF.PagarImposto(novaPf.rendimento).ToString("C")}

        ");

            //Console.WriteLine(novaPf.Nome);
            //Console.WriteLine(novaPf.Nome);

            //Console.WriteLine($"Nome: {novaPf.Nome} Rendimento: {novaPf.rendimento}");

            //Console.WriteLine($"{metodoPF.ValidarDataNasc("01/01/2000")}");

            Console.WriteLine($"Enter para continuar");
            Console.ReadLine();

            break;

        case "2":
            Console.Clear();
            PessoaJuridica metodoPj = new PessoaJuridica();
            PessoaJuridica novaPj = new PessoaJuridica();
            endereco endPJ = new endereco();

            novaPj.Nome = "Nome Pj";
            novaPj.razaoSocial = "Razão social Pj";
            novaPj.Cnpj = "00.000.000/0001-00";
            novaPj.rendimento = 10000.5f;

            endPJ.logradouro = "Rua";
            endPJ.numero = 5333;
            endPJ.Complemento = "frente 4beer";
            endPJ.endComercial = true;

            novaPj.Endereco = endPJ;

            Console.WriteLine(@$"
Nome: {novaPj.Nome}
Razão Social: {novaPj.razaoSocial}
CNPJ: {novaPj.Cnpj}
CNPJ Válido: {(metodoPj.ValidarCnpj(novaPj.Cnpj)? "Sim": "Não")}
Rendimento: {novaPj.rendimento.ToString("C")}
Taxa de imposto R$: {metodoPj.PagarImposto(novaPj.rendimento).ToString("C")}
");
    




            //Console.WriteLine(metodoPj.ValidarCnpj("00000000000001"));

            Console.WriteLine($"Enter para continuar");
            Console.ReadLine();
            break;



        case "0":

            Console.Clear();
            Console.WriteLine($"Obrigado por utilizar o sistema");
           // Console.WriteLine($"Finalizando atendimento");

            Barracarregamento ("Finalizando", 400 );
            
            /*for (var i = 0; i < 6; i++)
            {
                Console.Write(".");
                Thread.Sleep(500);
            }

            Console.ResetColor();*/

            break;

        default:
            Console.Clear();
            Console.WriteLine($"Digite um opção válida!!!");
            Console.WriteLine($"Enter para continuar");
            Console.ReadLine();
            break;

    }
} while (opcao != "0");


static void Barracarregamento(string texto, int tempo)
{
    Console.BackgroundColor = ConsoleColor.DarkCyan;
    Console.ForegroundColor = ConsoleColor.DarkYellow;

    Console.WriteLine(texto);

    for (var i = 0; i < 6; i++)
    {
        Console.Write(".");
        Thread.Sleep(tempo);
    }

    Console.ResetColor();
}

























