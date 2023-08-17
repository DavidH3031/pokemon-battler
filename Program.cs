using pokemon_battler;

Console.WriteLine("Welcome to the CLI Pokemon game!");
Console.WriteLine("Are you playing against a human or AI?\n1) Human\n2) AI");
string? gameMode = Console.ReadLine();

Console.Write("What is the name of player 1: ");
string? player1Name = Console.ReadLine();

Trainer player1 = new Trainer(player1Name!);

if (int.Parse(gameMode!) == 1)
{
    Console.Write("What is the name of player 2: ");
    string? player2Name = Console.ReadLine();

    Trainer player2 = new Trainer(player2Name!);

    StartGame game = new StartGame(player1, player2);
}