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

        int IComparable.CompareTo(object obj)
        {
            Trainee T = obj as Trainee;
            return Id.CompareTo(T.Id);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}