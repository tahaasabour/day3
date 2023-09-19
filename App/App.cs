using LabSol_;
using System;

namespace Lab
{
    public class App
    {
        static void Main()
        {
            Console.WriteLine("How many user you want to add ?");
            int num = int.Parse(Console.ReadLine());
            Trainee[] trainees = new Trainee[num];

            for (int i = 0; i < num; i++)
            {
                Trainee ti = new Trainee();
                Console.WriteLine("Enter Trainee name");
                ti.name = Console.ReadLine();
                Console.WriteLine("Enter Trainee ID");
                ti.id = int.Parse(Console.ReadLine());
                trainees[i] = ti;
            }
            foreach(Trainee T in trainees)
            {
                Console.WriteLine(T.ToString());
            }

            Console.WriteLine("Enter the number of extra traines");
            int extraTrainees = int.Parse(Console.ReadLine());

            Array.Resize(ref trainees, trainees.Length + extraTrainees);

            if (extraTrainees > 0)
            {
                for (int i = 0; i < extraTrainees; i++)
                {
                    Trainee ti = new Trainee();
                    Console.WriteLine("Enter Trainee name");
                    ti.name = Console.ReadLine();
                    Console.WriteLine("Enter Trainee ID");
                    ti.id = int.Parse(Console.ReadLine());
                    trainees[extraTrainees + i] = ti;
                }
            }

            foreach (Trainee T in trainees)
            {
                Console.WriteLine(T.ToString());
            }

            Array.Sort(trainees);


            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (Trainee T in trainees)
            {
                Console.WriteLine(T.ToString());
            }
        }




    }
}