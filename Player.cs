public class Player : Entity
{ 
    public int Score{get; private set;}
    public Player(string name, string tag, int x, int y, int width, int height, int dmg, int hp, int score) : base(name, tag, x, y, width, height, dmg, hp)
    {
        Score = score;
    }

    public void IncreaseScore(int score)
    {
        Score = score;
    }
}
