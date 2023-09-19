namespace Models
{

    public class Trainee : IComparable
    {
        //public Trainee(int id, string? name)
        //{
        //    Id = id;
        //    Name = name;
        //}

        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            Trainee T = obj as Trainee;

            return Id.CompareTo(T.Id);
        }

        public override string ToString()
        {
            return $"Id {Id}  {Name}";
        }
    }


}