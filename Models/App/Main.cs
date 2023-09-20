using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    internal class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter Count for Users to Insert?");
            int newUser = int.Parse(Console.ReadLine());

            Trainee[] users = new Trainee[newUser];

           for (int i = 0; i < newUser; i++)
            {
                Trainee t = new Trainee();
                Console.WriteLine($"Enter Trainee's data {i + 1}:");

                Console.Write("Enter Trainee ID: ");
                t.Id = int.Parse(Console.ReadLine());

                Console.Write("Enter Trainee Name: ");
                t.Name = Console.ReadLine();

                users[i] = t;
            }
            Array.Sort(users);

            Console.WriteLine("List of Trainees:");
            foreach (Trainee t in users)
            {
                Console.WriteLine(t.ToString());
            }
           
            Console.WriteLine("more users? \n 1:Y  2:N");
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
