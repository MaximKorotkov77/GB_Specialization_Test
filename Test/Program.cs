Console.Clear();
Console.Write("Введите элементы массива через пробел: ");
string inStrings = Console.ReadLine();

int GetArrayLength(string inString)
{
    string[] inArray = inString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int outLength = 0;

    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length < 4)
        {
            outLength++;
        }
    }
    return outLength;
}

string[] GetArray(string inString, int newStringLength)
{
    string[] inArray = inString.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    string[] outArray = new string[newStringLength];

    int j=0;
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i].Length < 4)
        {
            outArray[i - j] = inArray[i];
        }
        else j++;
    }
    return outArray;
}


int outLength = GetArrayLength(inStrings);
string[] outArray = GetArray(inStrings, outLength);

void PrintArray(string[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{Array[i]} ");
    }
}

PrintArray(outArray);