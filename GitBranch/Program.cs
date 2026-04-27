



string opcaoMenu;
int maxCadastros = 5;
string[] nomes = new string[maxCadastros];
string nomeUsuario;
int qtdCadastros = 0;
string confirmacao;
bool encerrar = false;

Console.WriteLine("Bem vindo, usuário");

while (!encerrar)
{
    Console.WriteLine("=========== MENU ===========");
    Console.WriteLine("1. Cadastrar"); // Gabriel
    Console.WriteLine("2. Listar todos os cadastros"); // Karina
    Console.WriteLine("3. Buscar conta"); // Lucas
    Console.WriteLine("4. Excluir conta"); // Charles
    Console.WriteLine("5. Encerrar/Sair");
    Console.Write("Informe a opção: ");
    opcaoMenu = Console.ReadLine();

    switch (opcaoMenu)
    {
        case "1":
            do
            {
                if (qtdCadastros >= maxCadastros)
                {
                    Console.WriteLine("Agenda cheia! Exclua um usuário antes de prosseguir");
                    break;
                }

                Console.Write("Informe o nome do usuário: ");
                nomeUsuario = Console.ReadLine().ToUpper();

                if (nomeUsuario == "")
                {
                    Console.WriteLine("Nome para usuário inválido!");
                    break;
                }

                Console.Write($"Confirma cadastro do usuário '{nomeUsuario}'? (S/N): ");
                confirmacao = Console.ReadLine().ToUpper();

                if (confirmacao == "S")
                {
                    nomes[qtdCadastros] = nomeUsuario;
                    qtdCadastros++;
                    Console.WriteLine("Cadastrado com sucesso!");
                    break;
                }
            } while (confirmacao.ToUpper() == "N");

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
                    if (nomes[i] != null)
                    { 
                        Console.WriteLine($"Posição {i} : {nomes[i]}");
                    }
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
            Console.Write("Digite o nome do usuário que deseja remover: ");
            string nomeRemover = Console.ReadLine().ToUpper();

            int indice = -1;

            for (int i = 0; i < qtdCadastros; i++)
            {
                if (nomes[i] == nomeRemover)
                {
                    indice = i;
                    break;
                }
            }

            if (indice != -1)
            {
                for (int i = indice; i < qtdCadastros - 1; i++)
                {
                    nomes[i] = nomes[i + 1];
                }

                nomes[qtdCadastros - 1] = null;

                qtdCadastros--;

                Console.WriteLine("Usuário removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }

            break;
        case "5":
            encerrar = true;
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }

}