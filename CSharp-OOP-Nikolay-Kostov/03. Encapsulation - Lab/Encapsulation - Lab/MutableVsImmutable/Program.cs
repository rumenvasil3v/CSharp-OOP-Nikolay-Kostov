namespace MutableVsImmutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String is immutable object. In other words
            // once it is created, it cannot be modified
            // if we want to modify it we need new memory location
            // which will copy the old value and add to it the new value
            // afterwards the garbage collector will delete the old value and the new value will be
            // the modified string
            string name = "Rumen";
            string rumen = name;
            name += "! Hello, World!";

            Console.WriteLine(rumen);
            Console.WriteLine(name);

            // Tuple data type is also immutable
            Tuple<string, string, int> tuple = Tuple.Create("Niki", "Kostov", 34);

            var niki = new Person("Niki", "Kostov", 32, 4000);
            var stoyan = new Person("Stoyan", "Shopov", 23, 3000);

            List<Person> people = new List<Person>() 
            {
                niki,
                stoyan,
            };

            PeopleList list = new PeopleList(people);
            
            Console.WriteLine(list.People.Count);

            //PeopleList peopleList = new PeopleList();
            //peopleList.AddPerson(niki);
            //peopleList.AddPerson(stoyan);
        }
    }
}