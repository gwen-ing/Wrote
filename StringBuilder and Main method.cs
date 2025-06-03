using System;
using System.Text;

static class Program
{
    static void Main(string[] args)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Passed");

        foreach (string arg in args)
        {
            sb.AppendLine(arg);
        }
        Console.Write(sb.ToString());
    }
}

/*
static void Main() { }
static int Main() { }
static void Main(string[] args) { }
static int Main(string[] args) { }
static async Task Main() { }
static async Task<int> Main() { }
static async Task Main(string[] args) { }
static async Task<int> Main(string[] args) { }
*/
