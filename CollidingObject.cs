public class CollidingObject : GameObject
{
    public HitBox hitBox{get; private set;}//Call collidingobject.hitbox to access hit box stuff

    public CollidingObject(string name, string tag, int x, int y, int width, int height) : base(name, tag)
    {
        hitBox = new HitBox(x,y,width,height);
    }
}
