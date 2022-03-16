using System;

namespace Task_2
{
    class StudentsGroup
    {
        static void Main(string[] args)
        {
            string[] studentsGOne = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsGTwo = { "Zoki", "Mile", "Brus", "Petko", "Vele" };

            Console.WriteLine("Enter student group: ( there are 1 and 2 )");

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("The Students in G1 are:");
                    foreach (string name in studentsGOne)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                case "2":
                    Console.WriteLine("The Students in G2 are:");
                    foreach (string name in studentsGTwo)
                    {
                        Console.WriteLine(name);
                    }
                    break;
                default:
                    Console.WriteLine("You did not enter a valid group (1 or 2)!");
                    break;
            }
        }
    }
}
