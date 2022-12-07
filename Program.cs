Console.Clear();

string[] testOne = { "hello", "2", "world", ":-)" };
string[] testTwo = { "1234", "1567", "-2", "computer science" };
string[] testThird = { "Russia", "Denmark", "Kazan" };
string[] manualInputArray = GetArrayFromConsole("Input STRING array split , : ");

string[] resultOne = FindStringBySizeInArray(testOne);
ShowResult(testOne, resultOne);

string[] resultTwo = FindStringBySizeInArray(testTwo);
ShowResult(testTwo, resultTwo);

string[] resultThird = FindStringBySizeInArray(testThird);
ShowResult(testThird, resultThird);

string[] resultManualInputArray = FindStringBySizeInArray(manualInputArray);
ShowResult(manualInputArray, resultManualInputArray);


string[] GetArrayFromConsole(string message = "")
{
    Console.Write(message);
    return Console.ReadLine()!.Split(",");
}

void ShowResult(string[] test, string[] result)
{
    ShowArray(test);
    Console.Write("->");
    ShowArray(result);
    Console.WriteLine();
}

string[] FindStringBySizeInArray(string[] str, int length = 3)
{
    string tmp = String.Empty;
    foreach (string item in str)
    {
        if(item.Length<=length) tmp+=item +" ";
    }
    return tmp.TrimEnd().Split(' ');
}

void ShowArray(string[] inputArray)
{
    if (inputArray.Length > 0 && inputArray[0].Length != 0)
    {
        Console.Write($"[\"{String.Join("\",\"", inputArray)}\"]");
    }
    else
    {
        Console.Write("[]");
    }
}
