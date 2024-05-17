namespace PlayersAndMonsters.Heroes
{
    public class Hero
    {
        private string username;
        private int level;

        public Hero(string username, int level)
        {
            Username = username;
            Level = level;
        }

        public string Username { get { return username; } set {  username = value; } }

        public int Level { get { return level; } set { level = value; } }


        public override string ToString()
        {
            string instanceInformation = $"Type: {GetType().Name} Username: {Username} Level: {Level}";

            return instanceInformation;
        }
    }
}