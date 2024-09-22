namespace SpaceInviders;

//Singletone pattern
class GameEngine
{
    private bool _isNotOwer;
    private static GameEngine _gameEngine;
    private Scene _scene;
    private SceneRender _sceneRender;
    
    public GameEngine(){}

    public static GameEngine GetGameEngine(GameSettings gameSettings)
    {
        if (_gameEngine == null)
        {
            _gameEngine = new GameEngine(gameSettings);
        }
        return _gameEngine;
    }

    private GameEngine(GameSettings gameSettings)
    {
        _isNotOwer = true;
        _scene = Scene.getScene(gameSettings);
        _sceneRender = new SceneRender(gameSettings);
    }

    public void Run()
    {
        do
        {
            _sceneRender.Render(_scene);
            
        } while (_isNotOwer);
    }
}