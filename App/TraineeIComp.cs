using System;
using System.Collections;
using Models;

namespace App
{
    public class TraineeComparer : IComparer
    {
        public int Compare(object first, object second)
        {
            Trainee left = first as Trainee;
            Trainee right = second as Trainee;

            return left.Id.CompareTo(right.Id);
        }
    }
}

