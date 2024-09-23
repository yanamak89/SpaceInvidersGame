using SpaceInviders.GameObjectFactories;

namespace SpaceInviders;

//Singletone pattern
class GameEngine
{
    private bool _isNotOwer;
    private static GameEngine _gameEngine;
    private Scene _scene;
    private SceneRender _sceneRender;
    private GameSettings _gameSettings;
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
        _gameSettings = gameSettings;
        _isNotOwer = true;
        _scene = Scene.getScene(gameSettings);
        _sceneRender = new SceneRender(gameSettings);
    }

    public void Run()
    {
        int swarmMoveCounter = 0;
        int playerMissileCounter = 0;
        do
        {
            _sceneRender.Render(_scene);
            Thread.Sleep(_gameSettings.GameSpeed);

            _sceneRender.ClearScreen();
            
            if (swarmMoveCounter == _gameSettings.SwarmSpeed)
            {
                CalculateSwarmMove();
                swarmMoveCounter = 0;
            }

            swarmMoveCounter++;

            if (playerMissileCounter == _gameSettings.PlayerMissleSpeed)
            {
                CalculateMissileMove();
                playerMissileCounter = 0;
            }

            playerMissileCounter++;

        } while (_isNotOwer);

        Console.ForegroundColor = ConsoleColor.Red;
        _sceneRender.RenderGameOver();
    }
    
    public void CalulateMovePlayerShipLeft()
    {
        if (_scene.playerShip.GameObjectPlace.XCoordinate > 1)
        {
            _scene.playerShip.GameObjectPlace.XCoordinate--;
        }
    }
    
    public void CalulateMovePlayerShipRight()
    {
        if (_scene.playerShip.GameObjectPlace.XCoordinate < _gameSettings.ConsoleWidth)
        {
            _scene.playerShip.GameObjectPlace.XCoordinate++;
        }
    }

    public void CalculateSwarmMove()
    {
        for (int i = 0; i < _scene.swarm.Count; i++)
        {
            GameObject alienShip = _scene.swarm[i];
            alienShip.GameObjectPlace.YCoordinate++;
            if (alienShip.GameObjectPlace.YCoordinate == 
                _scene.playerShip.GameObjectPlace.YCoordinate)
            {
                _isNotOwer = false;
            }
        }
    }

    public void Shot()
    {
        PlayershipMissleFactory missleFactory = 
            new PlayershipMissleFactory(_gameSettings);
        GameObject missle = missleFactory.GetGameObject(_scene.playerShip.GameObjectPlace);
        _scene.playerShipMissle.Add(missle);
        //Для Windows
        //Console.Beep(1000, 200);
        
        // Викликаємо системний звук на Mac
        Console.Write("\a"); // Це виведе звуковий сигнал
    }

    public void CalculateMissileMove()
    {
        if (_scene.playerShipMissle.Count == 0)
        {
            return;
        }

        for (int x = 0; x < _scene.playerShipMissle.Count; x++)
        {
            GameObject missile = _scene.playerShipMissle[x];

            if (missile.GameObjectPlace.YCoordinate == 1)
            {
                _scene.playerShipMissle.RemoveAt(x);
            }

            missile.GameObjectPlace.YCoordinate--;

            for (int i = 0; i < _scene.swarm.Count; i++)
            {
                GameObject alianShip = _scene.swarm[i];
                if (missile.GameObjectPlace.Equals(alianShip.GameObjectPlace))
                {
                    _scene.swarm.RemoveAt(i);
                    _scene.playerShipMissle.RemoveAt(x);
                    break;
                }
            }
        }
    }
}