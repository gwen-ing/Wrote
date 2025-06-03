
    string money = """
    stored 1000
    taken 500
    stored 501
    """;
      
        double how = 0;
        var reader = new StringReader(money);

        string? fy;
        while ((fy = reader.ReadLine()) is not null)
        {
            if (string.IsNullOrWhiteSpace(fy)) continue;
            string[] parts = fy.Split(' ');

            string? tf = parts[0]?.Trim();
            if (double.TryParse(parts[1].Trim(), out double hows))
            {
                if (tf?.ToLower() is "stored")
                {
                    how += hows;
                }
                else if (tf?.ToLower() is "taken")
                {
                    how -= hows;
                }
                Console.WriteLine($"{fy.Trim()} updated amount {how}");
            }
        }
