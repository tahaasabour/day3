using System;
using System.Collections.Generic;
using Model;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Trainee> trainees = new List<Trainee>();

            Trainee trainee1 = new Trainee(2, "Farouk");
            Trainee trainee2 = new Trainee(1, "Omar");

            int comparisonResult = trainee1.CompareTo(trainee2);

            Console.WriteLine($"Comparison result: {comparisonResult}");
            Console.WriteLine(trainee1);
            Console.WriteLine(trainee2);


            while (true)
            {
                Console.WriteLine("How many Trainees do you want to add (0 to Out Of App)? ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0)
                    break;

                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine($"Enter Trainee {i} ID: ");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter Trainee {i} Name: ");
                    string name = Console.ReadLine();

                    Trainee trainee = new Trainee(id, name);
                    trainees.Add(trainee);
                }
            }

            trainees.Sort();

            Console.WriteLine("Sorted Trainees by ID:");
            foreach (var trainee in trainees)
            {
                Console.WriteLine(trainee.ToString());
            }
        }
    }
}



