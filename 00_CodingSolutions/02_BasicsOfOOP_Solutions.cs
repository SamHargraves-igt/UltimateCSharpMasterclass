// See https://aka.ms/new-console-template for more information


using System.Security.Cryptography.X509Certificates;

class HotelBooking
{
    string GuestName;
    
    public HotelBooking() 
    {
        var StartDate = new DateTime();
        var EndDate = new DateTime();
        int LengthOfStayInDays = StartDate.DayOfYear - EndDate.DayOfYear;
        Console.ReadKey();
    }


}

class Triangle
{
    private int Base;
    private int Height;
    public Triangle(int @base, int height)
    {
        Base = @base;
        Height = height;

    }

    public int CalculateArea()
    {
        int Area = (Base * Height) / 2;
        return Area;
    }


}

public class Dog
{
    string Name;
    string Breed;
    int Weight;
    string Size;
    
    public Dog(string name, int weight, string breed) 
    {
        Name = name;
        Breed = breed;
        Weight = weight;
    }

    public Dog(string name, int weight)
    {
        Name =name;
        Weight=weight;
        Breed = "Mixed-Breed";
    }

    private string SizeMethod()
    {
        if (Weight < 5)
        {
            Size = "Tiny";
            return Size;
        }
        if (Weight < 30)
        {
            Size = "Medium";
            return Size;
        }
        else
        {
            Size = "Large";
            return Size;
        }

    }

    public string Describe()
    {
        SizeMethod();
        return $"This dog is named {Name}, it's a {Breed}, and it weights {Weight} kilograms, so it's a {Size} Dog";
    }
}

public class Order
{
    private string Item;
    public DateTime Date
    {
        get
        {
            return Date;
        }
        set
        {
            if (value.Year == Date.Year)
            {
                Date = value;
            }
        }
    }
    public Order(string item, DateTime date)
    {
        Item = item;
        Date = date;

    }
}

public class DailyAccountState
{
    public int InitialState { get; }

    public int SumOfOperations { get; }

    public DailyAccountState(
        int initialState,
        int sumOfOperations)
    {
        InitialState = initialState;
        SumOfOperations = sumOfOperations;
    }

    public int Endofstate {
        get { return InitialState + SumOfOperations;}
    }
    
    public string Report => $"Day: {DateTime.Now.Day}, month: {DateTime.Now.Month}, year: {DateTime.Now.Year}, initial state: {InitialState}" +
                            $", end of day state: {Endofstate}";
}

public static class NumberTodayofWeek
{
    private static string[] Days = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

    public static string Translate(int index)
    {
        if (index < Days.Length & index >= 0)
        {
            return Days[index];
        }
        else
        {
            return "Not a valid day";
        }
    }
}

public static class StringsTransformator
{
    public static string TransformSeparators(
        string input,
        char originalSeparator,
        char targetSeparator)
    {
        string output = "";

        for (int i = 0; i < input.Length; ++i) 
        {
            output += input[i];
            if (originalSeparator == input[i])
            {
                output += targetSeparator;
            }
        }
        return output;
    }
}



//Console.WriteLine(stringoutput);





