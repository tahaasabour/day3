using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;

namespace App
{
    internal class TraineeExtender : IComparer<Trainee>
    {
        public int Compare(Trainee? x, Trainee? y)
        {
            return x.CompareTo(y);
        }
    }
}
