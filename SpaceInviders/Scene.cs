namespace SpaceInviders;

class Scene
{
    private List<GameObject> _swarm;
    private List<GameObject> _ground;
    private GameObject _playerShip;
    private List<GameObject> _playerShipMissle;

    //Singletone pattern
    private static Scene _scene;
    private Scene() { }

    private Scene(GameSettings gameSettings)
    {
        
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