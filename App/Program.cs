using System;
using App;
using Models;

public class Program
{
    public static void Main()
    {
        int arraySize;
        Console.WriteLine("Enter how many users you want to add?");
        arraySize = int.Parse(Console.ReadLine());
        Trainee[] arr = new Trainee[arraySize];
        for (int i = 0; i < arraySize; i++)
        {
            Trainee t = new Trainee();
            Console.WriteLine("Enter Trainee Id: ");
            t.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Trainee name: ");
            t.Name = Console.ReadLine();
            arr[i] = t;
        }
        Array.Sort(arr);
        Selection( arr);
    }

    public static void Selection( Trainee[] arr)
    {
        Console.WriteLine("1-Add More Trainee\n2-Show Trainees");

        switch (Console.ReadLine())
        {
            case "1":
                {
                    Console.Clear();
                    Array.Resize(ref arr, arr.Length + 1);
                    Console.WriteLine("Enter Trainee Id: ");
                    arr[arr.Length - 1] = new Trainee();
                    arr[arr.Length-1].Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Trainee name: ");
                    arr[arr.Length-1].Name = Console.ReadLine();
                    Array.Sort(arr, new TraineeComparer());
                    Selection( arr);
                }
                break;
            case "2":
                {
                    foreach (Trainee t in arr)
                    {
                        Console.WriteLine(t.ToString());
                    }
                    Selection( arr);
                }
                break;
        }

    }

}