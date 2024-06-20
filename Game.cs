namespace _2028;

sealed class Game
{
    private string _gameState; 

    private Matrix2d _matrix;
    
    public Game(sbyte size)
    {
        _matrix = new Matrix2d(size);
        _gameState = "running";
        Start();
    }

    public void Start()
    {
        _matrix.Randomize();
        _Loop();
    }

    private void _Loop()
    {
        while (_gameState == "running")
        {
            // Console.Clear();
            Console.WriteLine();
            _matrix.Print();

            _WatchKeys();

            _matrix.Randomize();

            if (_matrix.IsFull())
                _gameState = "ended";
        }
    }

    private void _WatchKeys()
    {
        ConsoleKey key = Console.ReadKey().Key;
        switch (key)
        {
            case ConsoleKey.UpArrow:
                _matrix.MoveUp();
                break;
            case ConsoleKey.DownArrow:
                _matrix.MoveDown();
                break;
            case ConsoleKey.LeftArrow:
                _matrix.MoveLeft();
                break;
            case ConsoleKey.RightArrow:
                _matrix.MoveRight();
                break;
            default:
                _gameState = "ended";
                break;
        }
    }
}