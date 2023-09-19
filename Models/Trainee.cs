using System;

namespace Models
{
    public class Trainee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            Trainee T = obj as Trainee;
            return this.Id.CompareTo(T.Id);
        }

        public override string ToString()
        {
            return $"ID ==> {Id}, Name ==> {Name}";
        }
    }
}