namespace SpaceInviders;

public abstract class GameObject
{
    public GameObjectPlace GameObjectPlace { get; set; }
    
    public char Figure { get; set; }

    public GameObjectType GameObjectType { get; set; }
}