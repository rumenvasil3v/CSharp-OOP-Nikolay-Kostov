namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var randomList = new RandomList<string>
            {
                "Pesho",
                "Gosho",
                "Koko",
                "Pavel"
            };

            string element = randomList.RandomElement();

            foreach (var item in randomList)
            {
                Console.WriteLine(item);
            }
        }
    }
}