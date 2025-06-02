//branching
int n = 5;
int n2 = 5;
int n3 = 1;
if ((n + n2 + n3 > 10) && (n == n2))
{
    Console.WriteLine("The door has been open because is greater than 10");
    Console.WriteLine("And the first number is equal to the second");
}
else
{
    Console.WriteLine("The door won't open because it is less than 10");
    Console.WriteLine("Or the first number is not equal to the second");
}
