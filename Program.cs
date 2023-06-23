namespace SecondTutorial
{
    class Program
    {
        static void Main(string[] args) {
            
            UsefulTools.SayHi("Mike");

            // INHERITANCE
            Chef chef1 = new Chef();
            chef1.MakeChicken();
            chef1.MakeSalad();
            chef1.MakeSpecialDish();

            ItalianChef chef2 = new ItalianChef();
            chef2.MakeChicken();
            chef2.MakePasta();
            string name = "ABC";
            Console.WriteLine($"The name is {name}");
            Console.WriteLine("The name is {0}", name);
        }
    }
}