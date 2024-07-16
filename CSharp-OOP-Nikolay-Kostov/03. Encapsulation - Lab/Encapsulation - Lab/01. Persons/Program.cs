namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());

          Person[] people =  GetPeopleInformation(peopleCount);

            var sortedPeople = people.ToList()
                  .OrderBy(x => x.FirstName)
                  .ThenBy(x => x.Age);
            

            foreach (var person in sortedPeople)
            {
                Console.WriteLine(person);
            }
        }

        static public Person[] GetPeopleInformation(int peopleCount)
        {
            Person[] people = new Person[peopleCount];

            for (int i = 0; i < peopleCount; i++)
            {
                string personInfo = Console.ReadLine();

                string[] personArguments = personInfo.Split(' ');

                string firstName = personArguments[0];
                string lastName = personArguments[1];
                int age = int.Parse(personArguments[2]);

                people[i] = CreatePerson(firstName, lastName, age);
            }

            return people;
        }

        static public Person CreatePerson(string firstName, string lastName, int age)
        {
            Person person = new Person(firstName, lastName, age);

            return person;
        }
    }
}