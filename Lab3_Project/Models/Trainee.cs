namespace Models
{
    public class Trainee :IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object? obj)
        {
            Trainee trainee = obj as Trainee;
            return this.Id.CompareTo(trainee.Id);

        }

        public override string ToString()
        {
            return $"ID:{Id},Name:{Name}";

        }

    }
}