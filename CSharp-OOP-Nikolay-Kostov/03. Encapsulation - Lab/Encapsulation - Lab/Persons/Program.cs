namespace PersonsInfo
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

            Person[] people = GetPeopleInformation(peopleCount);
            decimal percentage = decimal.Parse(Console.ReadLine());

            var sortedPeople = people.ToList()
                  .OrderBy(x => x.FirstName)
                  .ThenBy(x => x.Age);

            foreach (var person in sortedPeople)
            {
                person.IncreaseSalary(percentage);
                Console.WriteLine(person);
            }

            Team team = new Team("SoftUni");

            foreach (Person person in sortedPeople)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine(team);
        }

        public static Person[] GetPeopleInformation(int peopleCount)
        {
            Person[] people = new Person[peopleCount];

            for (int i = 0; i < peopleCount; i++)
            {
                string personInfo = Console.ReadLine();

                string[] personArguments = personInfo.Split(' ');

                string firstName = personArguments[0];
                string lastName = personArguments[1];
                int age = int.Parse(personArguments[2]);
                decimal salary = decimal.Parse(personArguments[3]);

                people[i] = CreatePerson(firstName, lastName, age, salary);
            }

            return people;
        }

        public static Person CreatePerson(string firstName, string lastName, int age, decimal salary)
        {
            Person person = new Person(firstName, lastName, age, salary);

            return person;
        }
    }
}