namespace ConsoleApp1
{
    internal class Program
    {
        public static DayOfWeek day = DayOfWeek.Monday;
        static void Main(string[] args)
        {
            //Zadanie 1    
            double QuadraticEquation(double x = 0.0, double a = 1.0, double b = 1.0, double c = 1.0)
            {
                return a * (Math.Pow(x, 2)) + b * a + c;
            }
            Console.WriteLine(QuadraticEquation(2, 1, 4, -3));

            //Zadanie 2
            void Swap(ref double a, ref double b)
            {
                double temp = a;
                a = b;
                b = temp;
            }
            double x = 10;
            double y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"x = {x}, y = {y}");

            //Zadanie 4            
            string dayIsWeekend;
            if (day == DayOfWeek.Saturday || day == DayOfWeek.Sunday) dayIsWeekend = "Weekend";
            else dayIsWeekend = "Weekday";
            Console.WriteLine($"Day of week: {day} = {(int)day + 1}, {dayIsWeekend}");

            //Zadanie 5
            DateTime Date = new DateTime();
            Console.WriteLine($"{Date.Day}...{Date.Month}...{Date.Year}...{Date.Hour}:{Date.Minute}:{Date.Second}...{Date.DayOfWeek}");

            //Zadanie 6
            static double Divide(double a, double b)
            {
                if (b == 0.0)
                {
                    throw new DivideByZeroException("Błąd: dzielenie przez 0");
                }

                else return a / b;
            }
            static double SafeDivide(double a, double b)
            {
                double result;
                try
                {
                    result = Divide(a, b);
                }
                catch (DivideByZeroException ex)
                {
                    result = 0.0;
                }

                return result;
            }
            Console.WriteLine(SafeDivide(2, 0));

            //Zadanie 7
            Console.WriteLine($"Set your password:");
            Console.WriteLine(SetYourNewPassword(Console.ReadLine()));
            static string SetYourNewPassword(string password)
            {
                bool goodPassword = false;
                bool hasDigit = false;
                bool hasSpecialSymbols = false;
                if (password == "")
                    throw new ArgumentException("Password is empty");

                foreach (var v in password)
                {
                    if (char.IsDigit(v)) hasDigit = true;
                    if (!char.IsLetterOrDigit(v)) hasSpecialSymbols = true;
                }

                if (password == password.ToLower()) goodPassword = false;

                if (password == password.ToUpper()) goodPassword = false;

                if (password.Length < 10) goodPassword = false;

                if (hasDigit == false || hasSpecialSymbols == false) goodPassword = false;

                else goodPassword = true;

                if (goodPassword == true) return ("Password is strong");
                else return ("The password must contain a special sybol, digit, capital letter and uppercase letter.");
            }
        }
    }
}
