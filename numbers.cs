//pretty simple integer script :O

int n1 = 12;
int n2 = 2;
int n3 = 5;

//basic
int plus = n1 + n2;
int minus = n1 - n2;
int multiply = n1 * n2;
int divide = n1 / n2;

//custom
int custom = n1 + n2 * n3;
int custom2 = (n1 + n2) * n3;

//quotient and remainder
int quotient = (n1 + n2) / n3;
int remainder = (n1 + n2) % n3;

//values
int maximum = int.MaxValue;
int minimum = int.MinValue;
int overflow = maximum + 3;
int overflow2 = minimum + 2;

//doubles
double n4 = 30;
double n5 = 18;
double n6 = 2;
double quotient2 = (n4 + n5) / n6;

double maximum2 = double.MaxValue;
double minimum2 = double.MinValue;

double errortest = 1.0 / 3.0;

//prints out basic
Console.WriteLine("Basic Forms");
Console.WriteLine($"{n1} + {n2} = {plus}");
Console.WriteLine($"{n1} - {n2} = {minus}");
Console.WriteLine($"{n1} * {n2} = {multiply}");
Console.WriteLine($"{n1} / {n2} = {divide}\n");

//prints out integers
Console.WriteLine("Integers");
Console.WriteLine($"{n1} + {n2} * {n3} = {custom}");
Console.WriteLine($"({n1} + {n2}) * {n3} = {custom2}\n");

//prints out quotient and remainder
Console.WriteLine("Quotient and Remainder");
Console.WriteLine($"({n1} + {n2}) / {n3} = {quotient}");
Console.WriteLine($"({n1} + {n2}) % {n3} = {remainder}\n");

//Values
Console.WriteLine("Minimum and Maximum");
Console.WriteLine($"The ranged of integers is {minimum} to {maximum}");
Console.WriteLine($"Example of Overflow in Maximum: {overflow}");
Console.WriteLine($"Example of Overflow in Minimum: {overflow2}\n");

//Doubles
Console.WriteLine("Doubles");
Console.WriteLine($"({n4} + {n5}) / {n6} = {quotient2}\n");

Console.WriteLine("Doubles with maximum and minimum");
Console.WriteLine($"The ranged of the doubled integers is {minimum2} to {maximum2}\n");

Console.WriteLine("ErrorTesting");
Console.WriteLine($"{errortest}\n");


//challenge
double large = 8947;
double large2 = 7894;
double large3 = 71;
double small = 28;
double small2 = 17;
double small3 = 8;

double largetolarge = (large * large2) / large3;
double smalltosmall = (small * small2) / small3;

Console.WriteLine("Challenge");
Console.WriteLine($"({large} * {large2}) / {large3} = {largetolarge}");
Console.WriteLine($"({small} * {small2}) / {small3} = {smalltosmall}\n");

//decimals
decimal maximum3 = decimal.MaxValue;
decimal minimum3 = decimal.MinValue;

Console.WriteLine("Decimals");
Console.WriteLine($"The ranged of the decimal integers is {minimum3} to {maximum3}\n");


//difference between doubles and decimals
double n7 = 1.0;
double n8 = 3.0;
double n9 = n7 / n8;

decimal n10 = 1.0M;
decimal n11 = 3.0M;
decimal n12 = n10 / n11;

Console.WriteLine("Difference between doubles and decimals");
Console.WriteLine($"{n7} / {n8} = {n9}");
Console.WriteLine($"{n10} / {n11} = {n12}\n");

//Challenge2 

double radius = 2.50;
double pie = Math.PI * radius * radius;

Console.WriteLine("Challenge2");
Console.WriteLine($"The area of pie is {pie}");
