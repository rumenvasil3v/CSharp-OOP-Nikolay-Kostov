namespace CustomRandomList
{
    public class RandomList<T> : List<T>
    {
        private Random randomElement;

        public RandomList()
        {
            randomElement = new Random();
        }

        public T RandomElement()
        {
            int randomIndex = randomElement.Next(0, this.Count);
            T element = this[randomIndex];

            this.RemoveAt(randomIndex);

            return element;
        }
    }
}