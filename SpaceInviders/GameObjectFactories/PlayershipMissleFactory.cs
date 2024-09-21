namespace SpaceInviders.GameObjectFactories;

public class PlayershipMissleFactory : GameObjectFactory
{
    public PlayershipMissleFactory(GameSettings gameSettings) 
        : base(gameSettings)
    {
        
    }

    public override GameObject GetGameObject(GameObjectPlace objectPlace)
    {
        GameObject missle = new PlayerShipMissle()
        {
            Figure = GameSettings.PlayerMissle,
            GameObjectPlace = objectPlace,
            GameObjectType = GameObjectType.PlayerShipMissile
        };
        return missle;
    }
}