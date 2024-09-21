using SpaceInviders.GameObjectFactories;

namespace SpaceInviders;

class Scene
{
    private List<GameObject> _swarm;
    private List<GameObject> _ground;
    private GameObject _playerShip;
    private List<GameObject> _playerShipMissle;
    private GameSettings _gameSettings;

    //Singletone pattern
    private static Scene _scene;
    private Scene() { }

    private Scene(GameSettings gameSettings)
    {
        _gameSettings = gameSettings;
        _swarm = new AlienShipFactory(_gameSettings).GetSwarm();
        _ground = new GroundFactory(_gameSettings).GetGround();
        _playerShip = new PlayerShipFactory(_gameSettings).GetGameObject();
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