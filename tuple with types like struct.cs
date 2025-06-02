
//using public now
public record struct Point(int x, int y)
{
    public double Slope() => (double)y / (double)x;
}

public class Program()
{
    public static void Main()
    {
        Point pt = new Point(1, 1);
        var pt2 = pt with { x = 2, y = 10 };
        Console.WriteLine($"The two points are {pt} and also {pt2}\n");

        double slope = pt.Slope();
        double slope2 = pt2.Slope();
        Console.WriteLine($"the slope of {pt} is {slope} and the slope of {pt2} is {slope2}\n");
    }


}
