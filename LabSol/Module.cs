namespace LabSol_
{
    public class Trainee : IComparable
    {

        public Trainee() { id = 0; name = ""; }
        public int id { get; set; }
        public string name { get; set; }

        int IComparable.CompareTo(object obj)
        {
            Trainee T = obj as Trainee;

            return this.id.CompareTo(T.id);
        }

        public override string ToString()
        {
            return $"{id} {name}";
        }

    }
}