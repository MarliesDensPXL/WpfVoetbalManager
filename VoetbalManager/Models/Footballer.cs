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

		private string _position;

		public string Position
		{
			get { return _position; }
			set
			{
				if (value == "goalkeeper" || value == "attacker" || value == "midfielder" || value == "defender")
				{
					_position = value;
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
			}
		}

		private int _numberOfGoals;        

        public int NumberOfGoals
		{
			get { return _numberOfGoals; }
			set { _numberOfGoals = value; }
		}

        public Footballer(string firstName, string lastName, string position, int jerseyNumber, int numberOfGoals)
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
				$"heeft dit seizoen {NumberOfGoals} doelen gescoord.\n" +
				$"Positie: {Position}";
		}

	}
}
