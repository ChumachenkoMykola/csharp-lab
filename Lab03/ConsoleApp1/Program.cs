using System.Collections.Generic;


Console.WriteLine("zadanie 1");
int n = 10;
do
{
    Console.WriteLine(n);
    n--;
} while (n >= 0);

Console.WriteLine("\n" + "zadanie 2");

string s;
do
{
    Console.WriteLine("Enter password");
    s = Console.ReadLine();
} while (s != "koniec");

Console.WriteLine("\n" + "zadanie 3");
n = 0;
while (n < 100)
{
    n++;
    if (n % 2 == 0)
    {
        Console.WriteLine(n);
    }
}

Console.WriteLine("\n" + "zadanie 4");
for (int i = 1; i < 15; i++)
{
    Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
}

Console.WriteLine("\n" + "zadanie 5");
List<int> numbers = new() { 4, 25, 35, 42, 55, 78, 99, 101 };

foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
    }
}

Console.WriteLine("\n" + "zadanie 6");

foreach (int i in numbers)
{
    if (i % 7 == 0)
    {
        Console.WriteLine(i);
        break;
    }
}

Console.WriteLine("\n" + "zadanie 7");
double[] doubleArray = new double[20];
for (int i = 0; i < 20; i++)
{
    doubleArray[i] = Math.Sqrt(i);
    Console.WriteLine(doubleArray[i]);
}

//zadanie 8
int[,] intMatrix = new int[3, 4];
for (int column = 0; column < intMatrix.GetLength(0); column++)
{
    for (int row = 0; row < intMatrix.GetLength(1); row++)
    {
        intMatrix[column, row] = column + row;
    }
}

int[,] transpIntMatrix = new int[4, 3];
for (int column = 0; column < intMatrix.GetLength(0); column++)
{
    for (int row = 0; row < intMatrix.GetLength(1); row++)
    {
        transpIntMatrix[row, column] = intMatrix[column, row];
    }
}

Console.WriteLine("\n" + "zadanie 10");
void PrintUpperCase(string txt)
{
    Console.WriteLine(txt.ToUpper());
}
PrintUpperCase("Hello");


Console.WriteLine("\n" + "zadanie 11");
void Matrix11(int x, int y)
{
    string xLength = "";
    for (int i = 0; i < x; i++)
    {
        xLength += "$";
    }
    for (int i = 0; i < y; i++)
    {
        Console.WriteLine(xLength);
    }
}
Matrix11(8, 4);

Console.WriteLine("\n" + "zadanie 12");
string ReturnString(int number)
{
    string result = "";
    if (number % 2 == 0) result = "Even";
    else
    {
        result = "Odd";
    }
    return result;
}
Console.WriteLine(ReturnString(10));

Console.WriteLine("\n" + "zadanie 13");

