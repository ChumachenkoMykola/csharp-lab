﻿/* zadanie 1 */
Console.WriteLine("Zmienne i typy danych");
byte byteVariable = 50;
int integralVariable = 300;
long longVariable = 100000000;
char charVariable1 = (char)87;
char charVariable2 = 'a'; //97
double doubleVariable = 50.0005;
float floatVariable = 50e10F;
string stringVariable = "How you doing?";
// tutaj wpisz rozwiązanie

Console.WriteLine($"{byteVariable};\n{doubleVariable};\n{charVariable1};\n"
    + $"{charVariable2};\n{longVariable};\n{floatVariable};\n{stringVariable}");

/* koniec zadania 1 */



/* zadanie 2 */
int num = 2147483647;
long bigNum = 88888888888;
string stringNum = "1024";

// zadeklaruj zmienną typu long i przypisz do niej zmienną num
long numLong = num;
Console.WriteLine("num: " + num + "\n" + "numLong: " + numLong);

// zadeklaruj zmienną typu int i przypisz do niej zmienną bigNum
int bigNumLong = (int)bigNum;
Console.WriteLine("bigNum: " + bigNum + "\n" + "bigNumLong: " + bigNumLong);

// zadeklaruj zmienną typu int i przypisz do niej zmienną stringNum (zastosuj Parse)
int stringNumToInt = int.Parse(stringNum);
Console.WriteLine("stringNum: " + stringNum + "\n" + "stringNumToInt: " + stringNumToInt);

// zbadaj zachowanie programu

/* koniec zadania 2 */



/* zadanie 3 */
int a = 18;
int b = 6;
decimal price = 10.56m;
double doubleVal = 10.56;
double radius = 5.0;
double time = 1234.45;
// zadeklaruj zmienną c, do której przypisz wynik dodawania a i b 
int c = a + b;

// zadeklaruj zmienną d, do której przypisz wynik odejmowania a i b 
int d = a - b;

// zadeklaruj zmienną e, do której przypisz wynik mnożenia a i b
int e = a * b;

// zadeklaruj zmienną f, do której przypisz wynik dzielenia a i b 
int f = a / b;

// zadeklaruj zmienną g, do której przypisz wynik reszty z dzielenia a i b 
int g = a % b;

// wypisz na ekran c,d,e,f,g
Console.WriteLine("c: " + c);
Console.WriteLine("d: " + d);
Console.WriteLine("e: " + e);
Console.WriteLine("f: " + f);
Console.WriteLine("g: " + g);

// wypisz na ekran wynik zmiennej price pomnożonej przez samą siebie
Console.WriteLine(price * price);

// wypisz na ekran wynik zmiennej doubleVal pomnożonej przez samą siebie
Console.WriteLine(doubleVal * doubleVal);

// zastanów się skąd się bieże różnica

// wypisz na ekran wynik pola koła o promieniu równym radius
Console.WriteLine(Math.PI * Math.Sqrt(radius));

// W zmiennej time znajduje się czas w minutach. Oblicz wartości zmiennych hours, minutes i seconds na postawie zmiennej time.
int timeToHours = (int)time / 60;
int timeToMinuts = (int)time;
double timeToSeconds = (int)time * 60;
Console.WriteLine($"{timeToHours}, {timeToSeconds}");

/* koniec zadania 3 */



/* zadanie 4 */
int toIncrement = 3;
int toDivide = 5;
// wstaw do zmiennej toIncrement jej obecną wartość powiększoną o jeden (nie używając żadnej cyfry)
toIncrement++;
Console.WriteLine(toIncrement);
// wstaw do zmiennej toDivide jej obecną wartość podzieloną o nią samą (nie używając żadnej cyfry)
toDivide /= toDivide;
Console.WriteLine(toDivide);

/* koniec zadania 4 */



/* zadanie 5 */
double degree = 45;
double sinValue;
// do zmiennej sinValue przypisz wartość funkcji sinus dla zmiennej degree wyrażonej w stopniach
sinValue = Math.Sin(degree);
Console.WriteLine(sinValue);

/* koniec zadania 5 */



/* zadanie 6 */
int year = 2024;
int month = 5;
int day = 3;
int hour = 23;
int minute = 30;
// stwórz zmienną typu DateTime jako wartość złożoną z powyższych składowych
DateTime dt = new DateTime(year, month, day, hour, minute, 0);
Console.WriteLine(dt);

// następnie dodaj do niej 3 miesiące, odejmij 1 godzinę
dt.AddMonths(3);
dt.AddHours(-1);

