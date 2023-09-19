namespace Models
{
    public class Trainee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return Id.CompareTo(((Trainee)obj).Id);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}