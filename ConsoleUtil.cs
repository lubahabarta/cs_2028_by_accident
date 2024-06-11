static class ConsoleUtil {
    public static sbyte AskForNumber(string message)
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

    public static string AskForString(string message)
    {
        try 
        {
            Console.Write($"{message} ");
            return Console.ReadLine() ?? "";
        } 
        catch
        {
            return "";
        }
    }
}