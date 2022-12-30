// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись
// исключительно массивами.


Console.WriteLine("Please enter 4 strings: ");

string a = Console.ReadLine();
string b = Console.ReadLine();
string c = Console.ReadLine();
string d = Console.ReadLine();


string[] userArray = CreateArrayFromStrings(a,b,c,d);

PrintStringArray(userArray);

string[] intermediateArray = ChooseThreeOrLessSignString(userArray);

string[] resultArray = TrimStringArray(intermediateArray);

PrintStringArray(resultArray);










// Methods:

string[] CreateArrayFromStrings(string a, string b, string c, string d)
{
    string[] array = new string[4];

    array[0] = a;
    array[1] = b;
    array[2] = c;
    array[3] = d;

    return array;
}



void PrintStringArray(string[] arr)
{
    Console.Write("[");
    
    for(int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}");
    Console.Write("]");
    Console.WriteLine();
}


string[] ChooseThreeOrLessSignString(string[] array)
{
    string[] newArray = new string[array.Length];

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            newArray[i] = array[i];
        }
        else
        {
            newArray[i] = "+";
        }
    }
    return newArray;
}


string[] TrimStringArray(string[] array)
{
    int count = 0;

    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == "+")
        {
            count++;
        }
    }

    string[] trimmedArray = new string[array.Length - count];
    int k = 0;

    for(int j = 0; j < array.Length; j++)
    {
        if(array[j] != "+")
        {
            trimmedArray[k] = array[j];
            k++;
        }
    }
    return trimmedArray;
}