namespace module
{
    public class Trainee : IComparable
    {
        public int id { get; set; }
        public string name { get; set; }

        int IComparable.CompareTo(object obj)
        {
            Trainee T = obj as Trainee;

            return id.CompareTo(T.id);
        }

        public override string ToString()
        {
            return $"{id} {name}";
        }
    }
}