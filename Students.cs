using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_database
{
    abstract class Students: IComparable<Students>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string StudentEmail { get; set; }    
        public int ID { get; set; } 

        public Students(string name, int age, string email, int iD)
        {
            Name = name;
            Age= age;
            StudentEmail = email;
            ID = iD;
        }

        public override string ToString()
        {
            return $"The name of the student is {Name}, he or she is {Age} years with Student email {StudentEmail} and Student ID {ID}";
        }

        public int CompareTo (Students other)
        {
            return Name.CompareTo(other.Name);
        }
    }
}
