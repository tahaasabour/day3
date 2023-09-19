

using Models;
using System.Collections;
using System.Collections.Immutable;

public class Program {

    public  class traineeCompare : IComparer{

        public int Compare(object x, object y) { 
            Trainee t1 = x as Trainee;
            Trainee t2 = y as Trainee;

            return t1.Id.CompareTo(t2.Id);

        }
    }

    static void Main()
    {
        Console.WriteLine("Enter How Many User You want to add");
        int users = Int32.Parse(Console.ReadLine()); 
        Trainee[] trainees = new Trainee[users] ;

        for (int i = 0; i < users; i++)
        {
            trainees[i] = new Trainee();
            Console.WriteLine("Enter Name");
            trainees[i].Name = Console.ReadLine();
            Console.WriteLine("Enter Id");
            trainees[i].Id = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter new size");
        Array.Resize(ref trainees, Int32.Parse(Console.ReadLine()));

        Array.Sort(trainees);

        foreach (Trainee trainee in trainees)
        {
            Console.WriteLine(trainee);
        }


    }
}
