class Program
{
    static async Task<int> Main(string[] args)
    {
        return await AsyncConsoleWork();
    }

    public static async Task<int> AsyncConsoleWork()
    {
        return 0;
    }
}   

class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Argument is passing");
        }

        long num = Int64.Parse(args[0]);
        long num2 = long.Parse(args[1]);
        long num3 = Convert.ToInt64(num);


    }
}   
