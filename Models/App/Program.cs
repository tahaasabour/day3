using Models;

namespace App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many users U want to add");
            int usersnumber = int.Parse(Console.ReadLine());
            int index = usersnumber - 1;
            Trainee[] newtrainees;
            Trainee[] trainees = new Trainee[usersnumber]; 
            while(index >= 0)
            {
                Trainee trainee = new Trainee();
                Console.WriteLine("Enter User Name");
                trainee.Name = Console.ReadLine();

                Console.WriteLine("Enter User ID");
                trainee.Id = int.Parse(Console.ReadLine());

                trainees[index] = trainee;
                index--;
            }

            Array.Sort(trainees);   
            foreach(var item in trainees)
                Console.WriteLine(item);

            Console.WriteLine("Add More Users?, choose a number \n1- Yes\n2-No");
            int result = int.Parse(Console.ReadLine());
            if (result == 1)
            {
                Console.WriteLine("Enter the new users number");
                int num = int.Parse(Console.ReadLine());
                int newsize = usersnumber + num;
                newtrainees = new Trainee[newsize];
                Array.Copy(trainees, newtrainees, trainees.Length);
                while (usersnumber < newsize)
                {
                    Trainee trainee = new Trainee();
                    Console.WriteLine("Enter User Name");
                    trainee.Name = Console.ReadLine();

                    Console.WriteLine("Enter User ID");
                    trainee.Id = int.Parse(Console.ReadLine());
                    newtrainees[usersnumber] = trainee;
                    usersnumber++;
                }
                Array.Sort(newtrainees);
                foreach (var item in newtrainees)
                    Console.WriteLine(item);
            }
        }

    }
}