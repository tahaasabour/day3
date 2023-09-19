using module;
namespace App
{
    public class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("How many user you want to add");
                int num = int.Parse(Console.ReadLine());
                Trainee[] trainees = new Trainee[num];
                for (int i = 0; i < num; i++)
                {
                    Trainee ti = new Trainee();
                    Console.WriteLine("Trainee name");
                    ti.name = Console.ReadLine();
                    Console.WriteLine("Trainee ID");
                    ti.id = int.Parse(Console.ReadLine());
                    trainees[i] = ti;
                }
                foreach (Trainee ti in trainees)
                {
                    Console.WriteLine(ti.ToString()); 
                }

                Array.Sort(trainees);


                Console.WriteLine("add more extraTrainees");
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


                foreach (Trainee T in trainees)
                {
                    Console.WriteLine(T.ToString());
                }
            }




        }



    }
        }
   