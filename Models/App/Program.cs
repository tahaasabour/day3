using Models;
using System.Collections;
using System.Xml.Linq;

public class TraineeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        Trainee left = x as Trainee;
        Trainee right = y as Trainee;

        return left.Id.CompareTo(right.Id);
    }
}
public class Program
{

    public static void Main()
    {
        Console.WriteLine("How many users you want to add?");
        int x= int.Parse(Console.ReadLine());

        Trainee[] Ts = new Trainee[x];
     for (int i=0;i<Ts.Length;i++)
        {
            Ts[i] = new Trainee();
            Console.WriteLine("Enter name");
            Ts[i].Name=Console.ReadLine();
            Console.WriteLine("Enter id");
            Ts[i].Id = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter new size: ");
        int y= int.Parse(Console.ReadLine());
        Array.Resize(ref Ts, y);

        Array.Sort(Ts);
        //Array.Sort(Ts, new TraineeComparer());

        foreach (Trainee i in Ts)
            Console.WriteLine(i);

       

        
       


    }
}
