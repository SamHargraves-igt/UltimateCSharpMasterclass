// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello!");

Console.WriteLine("Input the first number:");
var Userinput = Console.ReadLine();
int Firstnumber = int.Parse(Userinput);

Console.WriteLine("Input the second number:");
var Userinput2 = Console.ReadLine();
int Secondnumber = int.Parse(Userinput2);

Console.WriteLine("What do you want to do?");
Console.WriteLine("[A]dd numbers");
Console.WriteLine("[S]ubtract numbers");
Console.WriteLine("[M]ultiply numbers");
var Userinput3 = Console.ReadLine();


if (Userinput3 == "A") 
{
    int result = Firstnumber + Secondnumber;
    Console.WriteLine(Firstnumber + " + " + Secondnumber + " = " + result);
}
else if (Userinput3 == "S")
{
    int result = Firstnumber - Secondnumber;
    Console.WriteLine($"{Firstnumber} - {Secondnumber} = {result}");
}
else if (Userinput3 == "M")
{
    int result = Firstnumber * Secondnumber;
    Console.WriteLine($"{Firstnumber} * {Secondnumber} = {result}");
}

Console.ReadLine();