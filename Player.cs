public class Entity : CollidingObject
{
    public int Dmg{get; private set;}
    public int Hp{get; private set;}

    public Entity(string name, string tag, int x, int y, int width, int height, int dmg, int hp) : base(name, tag, x, y, width, height)
    {
        Dmg = dmg;
        Hp = hp;
    }

    public void TakeDamage(int dmg)
    {
        Hp -= dmg;
    }

    public void DealDamage(Entity entity)
    {
        entity.TakeDamage(Dmg);
    }
}
