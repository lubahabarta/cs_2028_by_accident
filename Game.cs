namespace _2028;

sealed class Game
{
    private Matrix2d _matrix;
    
    public Game(sbyte size)
    {
        _matrix = new Matrix2d(size);
        
    }

    public void Start()
    {
        _matrix.Print();
    }
}