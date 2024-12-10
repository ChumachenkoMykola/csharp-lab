using ConsoleApp1;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp3
{
    internal class Program
    {
        static (int min, int max) GetMinMax(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                throw new ArgumentException("Массив не может быть пустым или null.");
            }

            int min = numbers[0]; // Инициализируем min первым элементом массива
            int max = numbers[0]; // Инициализируем max первым элементом массива

            foreach (int i in numbers)
            {
                if (i < min)
                {
                    min = i;
                }
                if (i > max)
                {
                    max = i;
                }
            }
            return (min, max);
        }
        public class Person
        {
            public Person(string name, string surname, DateTime birthDate)
            {
                Name = name;
                Surname = surname;
                BirthDate = birthDate;
            }

            //properties
            public string Name { get; set; }
            public string Surname { get; set; }
            public DateTime BirthDate { get; set; }
            public string EmailAddress { get; set; }

            // methods
            public string GetFullName()
            {
                return $"{Name} {Surname}";
            }
            public int GetAge()
            {
                return (int)(DateTime.Now - this.BirthDate).TotalDays - 365;
            }
            public bool IsAdult()
            {
                return (GetAge() > 18);
            }
        }

        static void Main(string[] args)
        {
            #region Zadane 1
            Coords pointA = new Coords(0, 0);
            Coords pointB = new Coords(3, 7);
            Coords pointC = new Coords(2, -0.5);
            Coords pointD = new Coords(6, -1);
            Coords pointE = new Coords(9, 6);
            Coords[] points = { pointA, pointB, pointC, pointD, pointE };
            double result = 0;

            for (int i = 0; i < points.Length - 1; i++)
            {
                Coords A = points[i];
                Coords B = points[i + 1];
                result += Math.Sqrt(Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2));
            }

            Console.WriteLine(result);
            #endregion

            #region Zadanie 2
            int[] numbers = { 1, 2, 6, 3, 5, 8 };
            (int min, int max) minMax = GetMinMax(numbers);
            Console.WriteLine($"Min: {minMax.min}, max: {minMax.max}");
            #endregion

            #region Zadanie 3
            string BitrhDate = "11-10-2006";
            Person person = new Person("Mykola", "Chumachenko", DateTime.Parse(BitrhDate));
            #endregion
        }
    }
}
