using model;
using System;

class Program
{

    static void Main()
    {


        

        Console.Write("Enter Users Number  ");
        int numUsers = int.Parse(Console.ReadLine());
        Trainee[] users = new Trainee[numUsers];

        //Get data from user 
        for (int i = 0; i < numUsers; i++)
        {
            Console.Write("User Id: ");
            int id = int.Parse(Console.ReadLine());
            Console.Write("User Name: ");
            string name = Console.ReadLine();
            users[i] = new Trainee(id, name);
        }



        while (true)
        {
            Console.Write("Add more users? (Y/N): ");
            string choice = Console.ReadLine();
            if (choice != "Y")
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

        Console.WriteLine("Sorted By ID:");
        foreach (var user in users)
        {
            Console.WriteLine(user);
        }

    }
}