// wypisz na ekran nazwę dnia tygodnia jaki przypada tego dnia
Console.WriteLine(dt.DayOfWeek);

/* koniec zadania 6 */



/* zadanie 7 */
string firstPart = "This is";
string secondPart = "a string";
string thirdPart = "with capital letters.";
// stwórz nową zmienną typu string jako złączenie powyższych.
// pamiętaj o brakujących odstępach
string allParts = (firstPart + " " + secondPart + " " + thirdPart);
Console.WriteLine(allParts);

// wypisz na ekran tekst nowej zmiennej DRUKOWANYMI LITERAMI
Console.WriteLine(allParts.ToUpper());

// oraz liczbę przedstawiającą długość tego ciągu znaków
Console.WriteLine(allParts.Length);

/* koniec zadania 7 */



/* zadanie 8 */
double lengthA = 5;
double lengthB = 1;
double lengthC = 3;
// zadeklaruj zmienną typu bool, przypisz do niej wartość mówiącą czy z powyższych 3 odcinków da się zbudować trójkąt
bool triangle = (lengthB + lengthC) < lengthA;
Console.WriteLine(triangle);

// jeśli tak, to sprawdź czy jest to trójkąt prostokątny (kolejna zmienna bool)
bool rightTriangle = Math.Sqrt(lengthA) == (Math.Sqrt(lengthB) + Math.Sqrt(lengthC));
Console.WriteLine(rightTriangle);

/* koniec zadania 8 */



/* zadanie 9 */
string conditionalString = "To be or not to be?";
// jeśli długość ciągu znaków jest większa niż 10 to wyświetl na ekran ten tekst
if (conditionalString.Length > 10)
{
    Console.WriteLine(conditionalString);
}

/* koniec zadania 9 */



/* zadanie 10 */
int temperature = 22;
// jeśli temperatura jest większa niż 20`C wyświetl "ciepło", w przeciwnym wypadku "zimno"
if (temperature > 20)
{
    Console.WriteLine("ciepło");
}
else
{
    Console.WriteLine("zimno");
}

/* koniec zadania 10 */



/* zadanie 11 */

if (temperature > 20) Console.WriteLine("ciepło");
else Console.WriteLine("zimno");

/* koniec zadania 11 */

/* zadanie 12 */
int code = 4;
int quantity = 11;
decimal productPrice = 3.5m;
decimal sellPrice;

if (code < 10) sellPrice = productPrice;
else if (code >= 10 && code <= 15) sellPrice = productPrice * 0.95m;
else if (code >= 16)
{
    if (quantity <= 10) sellPrice = productPrice * 1.05m;
    else if (quantity >= 11 && quantity <= 20) sellPrice = productPrice;
    else if (quantity > 20 && quantity <= 100)
    {
        if (quantity >= 20 && quantity <= 29) sellPrice = productPrice * 0.98m;
        if (quantity >= 30 && quantity <= 39) sellPrice = productPrice * 0.97m;
        if (quantity >= 40 && quantity <= 49) sellPrice = productPrice * 0.95m;
        if (quantity >= 50 && quantity <= 59) sellPrice = productPrice * 0.94m;
        if (quantity >= 60 && quantity <= 69) sellPrice = productPrice * 0.94m;
        if (quantity >= 70 && quantity <= 79) sellPrice = productPrice * 0.93m;
        if (quantity >= 80 && quantity <= 89) sellPrice = productPrice * 0.92m;
        if (quantity >= 90 && quantity <= 99) sellPrice = productPrice * 0.91m;
    }
    else sellPrice = quantity * 0.9m;
}

Console.WriteLine($"Price: {sellPrice}");
/* koniec zadania 12 */



/* zadanie 13 */
char hexNum = 'E';

switch (hexNum)
{
    case '0':
        Console.WriteLine($"Decimal number: 0");
        break;
    case '1':
        Console.WriteLine($"Decimal number: 1");
        break;
    case '2':
        Console.WriteLine($"Decimal number: 2");
        break;
    case '3':
        Console.WriteLine($"Decimal number: 3");
        break;
    case '4':
        Console.WriteLine($"Decimal number: 4");
        break;
    case '5':
        Console.WriteLine($"Decimal number: 5");
        break;
    case '6':
        Console.WriteLine($"Decimal number: 6");
        break;
    case '7':
        Console.WriteLine($"Decimal number: 7");
        break;
    case '8':
        Console.WriteLine($"Decimal number: 8");
        break;
    case '9':
        Console.WriteLine($"Decimal number: 9");
        break;
    // ...

    default:
        Console.WriteLine($"Not a valid hexadecimal number!");
        break;
}

/* koniec zadania 13 */