using System;
namespace Задача2
{
    class Program
    {
        static void Main()
        {
            string name, colour, gender;
            int age;
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter colour of the eyes");
            colour = Console.ReadLine();
            Console.WriteLine("Enter gender:");
            gender = Console.ReadLine();
            Console.WriteLine("Name:{0}", name);
            Console.WriteLine("Age:{0}", age);
            Console.WriteLine("Colour:{0}", colour);
            Console.WriteLine("Gender:{0}", gender);
        }
    }
}
