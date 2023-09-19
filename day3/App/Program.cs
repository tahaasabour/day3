using Models;

namespace App
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Trainee[] users;
            Console.WriteLine("Enter users number");
            int number = int.Parse(Console.ReadLine());
            users = new Trainee[number];

            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Enter user {i + 1} id:");
                int id = int.Parse(Console.ReadLine());

                Console.WriteLine($"Enter user {i + 1} name:");
                string name = Console.ReadLine();

                users[i] = new Trainee() { Id = id, Name = name };
            }

            string flag;
            do
            {
                Console.WriteLine("Do you want to add more? (y/n)");
                flag = Console.ReadLine();
                if (flag.ToLower() == "y")
                {
                    Array.Resize(ref users, users.Length + 1);

                    Console.WriteLine($"Enter user {users.Length} id:");
                    int id = int.Parse(Console.ReadLine());

                    Console.WriteLine($"Enter user {users.Length} name:");
                    string name = Console.ReadLine();

                    users[users.Length-1] = new Trainee() { Id = id, Name = name };
                }
            }
            while (flag.ToLower() == "y");


            Array.Sort(users);
            Console.WriteLine("Users after sorting:");
            foreach (Trainee user in users)
            {
                Console.WriteLine($"{user.Id}, {user.Name}");
            }
        }
    }
}