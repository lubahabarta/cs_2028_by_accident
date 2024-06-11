namespace _2028;

class Program
{
    private static sbyte _SizeInput()
    {
        sbyte size = 0;
        do {
            size = ConsoleUtil.AskForNumber("Enter the size of the game [4 - 127]:");
        } while (size < 4);

        return size;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("\n------------- PROGRAM START -------------\n");

        sbyte size = _SizeInput();
        Game game = new Game(size);
    }

    
}
