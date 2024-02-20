using System.ComponentModel.Design;
using System.Diagnostics;

namespace StarLinux
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Star Linux!");
            Console.WriteLine("To get list of commands type help");
            Console.WriteLine("but, write your name first");
            string name = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Hello " + name + "!");

            string help = Console.ReadLine();

            if (help == "help")
            {

                Console.WriteLine("commands: joke1, joke2, random_num");

            }
            else
            {
                Console.WriteLine("wrong command");
            };

            string command = Console.ReadLine();

            if (command == "joke1")
            {

                Console.WriteLine("why chicken crossed the road?");

                Console.WriteLine("why?");

                Console.WriteLine("...");

            }
            else if (command == "joke2")
            {
                Console.WriteLine("knock knock");

                Console.WriteLine("who's there?");

                Console.WriteLine("chicken :)");

                Console.WriteLine("READ JOKE 1");
            }
            else if (command == "random_num")
            {

                Console.WriteLine("i'll write you random number between 1 and 199999");

                Random random = new Random();

                int num = random.Next(1, 199999);

                Console.WriteLine(num);

            }
            else
            {
                Console.WriteLine("wrong command");
            }
            

            Console.ReadKey();
        }
    }
}
