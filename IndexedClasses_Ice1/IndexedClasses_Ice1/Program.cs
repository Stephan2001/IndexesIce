namespace IndexedClasses_Ice1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu(null, 50.00);
            Console.WriteLine("Food item: " + menu[0] + "   Price: R" + menu[1]);
        }
    }
}
