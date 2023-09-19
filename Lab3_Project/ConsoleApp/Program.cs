using Models;
using System.Collections;
using System;
using System.Reflection.Metadata.Ecma335;

public class Trainee_comparable : IComparer
{
    public int Compare(object? x, object? y)
    {
        Trainee trainee1 = x as Trainee;
        Trainee trainee2 = y as Trainee;
        if (trainee1.Id > trainee2.Id) return 1;
        else if (trainee1.Id < trainee2.Id) return -1;
        else return 0;
    }
}
public class Program
{
    public static void Main()
    {
        Console.WriteLine("How many users he/she want to add.");
        int size= Int32.Parse(Console.ReadLine());
        Trainee[] trainees = new Trainee[size];
        getusers(trainees, 0);
        Console.WriteLine("Do you want more user?");
        string value=Console.ReadLine();
        switch(value)
        {
            case "Y":
            case"y":
                {
                    int persize = trainees.Length;
                    Console.WriteLine("Size:");
                    int newsize = Int32.Parse(Console.ReadLine());
                    Array.Resize(ref  trainees, persize+newsize);
                        getusers(trainees,persize);    
                }
                break;
            default:
                {
                  
                }
                break;

        }
        
        Array.Sort(trainees);
        foreach (Trainee t in trainees)
        {
            Console.WriteLine(t);
        }
    }
    public static void getusers(Trainee[]trainees,int start)
    {
        for (int i = start; i < trainees.Length; i++)
        {
            Trainee t = new Trainee();
            Console.WriteLine("Enter id:");
            t.Id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            t.Name = Console.ReadLine();
            trainees[i] = t;
        }
    }

}