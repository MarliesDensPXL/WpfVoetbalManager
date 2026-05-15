using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalManager.Models
{
    public class Team
    {
        private List<Footballer> _footballers;
        
        public List<Footballer> Footballers
        {
            get { return _footballers; }            
        }


        private string _teamName;        

        public string TeamName
		{
			get { return _teamName; }
			set { _teamName = value; }
		}

        private Footballer _captain;

        public Footballer Captain
        {
            get { return _captain; }
            set 
            {
                if (_footballers.Contains(value))
                {
                    _captain = value;
                }
            }
        }

        public Team(string teamName)
        {
            TeamName = teamName;
            _footballers = new List<Footballer>();
        }

        public void AddPlayer(Footballer footballer, bool isCaptain)
        {
            _footballers.Add(footballer);

            if (isCaptain)
            {
                Captain = footballer;
            }
        }

        public void RemoveFootballer(Footballer footballer)
        {
            _footballers.Remove(footballer);
        }

        public override string ToString()
        {
            return $"{TeamName}";
        }

        public double AverageNumberOfGoals()
        {
            double numberOfGoals = 0;
            foreach (Footballer fb in _footballers)
            {
                numberOfGoals += fb.NumberOfGoals;
            }

           double averageNumberOfGoals = (numberOfGoals / _footballers.Count);

            return averageNumberOfGoals;
        }

        public string TeamInformation()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{TeamName} heeft {_footballers.Count} spelers");
            sb.AppendLine("----------------------");
            foreach (Footballer fb in _footballers)
            {
                string captainStar = (fb == Captain) ? "*" : "";
                // TODO nog iets fixen voor * achter captains name
                sb.AppendLine($"{fb.LastName} {fb.FirstName}{captainStar}");
            }
            sb.AppendLine("----------------------");                       
            sb.AppendLine($"Gemiddeld aantal \n doelpunten: {AverageNumberOfGoals():f2}");

            return sb.ToString();                  
               
        }
    }
}
