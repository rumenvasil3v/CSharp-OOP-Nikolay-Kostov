namespace Inheritance___Derived_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(new Mother("Monica", 39), new Father("Stoyan", 40), "Rumen", 17);
            student.Father.Mother = new Mother("Ginka", 60);
            student.Father.Father = new Father("Rumen", 60);

            student.Mother.Mother = new Mother("Rumyana", 60);
            student.Mother.Father = new Father("Hristo", 60);
            Console.ReadKey();
        }
    }

    public class Person
    {
        private Mother mother;
        private Father father;
        private string name;
        private byte age;

        public Person() { }

        public Person(string name, byte age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(Mother mother, Father father, string name, byte age)
        {
            this.Mother = mother;
            this.Father = father;
            this.Name = name;
            this.Age = age;
        }

        public Mother Mother { get { return mother; } set {  mother = value; } }

        public Father Father { get { return father; } set {  father = value; } }

        public string Name { get { return name; } set { name = value; } }

        public byte Age { get { return age; } set { age = value; } }
    }

    public class Mother : Person
    {
        public Mother(string name, byte age)
            : base(name, age)
        { 

        }
    }

    public class Father : Person
    {
        public Father(string name, byte age)
            : base(name, age)
        {

        }
    }

    public class Student : Person
    {
        public Student(Mother mother, Father father, string name, byte age)
            : base(mother, father, name, age)
        {

        }

        public string University { get; set; }
    }

    public class Employee : Person
    {
        public Employee(Mother mother, Father father, string name, byte age)
            : base(mother, father, name, age)
        {

        }

        public string Company { get; set; }

        public string Contract { get; set; }
    }
}