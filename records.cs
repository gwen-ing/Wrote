public record Name(String FirstName, String LastName)
{
    public required string[] Contacts {  get; init; }
}   

public static class Program
{
    public static void Main()
    {
        var contact = new string[2];
        Name name = new("George", "Herald") { Contacts = new string[1] };
        Console.WriteLine(name);

        Name name2 = name with { FirstName = "Darwin" };
        Console.WriteLine(name2);

        Console.WriteLine(name == name2);

        name2 =name with { Contacts = new string[1] };
        Console.WriteLine(name2);

        Console.WriteLine(name == name2);

        name2 = name with { FirstName = "Darwin", LastName = "Herald", Contacts = new string[1] };
        Console.WriteLine(name == name2);
    }
}
