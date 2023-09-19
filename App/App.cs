using Model;

namespace App
{
    public class App
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number of Trainee");
            int traineeNo = int.Parse(Console.ReadLine());
            Trainee[] trainees = new Trainee[traineeNo];

            for (int i = 0; i < traineeNo; i++)
            {
                trainees[i] = new Trainee();
                Console.WriteLine("Enter Name");
                trainees[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Id");
                trainees[i].Id = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"first length{trainees.Length}");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("if you want to add more enter the new number of trainee");
            int newLength = int.Parse(Console.ReadLine());
            Array.Resize(ref trainees, newLength+traineeNo);
            for (int i = traineeNo; i < newLength+traineeNo; i++)
            {
                trainees[i] = new Trainee();
                Console.WriteLine("Enter Name");
                trainees[i].Name = Console.ReadLine();
                Console.WriteLine("Enter Id");
                trainees[i].Id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine();
            }
            Array.Sort(trainees);

            Console.WriteLine($"second length{trainees.Length}");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (Trainee trainee in trainees)
            {
                Console.WriteLine(trainee);
            }
        }
    }
}

