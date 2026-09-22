public class Entity : CollidingObject // Instead of having player and enemy in different classes we can just use a single entity class
{
    public int Dmg{get; private set;}
    public int Hp{get; private set;}

    public Entity(string name, string tag, int x, int y, int width, int height, int dmg, int hp) : base(name, tag, x, y, width, height)
    {
        Dmg = dmg;
        Hp = hp;
    }

    public void TakeDamage(int dmg) //Entity takes damage
    {
        Hp -= dmg;
    }

    public void DealDamage(Entity entity) //Entity deals damage
    {
        entity.TakeDamage(Dmg);
    }
}
