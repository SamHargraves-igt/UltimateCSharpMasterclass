
using System.Numerics;

public class Animal
{
    public virtual int NumberOfLegs { get; } = 4;

}


public class Lion : Animal
{

}

public class Tiger : Animal
{

}

public class Duck : Animal
{
    public override int NumberOfLegs { get; } = 2;
}

public class Spider : Animal
{
    public override int NumberOfLegs { get; } = 8;
}



public class StringsProcessor
{
    public List<string> Process(List<string> list)
    {
        List<string> newlist = new List<string>();
        foreach (string s in list)
        {
            newlist.Add(Substring(s));
        }
        return newlist;
    }

    public virtual string Substring(string s)
    {
        return s;
    }

}

public class StringsTrimmingProcessor : StringsProcessor
{
    public override string Substring(string s)
    {
        string newstring = "";
        for (int i = 0; i < s.Length/2; i++) 
        {
            newstring += s[i];
        }
        return newstring;
    }
}

public class StringsUppercaseProcessor : StringsProcessor
{
    public override string Substring(string s)
    {
        string newstring = "";
        for (int i = 0; i < s.Length/2; i++)
        {
            newstring += s.ToUpper();
        }
        return newstring;
    }
}

public static class NumericTypesDescriber
{
    public static string Describe(object someObject)
    {
        if (someObject.GetType() == typeof(double) || someObject.GetType() == typeof(int)){ }
        return null;
    }
}

public abstract class Shape
{
    public abstract double CalculateArea();
}

public class Square : Shape
{
    public double Side { get; }

    public Square(double side)
    {
        Side = side;
    }

    public override double CalculateArea() => Side * Side;
}

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double CalculateArea() => Width * Height;
}

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double CalculateArea() => Math.PI * Radius * Radius;
}

