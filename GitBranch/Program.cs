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
            return;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}