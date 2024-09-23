using SpaceInviders.GameObjectFactories;

namespace SpaceInviders;

public class Scene
{
    public List<GameObject> swarm;
    public List<GameObject> ground;
    public GameObject playerShip;
    public List<GameObject> playerShipMissle;
    private GameSettings _gameSettings;

    //Singletone pattern
    private static Scene _scene;
    private Scene() { }

    private Scene(GameSettings gameSettings)
    {
        _gameSettings = gameSettings;
        swarm = new AlienShipFactory(_gameSettings).GetSwarm();
        ground = new GroundFactory(_gameSettings).GetGround();
        playerShip = new PlayerShipFactory(_gameSettings).GetGameObject();
        playerShipMissle = new List<GameObject>(); 

    }

    public static Scene getScene(GameSettings gameSettings)
    {
        if (_scene == null)
        {
            _scene = new Scene(gameSettings);
        }

        return _scene;
    }
    
}