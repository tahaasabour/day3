//using Models; //Implicitly Used :v
using Models;
using System;
using System.Collections;

namespace App
{
    public class Program
    {
        private static Trainee[] Trainees = new Trainee[0];
        static void Main()
        {
            //Ask the user for how many *trainees* he/she want to add.

            Console.WriteLine("How many trainees do you want to add ?");
            int HowManyUsers = int.Parse(Console.ReadLine());
            Array.Resize(ref Trainees, HowManyUsers);
            for (int i = 0; i < HowManyUsers; i++)
            {
                Console.WriteLine($"Enter trainee number {i + 1} data as ID then Name");
                Trainees[i] = new Trainee
                {
                    Id = int.Parse(Console.ReadLine()),
                    Name = Console.ReadLine()
                };
            }
            PrintTrainees();

            AddMoreTrainees();
        }

        static void AddMoreTrainees()
        {
                Console.WriteLine("1- Add More Trainees?");
                Console.WriteLine("2- End Program");
                int EndProgram = int.Parse(Console.ReadLine());
                switch (EndProgram)
                {
                    case 1:
                        {
                        Console.WriteLine("Add Trainee Information As ID Then Name");
                        Array.Resize(ref Trainees, Trainees.Length + 1);
                            Trainees[Trainees.Length - 1] = new Trainee
                            {
                                Id = int.Parse(Console.ReadLine()),
                                Name = Console.ReadLine()
                            };
                            PrintTrainees();
                            AddMoreTrainees();
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        

        static void PrintTrainees()
        {

            Array.Sort(Trainees);
            foreach (Trainee t in Trainees)
            {
                Console.WriteLine(t);
            }
        }
    }

}