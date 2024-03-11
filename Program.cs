class Program
{
    static void Main()
    {
        string nome = Console.ReadLine();

        string nacionalidade = Console.ReadLine();

        int idade = int.Parse(Console.ReadLine());

        string posicao = Console.ReadLine();
        
        Jogador jogador = new Jogador(nome, nacionalidade, idade, posicao);
        
        Console.WriteLine("Jogador criado!");
        Console.WriteLine(jogador.Nome);
        Console.WriteLine(jogador.Nacionalidade);
        Console.WriteLine(jogador.Idade);
        Console.WriteLine($"Posição: {jogador.Posicao}");
    }
}