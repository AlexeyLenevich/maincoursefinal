string[] WriteStrings()
{
    Console.WriteLine("Введите количество строк: ");
    int count = int.Parse(Console.ReadLine());

    string[] array = new string[count];

    Console.WriteLine("Введите строки: ");
    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }

    return array;
}

string[] ChooseStringsForFinalArray(string[] array)
{
    int count = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int i = 0;
    foreach (string item in array)
    {
        if (item.Length <= 3)
        {
            result[i] = item;
            i++;
        }
    }

    return result;
}

string PrintArray(string[] array)
{
    string str = null;
    for (int i = 0; i < array.Length; i++)
    {
        str += array[i];
        if (i < array.Length - 1)
        {
            str += ", ";
        }
    }
    return str;
}

string[] array = WriteStrings();
string[] result = ChooseStringsForFinalArray(array);
string startArray = PrintArray(array);
string finalArray = PrintArray(result);

Console.WriteLine(startArray + " -> " + finalArray);
