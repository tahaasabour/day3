using System;

namespace Model
{
    public class Trainee : IComparable<Trainee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Trainee(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(Trainee other)
        {
            return Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"Trainee(Id: {Id}, Name: {Name})";
        }
    }
}
