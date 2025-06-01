/* Challenge
There are two similar methods, StartsWith and EndsWith that also search for substrings in a string. 
These methods find a substring at the beginning or the end of the string. 
Try to modify the previous sample to use StartsWith and EndsWith instead of Contains. 
Search for "You" or "goodbye" at the beginning of a string. Search for "hello" or "goodbye" at the end of a string. */

// actually put in hard work right naw :(
string you = "You";
string goodbye = "goodbye";
string hello = "hello";

string againpoet = $"{you} are welcome and {hello}";

string avail = $"{againpoet.StartsWith(you)}";
string notavail = $"{againpoet.StartsWith(goodbye)}";

string avail2 = $"{againpoet.EndsWith(hello)}";
string notavail2 = $"{againpoet.EndsWith(goodbye)}";

Console.WriteLine($"{againpoet}\n");

Console.WriteLine($"{you} is {avail.Replace("True", "available")} = [{avail}]");
Console.WriteLine($"{goodbye} is {notavail.Replace("False", "not available")} = [{notavail}]\n");

Console.WriteLine($"{hello} is {avail2.Replace("True", "available")} = [{avail2}]");
Console.WriteLine($"{goodbye} is {notavail2.Replace("False", "not available")} = [{notavail2}]");
