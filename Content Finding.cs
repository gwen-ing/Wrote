// finder + true false replacing

string Poet = "Once in my darling animal life there was a beautiful pig";
Console.WriteLine(Poet);

string found = $"darling is {Poet.Contains("darling")}";
found = found.Replace("True", "available");

Console.WriteLine(found);

string notfound = $"honey is {Poet.Contains("honey")}";
notfound = notfound.Replace("False", "not available");

Console.WriteLine(notfound);
