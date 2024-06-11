namespace _2028;

class Program
{
    private static sbyte _Setup()
    {
        sbyte size = 0;
        do {
            size = _askForNumber("Enter the size of the game [4 - 127]:");
        } while (size < 4);

        return size;
    }

    private static sbyte _askForNumber(string message)
    {
        try
        {
            Console.Write($"{message} ");
            sbyte input = Convert.ToSByte(Console.ReadLine());
            if (input < 1)
            {
                Console.WriteLine("Invalid number. Try again.");
                return 0;
            }
            return input;
        } 
        catch
        {
            Console.WriteLine("Invalid number. Try again.");
            return 0;
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("\n------------- PROGRAM START -------------\n");

        sbyte size = _Setup();
        Game game = new Game(size);
        game.Start();
    }

    
}
