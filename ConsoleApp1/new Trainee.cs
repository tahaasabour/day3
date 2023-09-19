using Modules;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class new_Trainee : IComparer
    {
       public int Compare(object x, object y)
        {
            Trainee left = x as Trainee;
            Trainee right = y as Trainee;
            return left.Id.CompareTo(right.Id);
        }
       
    }
}
