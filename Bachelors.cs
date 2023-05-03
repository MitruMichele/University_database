using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_database
{
    internal class Bachelors: Students
    {
        public int No_of_study_year { get; set; }   

        public Bachelors (string name, int age, string email, int iD, int year)
            :base(name, age, email, iD)
        {
            No_of_study_year = year;
        }

        public override string ToString()
        {
            return $"{base.ToString()}. He/she is studying for {No_of_study_year} years." ;
        }
    }
}
