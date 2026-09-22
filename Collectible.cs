class Collectible : CollidingObject
{
    public int Points{get; private set;}
    public Collectible(string name, string tag, int x, int y, int width, int height, int points) : base(name, tag, x, y, width, height)
    {
        Points = points;
    }
}