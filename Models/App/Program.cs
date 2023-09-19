using Models; 

using System;
namespace Models
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many trainees do you want to add?");
            int count = int.Parse(Console.ReadLine());
            Trainee[] users = new Trainee[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter details for Trainee {i + 1}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                users[i] = new Trainee { Id = id, Name = name };
            }

            Array.Sort(users);

            Console.WriteLine("\nEntered Data:");
            foreach (var user in users)
            {
                Console.WriteLine(user.ToString());
            }
        }
    }
}
