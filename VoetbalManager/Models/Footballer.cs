using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalManager.Models
{
    public class Footballer
    {
		private string _firstName;

		public string FirstName
		{
			get { return _firstName; }
			set { _firstName = value; }
		}

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}

		private static string[] _allowedPositions = { "attacker", "defender", "goalkeeper", "midfielder", "middenvelder", "doelman", "verdediger", "aanvaller" };
		private string _position;

		public string Position
		{
			get { return _position; }
			set
			{
				// if (value.Equals("goalkeeper",StringComparison.OrdinalIgnoreCase) || value.Equals("attacker", StringComparison.OrdinalIgnoreCase) || value.Equals("midfielder", StringComparison.OrdinalIgnoreCase) || value.Equals("defender", StringComparison.OrdinalIgnoreCase))
				if (Array.Exists(_allowedPositions, position => position.Equals(value, StringComparison.OrdinalIgnoreCase)))
				{
					_position = value;
				}
				else
				{
					throw new ArgumentException("Ongeldige waarde. Geef een correcte positie in.");
				}
			}
		}

		private int _jerseyNumber;

		public int JerseyNumber
		{
			get { return _jerseyNumber; }
			set
			{
				if (value >= 0 && value <= 100)
				{
					_jerseyNumber = value;
				}
				else
				{
					throw new ArgumentException("Ongeldige waarde. Geef een geheel getal in tussen 0 en 100.");
				}
			}
		}

		private int _numberOfGoals;        

        public int NumberOfGoals
		{
			get { return _numberOfGoals; }
			set { _numberOfGoals = value; }
		}

        public Footballer(string firstName, string lastName, int jerseyNumber, string position, int numberOfGoals)
        {
            FirstName = firstName;
            LastName = lastName;
            Position = position;
            JerseyNumber = jerseyNumber;
            NumberOfGoals = numberOfGoals;
        }

        public Footballer(string firstName, string lastName, int jerseyNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            JerseyNumber = jerseyNumber;
			Position = "midfielder";
			NumberOfGoals = 0;
        }

        public override string? ToString()
        {
			return $"{LastName} - {FirstName}";
        }

		public string GetInformation()
		{
			return $"Voetballer {LastName} {FirstName} ({JerseyNumber}) \n" +
				$"heeft dit seizoen {NumberOfGoals} doelen \n gescoord.\n" +
				$"Positie: {Position}";
		}

	}
}
