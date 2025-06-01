// replacing script

string adult = "Adult Man";
Console.WriteLine(adult);

adult = adult.Replace("Adult", "Baby");
adult = adult.Replace("Man", "Boy");
Console.WriteLine(adult);

adult = adult.Replace("Baby", "Okay");
adult = adult.Replace("Boy", "World");
Console.WriteLine(adult);

Console.WriteLine(adult.ToUpper());
Console.WriteLine(adult.ToLower());
