using Module6.Unit2.Models;

namespace Module6.Unit2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human();
            human.Greetings();

            human = new Human("Dmitry");
            human.Greetings();

            human = new Human("Dmitry", 33);
            human.Greetings();

            human = new Human { name = "Дмитрий", age = 23 };
            human.Greetings();
        }
    }
}
