using Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public  class Class1
    {
        public void AddTrainees()
        {
            Console.WriteLine("Enter a number of objects you want to add into: ");
            int x = int.Parse(Console.ReadLine());
            Trainee[] arr = new Trainee[x];
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
