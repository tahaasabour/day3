using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Trainee : IComparable<Trainee>
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(Trainee trainee)
        {
            return Id.CompareTo(trainee.Id);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}";
        }
    }
}
