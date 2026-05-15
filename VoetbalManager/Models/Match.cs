using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VoetbalManager.Models
{
    internal class Match
    {
        public Team Home { get; }
        public Team Visitor { get; }
        public Stadium Stadium { get; }
        public byte? HomeScore { get; private set; }
        public byte? VisitorScore { get; private set; }
        public Team? Winner =>
            HomeScore > VisitorScore ? Home :
            VisitorScore > HomeScore ? Visitor :
            null;
        public bool IsPlayed => HomeScore != null && VisitorScore != null ? true : false;

        public Match(Team home, Team visitor, Stadium stadium)
        {
            Home = home;
            Visitor = visitor;
            Stadium = stadium;
        }

        public void SetScore(byte homeScore, byte visitorScore)
        {
            HomeScore = homeScore;
            VisitorScore = visitorScore;
        }

        public override string ToString()
        {
            return $"{Home} - {Visitor}";
        }

        public string ShowDetails()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(ToString());
            sb.AppendLine(new string('-', ToString().Length));
            sb.AppendLine($"Stadium: {Stadium}");
            sb.AppendLine(IsPlayed ? $"Score: {HomeScore} - {VisitorScore}" : "Not played yet");
            return sb.ToString();
        }
    }
}