//String list collection
List<string> names = ["John", "George", "Matthew"];
names.Add("Jimmy");
names.Remove("Matthew");


Console.WriteLine($"Hello {names[0]} and {names[1]}!");
Console.WriteLine($"This list has {names.Count} people in it");
Console.WriteLine();

names.Sort();
foreach (var name in names)
{
    Console.WriteLine($"Hello {name.ToUpper()}!");
}

Console.WriteLine();
var index = names.IndexOf("George");

if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"When an item is found {names[index]}, IndexOf returns {index}");
}

index = names.IndexOf("Kimmy");
if (index == -1)
{
    Console.WriteLine($"When an item is not found, IndexOf returns {index}");
}
else
{
    Console.WriteLine($"When an item is found {names[index]}, IndexOf returns {index}");
}

//Int List Collection
List<int> summing = [1, 2];

var previous = summing[summing.Count - 1];
var previous2 = summing[summing.Count - 2];

summing.Add(previous + previous2);

Console.WriteLine();
foreach (var item in summing)
{
  Console.WriteLine(item);
}


//Challenge
List<int> fibonacci = [1, 2];

Console.WriteLine();

for (int i = fibonacci.Count; i < 19; i++)
{
    int hello = fibonacci[i - 1] + fibonacci[i - 2];
    fibonacci.Add(hello);
}

foreach (var cool in fibonacci)
{
    Console.WriteLine(cool);
}
