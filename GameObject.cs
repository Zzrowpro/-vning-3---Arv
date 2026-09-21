
public class GameObject
{
    public string Name{get; private set;}
    public string Tag{get; private set;}
    public GameObject(string name, string tag)
    {
        Name = name;
        Tag = tag;
    }
}
