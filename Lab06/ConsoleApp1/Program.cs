namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadanie 1
            Person p1 = new Person();
            Person p2 = new Person();
            Relate(p1, p2);
        }
        public static void Relate(Person p1, Person p2)
        {
            p1.Partner = p2;
            p2.Partner = p1;
        }
    }
}