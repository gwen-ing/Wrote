using System.Diagnostics.Contracts;

public class GenericsList<T>
{
    public void Add(T item) { }
}

public class ExampleClass { }

class Testing
{
    static void Main(string[] args)
    {
        GenericsList<int> list1 = new();
        list1.Add(1);

        GenericsList<string> list2 = new();
        list2.Add("a");

        GenericsList<ExampleClass> list3 = new();
        list3.Add(new ExampleClass());
    }
}
