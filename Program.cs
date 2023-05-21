using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KeyListener
{
    public event Action EnterKeyPressed;
    public event Action SpaceKeyPressed;
    public event Action EscapeKeyPressed;
    public event Action F1KeyPressed;
    public event Action LeftKeyPressed;
    public event Action RightKeyPressed;
    public event Action UpKeyPressed;
    public event Action DownKeyPressed;

    public void Listen()
    {
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    EnterKeyPressed?.Invoke();
                    break;
                case ConsoleKey.Spacebar:
                    SpaceKeyPressed?.Invoke();
                    break;
                case ConsoleKey.Escape:
                    EscapeKeyPressed?.Invoke();
                    break;
                case ConsoleKey.F1:
                    F1KeyPressed?.Invoke();
                    break;
                case ConsoleKey.LeftArrow:
                    LeftKeyPressed?.Invoke();
                    break;
                case ConsoleKey.RightArrow:
                    RightKeyPressed?.Invoke();
                    break;
                case ConsoleKey.UpArrow:
                    UpKeyPressed?.Invoke();
                    break;
                case ConsoleKey.DownArrow:
                    DownKeyPressed?.Invoke();
                    break;
            }
        }
    }
}

class Person
{
    public void Jump()
    {
        Console.WriteLine("Jumping...");
    }

    public void Select()
    {
        Console.WriteLine("Selecting...");
    }

    public void Move()
    {
        Console.WriteLine("Moving...");
    }
    public void F1()
    {
        Console.WriteLine("F1...");
    }
}

class Program
{
    static void Main(string[] args)
    {
        KeyListener keyListener = new KeyListener();
        Person person = new Person();

        keyListener.SpaceKeyPressed += person.Jump;
        keyListener.EnterKeyPressed += person.Select;
        keyListener.LeftKeyPressed += person.Move;
        keyListener.RightKeyPressed += person.Move;
        keyListener.UpKeyPressed += person.Move;
        keyListener.DownKeyPressed += person.Move;
        keyListener.F1KeyPressed += person.F1;

        keyListener.Listen();
    }

    private static void KeyListener_F1KeyPressed()
    {
        throw new NotImplementedException();
    }
}
