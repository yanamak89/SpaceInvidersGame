namespace SpaceInviders;

public class UIController
{
    public event EventHandler OnAPressed;
    public event EventHandler OnDPressed;
    public event EventHandler OnSpacePressed;

    public void StartListning()
    {
        while (true)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key.Equals(ConsoleKey.A))
            {
                OnAPressed?.Invoke(this, new EventArgs());
            }
            else if(key.Key.Equals(ConsoleKey.D))
            {
                OnDPressed?.Invoke(this, new EventArgs());
            }
            else if(key.Key.Equals(ConsoleKey.Spacebar))
            {
                OnSpacePressed?.Invoke(this, new EventArgs());
            }
            else
            {
                ;
            }
        }
    }
}