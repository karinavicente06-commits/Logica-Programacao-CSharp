string[] nomes = new string[5];
int qtdCadastros = 0;
bool continuar = true;

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