 List<int> GetCountsOfAnimalsLegs()
{
    var animals = new List<Animal>
            {
                new Lion(),
                new Tiger(),
                new Duck(),
                new Spider()
            };

    var result = new List<int>();
    foreach (var animal in animals)
    {
        result.Add(animal.NumberOfLegs);
    }
    return result;
}

/*List<int> result = GetCountsOfAnimalsLegs();

Console.WriteLine(result);
Console.ReadKey();*/

List<string> ProcessAll(List<string> words)
{
    var stringsProcessors = new List<StringsProcessor>
                {
                    new StringsTrimmingProcessor(),
                    new StringsUppercaseProcessor()
                };

    List<string> result = words;
    foreach (var stringsProcessor in stringsProcessors)
    {
        result = stringsProcessor.Process(result);
    }
    return result;
}

List<string> words = [ "Lisbon", "Malaysia", "Mexico" ];
List<string> result = ProcessAll(words);

foreach (var list in result) 
{
    Console.WriteLine(list);    
}


Console.ReadKey();

static List<double> GetShapesAreas(List<Shape> shapes)
{
    var result = new List<double>();

    foreach (var shape in shapes)
    {
        result.Add(shape.CalculateArea());
    }

    return result;
}