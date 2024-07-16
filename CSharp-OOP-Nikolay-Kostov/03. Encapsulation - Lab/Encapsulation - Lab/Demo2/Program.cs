namespace Demo2
{
    public class Person
    {
        private string firstName;

        public Person(string name)
        {
            SetFirstName(name);
        }
        
        // Encapsulation achieved using those methods in Java and C++
        public void SetFirstName(string value)
        {
            firstName = value;
        }

        public string GetFirstName()
        {
            return firstName;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}