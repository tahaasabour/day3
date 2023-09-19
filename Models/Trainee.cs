using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    public class Trainee : IComparable
    {
        public Trainee(int id, string? name)
        {
            this.id = id;
            Name = name;
        }

        public string Name { get; set; }
        public int id { get; set; }



        public int CompareTo(object? obj)
        {
            Trainee t = obj as Trainee;
            return id.CompareTo(t.id);
        }

        public override string ToString()
        {
            return $"{id}  {Name}";

        }
    }
}
