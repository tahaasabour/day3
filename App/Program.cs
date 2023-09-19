using model;
using System;

class Program
{
     
    static void Main()
    {

   
        Trainee[] users = null;

        Console.Write("Enter the number of users to add: ");
        int numUsers = int.Parse(Console.ReadLine());

        if (numUsers > 0)
        {
            users = new Trainee[numUsers];
            for (int i = 0; i < numUsers; i++)
            {
                Console.Write($"Enter User {i + 1} Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write($"Enter User {i + 1} Name: ");
                string name = Console.ReadLine();
                users[i] = new Trainee(id, name);
            }
        }

        while (true)
        {
            Console.Write("Do you want to add more users? (yes/no): ");
            string choice = Console.ReadLine().ToLower();
            if (choice != "yes")
                break;

            Console.Write("Enter User Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter User Name: ");
            string name = Console.ReadLine();

            Trainee[] newUsers = new Trainee[users.Length + 1];

            for (int i = 0; i < users.Length; i++)
            {
                newUsers[i] = users[i];
            }

            newUsers[newUsers.Length - 1] = new Trainee(id, name);

            users = newUsers;
        }

        
            Array.Sort(users);

            Console.WriteLine("\nEntered User Data (sorted by Id):");
            foreach (var user in users)
            {
                Console.WriteLine(user);
            }
        
    }
}
