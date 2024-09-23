using System.Text;

namespace SpaceInviders;

public class SceneRender
{
    private int _screenWidth;
    private int _screenHight;
    private char[,] _screenMatrix;

    public SceneRender(GameSettings gameSettings)
    {
        _screenWidth = gameSettings.ConsoleWidth;
        _screenHight = gameSettings.ConsoleHeight;
        _screenMatrix = new char[gameSettings.ConsoleHeight, gameSettings.ConsoleWidth];

        Console.WindowHeight = gameSettings.ConsoleHeight;
        Console.WindowWidth = gameSettings.ConsoleWidth;
        
        Console.CursorVisible = false;
        Console.SetCursorPosition(0, 0);
    }

    public void Render(Scene scene)
    {
        Console.Clear();
        ClearScreen();
        
        Console.SetCursorPosition(0, 0);
        AddListRendering(scene.swarm);
        AddListRendering(scene.ground);
        AddListRendering(scene.playerShipMissle);
    
        AddGameObjectForRendering(scene.playerShip);

        StringBuilder stringBuilder = new StringBuilder();
        for (int y = 0; y < _screenHight; y++) 
        {
            for (int x = 0; x < _screenWidth; x++) 
            {
                stringBuilder.Append(_screenMatrix[y, x]);
            }
            stringBuilder.Append(Environment.NewLine);
        }

        Console.WriteLine(stringBuilder.ToString());
        Console.SetCursorPosition(0, 0);
    }
    
    public void AddGameObjectForRendering(GameObject gameObject)
    {
        if (gameObject.GameObjectPlace.YCoordinate < _screenMatrix.GetLength(0) &&
            gameObject.GameObjectPlace.XCoordinate < _screenMatrix.GetLength(1))
        {
            _screenMatrix[gameObject.GameObjectPlace.YCoordinate, gameObject.GameObjectPlace.XCoordinate] =
                gameObject.Figure;
        }
        else
        {
            ; //_screenMatrix[gameObject.GameObjectPlace.YCoordinate, gameObject.GameObjectPlace.XCoordinate] = ' ';
        }
    }

    public void AddListRendering(List<GameObject> gameObjects)
    {
        foreach (GameObject gameObject in gameObjects)
        {
            AddGameObjectForRendering(gameObject);
        }
    }

    public void ClearScreen()
    {
        StringBuilder stringBuilder = new StringBuilder();
        for (int y = 0; y < _screenHight; y++) 
        {
            for (int x = 0; x < _screenWidth; x++)
            {
                _screenMatrix[y, x] = ' ';
            }
        }
        Console.SetCursorPosition(0, 0);
        
    }

    public void RenderGameOver()
    {
        StringBuilder stringBuilder = new StringBuilder();
        stringBuilder.Append("Game   Ower!!!!!");
        Console.WriteLine(stringBuilder.ToString());
    }
}