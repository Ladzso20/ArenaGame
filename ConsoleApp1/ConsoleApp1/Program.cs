namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Character Test = new Character("Test");
            Console.WriteLine(Test.GetDescription());
            Console.WriteLine("Test is alive"+Test.IsAlive());
            Console.WriteLine("Total number if Cahracter"+ Character.Count);

            Warrior w = new Warrior("w", 5);
            Console.WriteLine("Name: "+ w.Name);
            Console.WriteLine("Health: " + w.Health);
            Console.WriteLine("Armor: " + w.Armor);
            Console.WriteLine(w.GetDescription());

            Mage m = new Mage("m", 5);
            Console.WriteLine("Name: " + m.Name);
            Console.WriteLine("Health: " + m.Health);
            Console.WriteLine("Mana: " + m.Mana);
            Console.WriteLine(m.GetDescription());
            Console.WriteLine("Total number if Cahracter" + Character.Count);

        }
    }
}
