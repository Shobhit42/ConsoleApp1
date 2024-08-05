// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;

//Console.WriteLine("Hello, World!");
//string name = "shobhit";
//string cap = name.Capitalize();

foreach (int i in getNumbers())
{
    if(i > 100)
    {
        break;
    }
    else
    {
        Console.WriteLine(i);
    }
}
Console.ReadLine();

static IEnumerable<int> getNumbers()
{
    int i = 0;
    while (true)
    {
        yield return i++;
    }
}

public static class StringExtensions
{
    public static string Capitalize(this string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        return char.ToUpper(input[0]) + input.Substring(1);
    }
}

public abstract class ParentClass

{
    public ParentClass()
    {
        Console.WriteLine("inside constructor of parent class");
    }
    public abstract void ParentClassMethod();
}

public class Order : ParentClass
{
    override public void ParentClassMethod()  => Console.WriteLine("Called");
}