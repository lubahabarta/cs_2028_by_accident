using System.Runtime.CompilerServices;

namespace _2028;

class Matrix2d {
    private int[,] _matrix;

    public Matrix2d(int size)
    {
        _matrix = new int[size, size];
    }

    public void Print()
    {
        for (int y = 0; y < _matrix.GetLength(0); y++) {
            for (int x = 0; x < _matrix.GetLength(1); x++) {
                Console.Write(_matrix[x, y] + " ");
            }
            Console.WriteLine();
        }
    }

    private delegate void LoopCallback(int x, int y, int value);
    private void _Loop(LoopCallback callback)
    {
        for (int y = 0; y < _matrix.GetLength(0); y++) {
            for (int x = 0; x < _matrix.GetLength(1); x++) {
                callback(x, y, _matrix[x, y]);
            }
        }   
    }

    public void Randomize()
    {
        List<int[]> positions = new List<int[]>();
        _Loop((x, y, value) => {
            if (value == 0) 
                positions.Add(new int[] { x, y });
        });

        Random random = new Random();

        int randomIndex = random.Next(0, positions.Count);
        int[] randomCoordinate = positions[randomIndex];
        positions.RemoveAt(randomIndex);

        int randomValue = random.Next(1, 3) * 2;
        _matrix[randomCoordinate[0], randomCoordinate[1]] = randomValue;
    }

    public void MoveUp()
    {
        Console.WriteLine("Move up");
    }

    public void MoveDown()
    {
        Console.WriteLine("Move down");
    }

    public void MoveLeft()
    {
        Console.WriteLine("Move left");
    }

    public void MoveRight()
    {
        for (int y = 0; y < _matrix.GetLength(0); y++) {
            int lastX = _matrix.GetLength(1) - 1;
            for (int x = lastX; x > 0; x--) {
                if (_matrix[x, y] > 0) {
                    if (_matrix[x + 1, y] == 0) {
                        _matrix[x + 1, y] = _matrix[lastX, y];
                        lastX = x + 1;
                    }
                }
            }   
        }
    }

    public bool IsFull()
    {
        bool isFull = true;
        _Loop((x, y, value) => {
            if (value == 0) 
                isFull = false;
        });
        return isFull;
    }
}