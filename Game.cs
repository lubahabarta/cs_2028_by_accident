using Microsoft.VisualBasic;
using System;

namespace _2028;

sealed class Game
{
    private bool _running;

    private Matrix2d _matrix;
    
    public Game(sbyte size)
    {
        _matrix = new Matrix2d(size);
        _running = true;
    }

    public void Start()
    {
        _Loop();
    }

    private void _Loop()
    {
        while (_running)
        {
            _matrix.Print();
            string s = Console.ReadLine() ?? "";
        }
    }
}