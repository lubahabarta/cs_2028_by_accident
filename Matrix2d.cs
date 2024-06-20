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

            Console.WriteLine();
            int r = _matrix.GetLength(1) - 1;
            int l = r - 1;

            while (r > 0) {
                Console.WriteLine($"right: {r}");
                Console.WriteLine($"left: {l}");

                if (_matrix[r, y] == 0 && _matrix[l, y] > 0) {
                    _matrix[r, y] = _matrix[l, y];
                    _matrix[l, y] = 0;
                    l = r - 1;
                } else if (_matrix[r, y] == _matrix[l, y] && _matrix[r, y] > 0) {
                    _matrix[r, y] += _matrix[l, y];
                    _matrix[l, y] = 0;
                    r -= 1;
                    l = r - 1;
                } else if (
                    _matrix[r, y] != _matrix[l, y] &&
                    _matrix[r, y] > 0 &&
                    _matrix[l, y] > 0
                ) {
                    _matrix[r - 1, y] = _matrix[l, y];
                    _matrix[l, y] = 0;
                    r -= 1;
                    l = r - 1;
                }

                if (l - 1 < 0) {
                    r--;
                    l = r - 1;
                } else {
                    l--;
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