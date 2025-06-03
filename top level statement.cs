using System;
using System.Threading.Tasks;

await Test.Yoo(args);

string? s = Console.ReadLine();

int returnValue = int.Parse(s ?? "-1");
return returnValue;

Hello.Hi(args);

public class Test
{
    public static async Task<int> Yoo(string[] args1)
    {
        Console.WriteLine("Hello World from MyNamespace.MyClass.MyMethod!");
        await Task.Delay(5000);
        Console.WriteLine("Yeah BRo");
        return 1;

    }
}

public class Hello()
{
    public static void Hi(string[] args)
    {
        if (args.Length == 0)
        {
            foreach (var arg in args)
            {
                Console.WriteLine($"Hello World! {arg}");
            }
        }
        else
        {
            Console.WriteLine("No Hello World!");
        }
    }
}
