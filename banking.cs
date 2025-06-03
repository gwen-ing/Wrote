
using System.ComponentModel.Design;
using System.Transactions;

public static class Program
{
    const string money = """
    stored 1000
    taken 500
    stored 501
    """;

    public static void Main()
    {
        double how = 0;
        foreach (var tf in tr(money))
        {
            if (tf.type == enums.Stored)
            {
                how += tf.hows;
            }
            else if (tf.type == enums.Taken)
            {
                how -= tf.hows;
            }
            Console.WriteLine($"{tf.type} updated amount {how}");
        }
    }

    static IEnumerable<(enums type, double hows)> tr(string inputText)
    { 
        var reader = new StringReader(inputText);
        string? fy;
        while ((fy = reader.ReadLine()) is not null)
        {
            string[] parts = fy.Split(' ');

            string? tfs = parts[0]?.Trim();
            if (double.TryParse(parts[1].Trim(), out double hows))
            {
                if (tfs?.ToUpper() is "STORED")
                {
                    yield return (enums.Stored, hows);
                }
                else if (tfs?.ToUpper() is "TAKEN")
                {
                    yield return (enums.Taken, hows);
                }
            }
            else
            {
                yield return (enums.Invalid, 0);
            }
        }
    }
}

public enum enums
{
    Stored,
    Taken,
    Invalid,
}
