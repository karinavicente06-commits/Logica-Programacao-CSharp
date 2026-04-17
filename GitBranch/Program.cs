string opcaoMenu;
string[] nomes = new string[5];
string nomeUsuario;
int qtdCadastros = 0;
int maxCadastros = 5;
string confirmacao;

Console.WriteLine("Bem vindo, usuário");
Console.WriteLine("1. Cadastrar"); // Gabriel
Console.WriteLine("2. Listar todos os cadastros"); // Karina
Console.WriteLine("3. Buscar conta"); // Lucas
Console.WriteLine("4. Excluir conta"); // Charles
Console.WriteLine("5. Encerrar/Sair");
Console.Write("Informe a opção: ");
opcaoMenu = Console.ReadLine();

while (true)
{
    switch (opcaoMenu)
    {
        case "1":
            do
            {
                Console.Write("Informe o nome do usuário: ");
                nomeUsuario = Console.ReadLine().ToUpper();
                Console.Write($"Confirma cadastro do usuário '{nomeUsuario}'? (S/N): ");
                confirmacao = Console.ReadLine().ToUpper();
            } while (confirmacao != "S");

            bool cadastrado = false;

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] == null)
                {
                    nomes[i] = nomeUsuario;
                    qtdCadastros++;
                    Console.WriteLine("Cadastrado com sucesso!");
                    cadastrado = true;
                    break;
                }
            }

            if (!cadastrado)
            {
                Console.WriteLine("Agenda cheia! Exclua um usuário antes de prosseguir");
            }
            break;

        case "2":
            Console.WriteLine("\n--- RELATÓRIO DE USUÁRIOS ---");
            if (qtdCadastros == 0)
            {
                Console.WriteLine("Nenhum registro encontrado.");
            }
            else
            {
                for (int i = 0; i < qtdCadastros; i++)
                {
                    Console.WriteLine($"Posição {i} : {nomes[i]}");
                }
            }
            break;
        case "3":
            Console.Write("Digite um nome para busca: ");
            string busca = Console.ReadLine().ToUpper();

            if (nomes.Contains(busca))
            {
                Console.WriteLine("Nome informado encontrado! ");
            }
            else
            {
                Console.WriteLine("Nome informado não encontrado!");
            }
            break;
        case "4":
            break;
        case "5":
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}