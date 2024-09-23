namespace SpaceInviders;

public class GameObjectPlace
{
    public int XCoordinate { get; set; }
    public int YCoordinate { get; set; }

    public override bool Equals(object obj)
    {
        GameObjectPlace newObj = obj as GameObjectPlace;
        if (newObj != null && 
            this.XCoordinate == newObj.XCoordinate &&
            this.YCoordinate == newObj.YCoordinate
            )
        {
            return true;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}