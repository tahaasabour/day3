using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module
{
   
    public class trainee:IComparable
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }


    }

    public class traineeCompararple : IComparer
    {
        public int Compare(object? x, object? y)
        {
            trainee left = x as trainee;
            trainee right = y as trainee;

            return left.Id.CompareTo(right.Id);
        }
    }
}
