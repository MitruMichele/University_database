namespace Student_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database students = new Database();
            students+= new Masters("John", 23, "john@school.uni", 345, "MSc");
            students += new Masters("Mary", 23, "mary@school.uni", 567, "MBa");
            students += new Bachelors("Anna", 19, "anna@Uni.school", 234, 4);
            students += new Bachelors("Michele", 25, "michele21@uni.school", 589, 5);

            //Console.WriteLine(students);

            //students.Sort();
            //Console.WriteLine("List of Students include: ");
            //Console.WriteLine(students);

            students.SaveEmployeesInJSON("list of students.json");
            Database studentloaded = students.RestoreListFromJSON("list of students.json");
            Console.WriteLine(studentloaded);
        }
    }
}