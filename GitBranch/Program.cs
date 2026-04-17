string opcaoMenu;
string[] nomes = new string[5];
string nomeUsuario;
int qtdCadastros = 0;
int maxCadastros = 5;
bool cadastroEfetivado = false;
bool continuar = true;
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
            Console.Write("Informe o nome do usuário: ");
            nomeUsuario = Console.ReadLine().ToUpper();

            for (int i = 0; i < nomes.Length; i++)
            {
                if (nomes[i] != null)
                {
                    qtdCadastros++;
                }
            }

            if (qtdCadastros == maxCadastros)
            {
                Console.WriteLine("Agenda cheia! Exclua um usuário antes de prosseguir");
                return;
            }

            for (int i = 0; i <= qtdCadastros; i++)
            {
                while (!cadastroEfetivado)
                {
                    if (nomes[i] == null)
                    {
                        nomes[i] = nomeUsuario;
                        cadastroEfetivado = true;
                        
                    }
                }
            }
            
            qtdCadastros++;

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

