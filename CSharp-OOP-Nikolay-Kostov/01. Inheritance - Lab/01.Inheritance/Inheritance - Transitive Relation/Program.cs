namespace Inheritance___Transitive_Relation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var collegeStudent = new CollegeStudent();
            Console.ReadKey();
        }
    }

    public class Person
    {
        public Person()
        {

        }

        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class Student : Person
    {
        public Student()
        {

        }

        public School School { get; set; }
    }

    public class CollegeStudent : Student
    {
        public CollegeStudent()
        {

        }

        public double Ball { get; set; }
    }

    public class School
    {
        public School()
        {

        }

        public string Name { get; set; }

        public Dictionary<string, string> Courses { get; set; }
    }
}