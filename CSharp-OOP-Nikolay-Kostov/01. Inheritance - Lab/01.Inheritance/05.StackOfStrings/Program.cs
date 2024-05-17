namespace CustomStack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StackOfStrings strings = new StackOfStrings();
            string[] array = new string[]
            {
                "Pesho",
                "Pavel",
                "Koko"
            };

            strings.AddRange(array);
            strings.Push("Smt");
            strings.Push("Wyd");

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine(strings.IsEmpty());
        }
    }
}