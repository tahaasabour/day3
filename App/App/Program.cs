using Models;
using System;
namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Number Of Users ?");
            var usersInput = int.Parse(Console.ReadLine());
            Trainee[] users;
            if (usersInput > 0){
                users = new Trainee[usersInput];
                for (int i = 0; i < usersInput; i++)
                {
                    Console.Write($"Enter User Id: ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write($"Enter User Name: ");
                    string name = Console.ReadLine();
                    users[i] = new Trainee() { Id=id, Name= name};
                }
            }
            else
            {
                Console.WriteLine("Enter Number Great Than 0");
                return;
            }
            while (true)
            {
                Console.Write(" To Add More Users Press (yes) If Not Press (no). ");
                string choice = Console.ReadLine().ToLower();
                if (choice != "yes")
                    break;
                Console.Write("Enter User Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Enter User Name: ");
                string name = Console.ReadLine();
                Array.Resize(ref users, users.Length+1);
                users[users.Length-1] = new Trainee() { Id = id, Name = name };
            }
            Array.Sort(users);
            Console.WriteLine("\nEntered User Data (sorted by Id):");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        }
    }
}

