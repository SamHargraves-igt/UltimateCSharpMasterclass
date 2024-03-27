// See https://aka.ms/new-console-template for more information


string BuildHelloString()
{
    char[] letters = { 'h', 'e', 'l', 'l', 'o' };
    var result = "";
    for (int i = 0; i < letters.Length; ++i)
    {
        result += letters[i];
    }
    return result;
}



bool IsWordPresentInCollection(string[] words, string wordToBeChecked)
{
    for(int i = 0; i < words.Length; ++i)
    {
        if (words[i] == wordToBeChecked)
        {
            return true;
            break;
        }
    }
    return false;
}

int FindMax(int[,] numbers)
{
    int max = -1;
    int height = numbers.GetLength(0);
    int width = numbers.GetLength(1);
    for (int i = 0;i < height; ++i)
    {
        for(int j = 0;j < width; ++j)
        {
            if (numbers[i,j] > max)
            {
                max = numbers[i,j];
            }
        }
    }
    return max;
}

bool IsAnyWordLongerThan(int length, string[] words)
{
    foreach(string word in words)
    {
        int count = 0;
        foreach(char ch in word)
        {
            count += 1;
        }
        if (count > length)
        {
            return true;
        }
    }

    return false;
}


List<string> GetOnlyUpperCaseWords(List<string> words)
{
    foreach(var word in words)
    {
        foreach(char ch in word)
        {
            bool isuppercase = char.IsUpper(ch);
            
            if(isuppercase = false)
            {
                words.Remove(word);
                break;
            }
        }
    }
    return words;
}



int[,] input = { { 1, 2, 4, 5, 6, 7, 8 }, { 2, 3, 4, 45,65,7,2} };

string[] words = { "HI", "Same", "SmellyLizzie" };

var wordlist = new List<string>{ "Hi", "Same", "SmellyLizzie" };



int length = 8;

var output = GetOnlyUpperCaseWords(wordlist);

string stringoutput = string.Join(",", output);


Console.WriteLine(stringoutput);



Console.ReadKey();
