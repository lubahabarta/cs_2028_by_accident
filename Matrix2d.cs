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
}