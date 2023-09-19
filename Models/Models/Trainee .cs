namespace Models
{
    public class Trainee : IComparable;
    {    public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
     
    }
}
}



































// Trainee.cs in the Models project
//using System;

//namespace Models
//{
//    public class Trainee : IComparable<Trainee>
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }

//        public Trainee(int id, string name)
//        {
//            Id = id;
//            Name = name;
//        }

//        public override string ToString()
//        {
//            return $"Id: {Id}, Name: {Name}";
//        }

//        public int CompareTo(Trainee other)
//        {
//            return Id.CompareTo(other.Id);
//        }
//    }
//}



























