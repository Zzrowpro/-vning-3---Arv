Player player = new Player("Mike", "Player", 0, 0, 10, 10, 100, 1000, 0);
Collectible collectible = new Collectible("Coin", "Collectible", 0, 0, 1, 1, 10);


if (player.hitBox.CheckCollision(collectible.hitBox))
{
    Console.Clear();
    player.IncreaseScore(collectible.Points);
    Console.WriteLine($"Score : {player.Score}");
}
else
{
    Console.Clear();
    Console.WriteLine("No collision detected");
}