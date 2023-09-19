//using Models; //Implicitly Used :v
using Models;
using System.Collections;

namespace App
{
    public class TraineeComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Trainee LeftSide = (Trainee)x;
            Trainee RightSide = (Trainee)y;
            return LeftSide.Id.CompareTo(RightSide.Id);
        }
    }
}