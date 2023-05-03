using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_database
{
    internal class Masters: Students
    {
        public string Degree { get; set; }

        public Masters(string name, int age, string email, int iD, string degree)
            : base(name, age, email, iD)
        {
            Degree = degree;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}. He/ she is studying for a {Degree}";
        }
    }
}
 