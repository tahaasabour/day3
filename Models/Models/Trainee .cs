using System;

namespace Models
{
    public class Trainee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            Trainee other = obj as Trainee;
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
}
   
