static void RemoverUsuario()
{
    Console.Write("Digite o nome do usuário que deseja remover: ");
    string nomeRemover = Console.ReadLine();
    nomes.RemoveAll(u => u.Nome.Equals(nomeRemover, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine($"Usuário {nomeRemover} removido (se existia).\n");
}