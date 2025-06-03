public static class Program
{
    public record Stored(double amount, string description);
    public record Taken(double amount, string description);

    const string money = """
        STORED 100 cool
        TAKEN 50 nice
        """;

    public static void Main()
    {
        double how = 0;

        foreach (var something in tr(money))
        {
            how += something switch
            {
                Stored d => d.amount,
                Taken w => -w.amount,
                _ => 0,
            };
            Console.WriteLine($"{something} amount updated: {how}");
        }
    }

    public static IEnumerable<object?> tr(string inputText)
    {
        var reader = new StringReader(inputText);
        string? fy;
        while ((fy  = reader.ReadLine()) is not null)
        {
            string[] parts = fy.Split(" ");
            
            string? tf = parts[0].Trim();
            if (double.TryParse(parts[1].Trim(), out double amount))
            {
                if (tf?.ToUpper() is "STORED")
                {
                    yield return new Stored(amount, parts[2]);
                }
                else if (tf?.ToUpper() is "TAKEN")
                {
                    yield return new Taken(amount, parts[2]);
                }
            }

        }
        yield return default;
    }
}
