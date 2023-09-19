using Modules;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Enter a number of objects you want to add into: ");
            int x= int.Parse(Console.ReadLine());
            Trainee[] arr = new Trainee[x];
            for (int i =0; i < x; i++) 
            {
                Console.WriteLine("Enter name : ");
                arr[i] = new Trainee();
                arr[i].Name = Console.ReadLine();
                Console.WriteLine("Enter ID");
                arr[i].Id = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("Your Added Trainees :");
            foreach(Trainee trainee in arr)
            {
                Console.WriteLine(trainee);
            }
            Console.WriteLine("Do you want to add more users ? (y/n):");
            string more=Console.ReadLine();
            Console.WriteLine(more);
            if (more =="y")
            {
                Console.WriteLine("Enter a number of objects you want to add into: ");
                int r = int.Parse(Console.ReadLine());
                Array.Resize(ref arr, arr.Length+r);
                for (int i = 0; i < x; i++)
                {
                    Console.WriteLine("Enter name : ");
                    arr[i] = new Trainee();
                    arr[i].Name = Console.ReadLine();
                    Console.WriteLine("Enter ID");
                    arr[i].Id = int.Parse(Console.ReadLine());

                }

            }




        }
    }
}


//Trainee trainee = new Trainee() { Id=1 , Name="Mohamed" };
//Trainee trainee2 = new Trainee() { Id = 2, Name = "Mostafa" };
//Console.WriteLine(trainee.ToString);
//Console.WriteLine(trainee2.ToString());
//Array.Sort(arr);
//Console.WriteLine(arr[0]);
//Console.WriteLine("slndkfnskdnf");
//Console.WriteLine(trainee.CompareTo(trainee2));