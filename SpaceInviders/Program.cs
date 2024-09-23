using SpaceInviders;

class Program
{
    static GameEngine gameEngine;
    static GameSettings gameSettings;
    static UIController uiController;
    static MusicController musicController;
    public static void Main(string[] args)
    {
        Initialize();
        gameEngine.Run();
    }

    public static void Initialize()
    {
        gameSettings = new GameSettings();
        gameEngine = GameEngine.GetGameEngine(gameSettings);
        uiController = new UIController();


        uiController.OnAPressed += (obj, arg) => 
            gameEngine.CalulateMovePlayerShipLeft();
        uiController.OnDPressed += (obj, arg) => 
            gameEngine.CalulateMovePlayerShipRight();

        uiController.OnSpacePressed += (obj, arg) =>
            gameEngine.Shot();
        Thread uiThread = new Thread(uiController.StartListning);
        uiThread.Start();

        musicController = new MusicController();
        Thread musicThread = 
            new Thread(musicController.PlayBackgroundMusic);
        musicThread.Start();
        
        Thread.CurrentThread.Priority = ThreadPriority.AboveNormal;

    }
}