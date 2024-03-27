// See https://aka.ms/new-console-template for more information


//Variables
#region Variables
var Options = new List<string> { "S", "A", "R", "E" };
var Todos = new List<string> {};
bool escape = false;
#endregion
bool CheckOptions(string Input, List<string>options)
{

    foreach (var option in options)
    {
        if (Input == option)
        {
            return true;
        }
    }
    return false;
}



while (!escape)
{

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all TODOs");
    Console.WriteLine("[A]dd a TODO");
    Console.WriteLine("[R]emove a TODO");
    Console.WriteLine("[E]xit");

    string Userinput = Console.ReadLine().ToUpperInvariant();

    bool Check = CheckOptions(Userinput, Options);

    while (Check == false)
    {
        Console.WriteLine("Not a valid response, try again");
        Userinput = Console.ReadLine().ToUpperInvariant();
        Check = CheckOptions(Userinput, Options);
    }

    switch (Userinput)
    {
        //Pressed specifically
        case "S":
            if (Todos.Count == 0)
            {
                Console.WriteLine("No TODOs have been added yet.");
            }
            else
            {
                for (int i = 1; i <= Todos.Count; i++)
                {
                    Console.WriteLine(i + ". " + Todos[i - 1]);
                }
            }
            break;
        case var expression when string.IsNullOrEmpty(expression):
            break;
        case "A":
            Console.WriteLine("Type a To-Do");
            string TodoInput = Console.ReadLine();
            while (TodoInput.Length == 0)
            {
                Console.WriteLine("Description Can't be Empty");
                TodoInput = Console.ReadLine();
            }
            Check = CheckOptions(TodoInput, Todos);
            while (Check == true
                )
            {
                Console.WriteLine("Description must be unique");
                TodoInput = Console.ReadLine();
                Check = CheckOptions(TodoInput, Todos);
            }
            Todos.Add(TodoInput);
            Console.WriteLine("Todo Succesfully added!");
            for (int i = 1; i <= Todos.Count; i++)
            {
                Console.WriteLine(i + ". " + Todos[i - 1]);
            }
            break;
        case "R":
            if (Todos.Count == 0)
            {
                Console.WriteLine("There is nothing to Remove");
                break;
            }
            else
            {
                Console.WriteLine("Select the Index of the Todo to Remove");
                var Removeimput = Console.ReadLine();
                bool Isparsingsucccesful = int.TryParse(Removeimput, out int Index);
                while (Isparsingsucccesful == false)
                {
                    Console.WriteLine("Please give an integer");
                    Removeimput = Console.ReadLine();
                    Isparsingsucccesful = int.TryParse(Removeimput, out Index);

                }
                while (Index < 0 || Index > Todos.Count || Isparsingsucccesful == false)
                {
                    Console.WriteLine("Please give a valid Integer");
                    Removeimput = Console.ReadLine();
                    Isparsingsucccesful = int.TryParse(Removeimput, out Index);
                }
                Todos.RemoveAt(Index - 1);
            }
            break;
        case "E":
            escape = true;
            break;
        default:
            break;
    }

}

