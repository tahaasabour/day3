using Models;
using System.Collections;
public class TraineeComparer : IComparer
{
    public int Compare(object? x, object? y)
    {
        Trainee left = x as Trainee;
        Trainee right = y as Trainee;

        return left.Id.CompareTo(right.Id);
    }
}
