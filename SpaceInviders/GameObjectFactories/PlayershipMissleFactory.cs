namespace SpaceInviders.GameObjectFactories;

public class PlayershipMissleFactory : GameObjectFactory
{
    public PlayershipMissleFactory(GameSettings gameSettings) 
        : base(gameSettings)
    {
        
    }

    public override GameObject GetGameObject(GameObjectPlace objectPlace)
    {
        GameObjectPlace misslePlase =
            new GameObjectPlace()
            {
                XCoordinate = objectPlace.XCoordinate,
                YCoordinate = objectPlace.YCoordinate - 1
            };
        GameObject missle = new PlayerShipMissle()
        {
            Figure = GameSettings.PlayerMissle,
            GameObjectPlace = misslePlase,
            GameObjectType = GameObjectType.PlayerShipMissile
        };
        return missle;
    }
}