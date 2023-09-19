using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainee : IComparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"{this.Id} , {this.Name}";
        }

        int IComparable.CompareTo(object obj)
        {
            Trainee t = obj as Trainee;
            return Id.CompareTo(t.Id);
        }
    }
}
