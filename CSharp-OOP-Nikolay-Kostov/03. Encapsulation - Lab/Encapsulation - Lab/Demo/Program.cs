namespace Demo
{
    // read only class (immutable)
    public class Person
    {
        private decimal salary;
        private int jobDoneCounter;

        public Person() 
        {
            jobDoneCounter = 0;
            Salary = 650;
        }

        public Person(decimal salary)
        {
            Salary = salary;
        }

        public decimal Salary 
        {
            get => salary;
            private set
            {
                if (value < 650)
                {
                    throw new Exception("Invalid salary. Minimal salary is 650 lv.");
                }

                salary = value;
            } 
        }

        public string[] CompleteWork()
        {
            Console.WriteLine("Fixed some errors.");
            Console.WriteLine("Added new feature");
            Console.WriteLine("Tech talk with colleagues");

            string[] jobDoneList = new string[] { "Fixed some errors.", "Added new feature", "Tech talk with colleagues" };

            jobDoneCounter += jobDoneList.Length;

            if (jobDoneCounter % 3 == 0)
            {
                PromotePerson();
            }

            return jobDoneList;
        }

        private void PromotePerson(int percentage = 5)
        {
            Salary += Salary * (percentage / 100.0m);
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(650);
            person.CompleteWork();
            Console.WriteLine(person.Salary);

            var person2 = new Person();
        }
    }
}