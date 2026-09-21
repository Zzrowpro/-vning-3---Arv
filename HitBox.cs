public class HitBox 
{ //Decided to use the hit box class as if say it was a rigibody/transform component. // Instead om gameobject or colliding object having the transforms and scale it is Hitbox that has it and those guys have a hitbox object in them. 
    protected int X{get; private set;} = 0;
    protected int Y{get; private set;} = 0;
    protected int Width{get; private set;}
    protected int Height{get; private set;}
    public HitBox(int x, int y, int width, int height)
    {
        Y = y;
        X = x;
        Width = width;
        Height = height;
    }

    public HitBox(int x, int y) //What if you dont want a hitbox and want only a position marker.
    {
        Y = y;
        X = x;
    }

    public bool CheckCollision(HitBox box)
    {
        return X < box.X + box.Width &&
            X + Width > box.X &&
            Y < box.Y + box.Height && 
            Y + Height  > box.Y;
    }

    public void Move(string name, int x, int y)
    {
        X = x;
        Y = y;
        Console.WriteLine($"{name} has moved to ({x}, {y})");
    }

    public void Scale(string name, int width, int height) //Change Scale of the hitbox
    {
        Width = width;
        Height = height;
        Console.WriteLine($"{name}'s width and height is now : {width}, {height}");
    }

    public void ScaleWidth(string name, int width) //Scale individually
    {
        Width = width;
        Console.WriteLine($"{name}'s width is now : {width}");
    }
    public void ScaleHeight(string name, int height)
    {
        Height = height;
        Console.WriteLine($"{name}'s height is now : {height}");
    }
}
