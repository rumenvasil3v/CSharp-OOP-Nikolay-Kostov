using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonsInfo
{
    public class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;
        
        public Team(string name)
        {
            this.name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public IReadOnlyCollection<Person> FirstTeam { get { return this.firstTeam.AsReadOnly(); } }

        public IReadOnlyCollection<Person> ReserveTeam { get { return this.reserveTeam.AsReadOnly(); } }

      // Private set when we want to receive the collection from the outer world

        //public IReadOnlyCollection<Person> FirstTeam { get { return this.firstTeam; } set { this.firstTeam = (List<Person>)value; } }

        //public IReadOnlyCollection<Person> ReserveTeam { get { return this.reserveTeam.AsReadOnly(); } set { this.reserveTeam = (List<Person>)value; } }

        public void AddPlayer(Person player)
        {
            if (player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }

        public override string ToString()
        {
            string firstTeamText = $"First team has {this.FirstTeam.Count} players.";
            string reserveTeamText = $"Reserve team has {this.ReserveTeam.Count} players.";

            StringBuilder sb = new();
            sb.AppendLine(firstTeamText);
            sb.Append(reserveTeamText);

            return sb.ToString();
        }
    }
}
