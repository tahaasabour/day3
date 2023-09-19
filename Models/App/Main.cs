using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Main2
    {
        public static void Main()
        {
            Console.WriteLine("how many users you want to add?");
            int UserInput = int.Parse(Console.ReadLine());

            Trainee[] users = new Trainee[UserInput];

           for (int i = 0; i < UserInput; i++)
            {
                Trainee trainee = new Trainee();
                Console.WriteLine($"Enter data for Trainee {i + 1}:");

                Console.Write("Enter Trainee ID: ");
                trainee.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Trainee Name: ");
                trainee.Name = Console.ReadLine();

                users[i] = trainee;
            }
            Array.Sort(users);

            Console.WriteLine("List of Trainees:");
            foreach (Trainee trainee in users)
            {
                Console.WriteLine(trainee.ToString());
            }
            Console.WriteLine("\n------------------------------------------------");
            Console.WriteLine("do you want to add more other users \n 1:yes  2:No");
            int answer = int.Parse( Console.ReadLine());

            switch (answer)
            {
                case 1:
                    Array.Resize(ref users, users.Length + 1);
                    Trainee trainee = new Trainee();
                    Console.WriteLine($"Enter data for Trainee {users.Length}:");

                    Console.Write("Enter Trainee ID: ");
                    trainee.Id = int.Parse(Console.ReadLine());

                    Console.Write("Enter Trainee Name: ");
                    trainee.Name = Console.ReadLine();

                    users[users.Length -1] = trainee;

                    Array.Sort(users);

                    foreach (Trainee trainee2 in users)
                    {
                        Console.WriteLine(trainee2.ToString());
                    }
                    break;

                case 2:
                    foreach (Trainee trainee3 in users)
                    {
                        Console.WriteLine(trainee3.ToString());
                    }
                break;
            }
        }
    }
}
