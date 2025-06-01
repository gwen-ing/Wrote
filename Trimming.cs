string greets = "    Welcome Person    ";
Console.WriteLine($"[{greets}]");

string TrimmingGreet = greets.TrimStart();
Console.WriteLine($"[{TrimmingGreet}]");

string EndTrimmingGreet = greets.TrimEnd();
Console.WriteLine($"[{EndTrimmingGreet}]");

string TrimmingAll = greets.Trim();
Console.WriteLine($"[{TrimmingAll}]");

string oop = "      kay     ";
string oh = "       O       ";

string trims = oh.Trim() + oop.Trim();
Console.WriteLine($"[{trims}]");
