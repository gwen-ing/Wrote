//tuples
var pt = (x: 2, y: 4);
pt.y = pt.y + 2;

var slope = (double)pt.y / (double)pt.x;

Console.WriteLine($"A line from origin of the point {pt} has a slope of {slope}\n");

//tuple with brackets changing int number to = N/A
var pt2 = pt with { y = 10 };
var slope2 = (double)pt2.y / (double)pt2.x;

Console.WriteLine($"The point pt2 is at {pt2} and slope is {slope2}\n");

//subscript
var subscript = (a: 0, b: 0);
subscript = pt;
Console.WriteLine($"{subscript}\n");

//obstruct

var namedData = (Name: "Hello Mate", Temp: 27, Wind: 2);
var person = (FirstName: "John", SecondName: "Dave");
var order = (Product: "Shampoo", ArrayShape: "Square", Quantity: 10, UnitPrice: 0.10m);

Console.WriteLine(namedData);
Console.WriteLine(person);
Console.WriteLine(order);
