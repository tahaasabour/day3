using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TraineeComparer : IComparer
    {
        public int Compare(object x, object y)
        {
            Trainee first = x as Trainee;
            Trainee second = y as Trainee;

            return first.Id.CompareTo(second.Id);
        }
    }
}
