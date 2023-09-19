using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{

   
    public class Trainee : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }

      

        public int CompareTo(object? obj)
        {
            Trainee tran=obj as Trainee;
            return id.CompareTo(tran.id);
        }

        public override string ToString()
        {
            return $"{id} -----{name}";
        }

    }

    public class TraineeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Trainee left = x as Trainee;
            Trainee right = y as Trainee;

            return left.id.CompareTo(right.id);
        }
    }
}
