namespace Models
{
    public class Trainee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
        int IComparable.CompareTo(object obj)
        {
            Trainee T = obj as Trainee;

            return Id.CompareTo(T.Id);

        }
    }
}