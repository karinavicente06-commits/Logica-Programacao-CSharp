string[] nomes = new string[5];
int qtdCadastros = 0;
bool continuar = true;



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