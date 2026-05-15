using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace VoetbalManager.Models
{
    static internal class Data
    {
        static public List<Stadium> LoadMockDataStadium()
        {
            List<Stadium> stadiumList = new List<Stadium>();
            Stadium stadium = new Stadium("Bosuilstadion", "Antwerpen", 16500);
            stadiumList.Add(stadium);
            stadium = new Stadium("Jan Breydelstadion", "Brugge", 29000);
            stadiumList.Add(stadium);
            stadium = new Stadium("Ghelamco Arena", "Gent", 20500);
            stadiumList.Add(stadium);
            stadium = new Stadium("Cegeka Arena", "Genk", 23500);
            stadiumList.Add(stadium);
            stadium = new Stadium("Lotto Park", "Brussel (Anderlecht)", 22500);
            stadiumList.Add(stadium);
            return stadiumList;
        }

        static public List<Team> LoadMockDataTeam()
        {
            List<Team> teamList = new List<Team>();

            //Kayserispor
            Team team = new Team("Kayserispor");
            team.AddPlayer(new Footballer("Murat", "Akin", 2, "middenvelder", 3), false);
            team.AddPlayer(new Footballer("Igor", "Akinfejev", 4, "doelman", 0), false);
            team.AddPlayer(new Footballer("Kerem", "Aktürkoglu", 5, "aanvaller", 10), true);
            team.AddPlayer(new Footballer("Chuba", "Akpom", 3, "verdediger", 1), false);
            teamList.Add(team);

            //FC Antwerpen
            team = new Team("FC Antwerpen");
            team.AddPlayer(new Footballer("Jan", "Peeters", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Tom", "Janssens", 4, "verdediger", 1), true);
            team.AddPlayer(new Footballer("Lucas", "Vermeulen", 8, "middenvelder", 5), false);
            team.AddPlayer(new Footballer("Bram", "De Smet", 9, "aanvaller", 12), false);
            teamList.Add(team);

            //KV Gent
            team = new Team("KV Gent");
            team.AddPlayer(new Footballer("Pieter", "Claes", 1, "doelman", 0), true);
            team.AddPlayer(new Footballer("Mathias", "Wouters", 5, "verdediger", 2), false);
            team.AddPlayer(new Footballer("Simon", "Goossens", 7, "middenvelder", 6), false);
            team.AddPlayer(new Footballer("Kevin", "Martens", 11, "aanvaller", 15), false);
            teamList.Add(team);

            // Club Brugge
            team = new Team("Club Brugge");
            team.AddPlayer(new Footballer("Milan", "De Winter", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Arne", "Vanaken", 10, "middenvelder", 8), true);
            team.AddPlayer(new Footballer("Noah", "Meijer", 3, "verdediger", 1), false);
            team.AddPlayer(new Footballer("Jelle", "Vandamme", 9, "aanvaller", 14), false);
            teamList.Add(team);

            // RSC Anderlecht
            team = new Team("RSC Anderlecht");
            team.AddPlayer(new Footballer("Thomas", "Kok", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Yari", "Verschaeren", 8, "middenvelder", 6), true);
            team.AddPlayer(new Footballer("Lars", "Verstraete", 4, "verdediger", 2), false);
            team.AddPlayer(new Footballer("Nico", "De Meyer", 11, "aanvaller", 10), false);
            teamList.Add(team);

            // Standard Luik
            team = new Team("Standard Luik");
            team.AddPlayer(new Footballer("Robin", "Dupont", 1, "doelman", 0), true);
            team.AddPlayer(new Footballer("Alex", "Lemaire", 5, "verdediger", 1), false);
            team.AddPlayer(new Footballer("Julien", "Moreau", 6, "middenvelder", 4), false);
            team.AddPlayer(new Footballer("Maxime", "Renard", 9, "aanvaller", 13), false);
            teamList.Add(team);

            // KRC Genk
            team = new Team("KRC Genk");
            team.AddPlayer(new Footballer("Maarten", "Vandevoordt", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Daniel", "Muñoz", 2, "verdediger", 3), false);
            team.AddPlayer(new Footballer("Carlos", "Cuesta", 4, "verdediger", 1), false);
            team.AddPlayer(new Footballer("Patrik", "Hrosovsky", 8, "middenvelder", 5), true);
            team.AddPlayer(new Footballer("Bryan", "Heynen", 11, "middenvelder", 4), false);
            team.AddPlayer(new Footballer("Joseph", "Paintsil", 18, "aanvaller", 10), false);
            team.AddPlayer(new Footballer("Tolu", "Arokodare", 99, "aanvaller", 12), false);
            teamList.Add(team);

            // Royal Antwerp FC
            team = new Team("Royal Antwerp FC");
            team.AddPlayer(new Footballer("Jean", "Butez", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Toby", "Alderweireld", 23, "verdediger", 2), true);
            team.AddPlayer(new Footballer("Jelle", "Bataille", 25, "verdediger", 1), false);
            team.AddPlayer(new Footballer("Alhassan", "Yusuf", 8, "middenvelder", 3), false);
            team.AddPlayer(new Footballer("Arthur", "Vermeeren", 6, "middenvelder", 4), false);
            team.AddPlayer(new Footballer("Michel-Ange", "Balikwisha", 10, "aanvaller", 9), false);
            team.AddPlayer(new Footballer("Vincent", "Janssen", 18, "aanvaller", 14), false);
            teamList.Add(team);

            // OH Leuven
            team = new Team("OH Leuven");
            team.AddPlayer(new Footballer("Valentin", "Cojean", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Hamza", "Mendyl", 3, "verdediger", 1), false);
            team.AddPlayer(new Footballer("Federico", "Ricca", 4, "verdediger", 2), true);
            team.AddPlayer(new Footballer("Siebe", "Schrijvers", 8, "middenvelder", 6), false);
            team.AddPlayer(new Footballer("Jon", "Dagur Thorsteinsson", 11, "middenvelder", 4), false);
            team.AddPlayer(new Footballer("Mario", "Gonzalez", 9, "aanvaller", 8), false);
            team.AddPlayer(new Footballer("Casper", "De Norre", 17, "middenvelder", 3), false);
            teamList.Add(team);

            // Cercle Brugge
            team = new Team("Cercle Brugge");
            team.AddPlayer(new Footballer("Warleson", "Oliveira", 1, "doelman", 0), false);
            team.AddPlayer(new Footballer("Jesper", "Daland", 2, "verdediger", 1), true);
            team.AddPlayer(new Footballer("Utkir", "Yusupov", 5, "verdediger", 0), false);
            team.AddPlayer(new Footballer("Hannes", "Van der Bruggen", 8, "middenvelder", 2), false);
            team.AddPlayer(new Footballer("Abu", "Francis", 20, "middenvelder", 3), false);
            team.AddPlayer(new Footballer("Kevin", "Denkey", 9, "aanvaller", 16), false);
            team.AddPlayer(new Footballer("Felipe", "Augusto", 11, "aanvaller", 7), false);
            teamList.Add(team);

            return teamList;
        }

        static public Dictionary<DateTime, List<Match>> LoadMockDataPlanner(List<Team> teamList, List<Stadium> stadiumList)
        {
            Dictionary<DateTime, List<Match>> matchCalendar = new();
            DateTime date;
            Match match;

            //Today
            date = DateTime.Today;
            matchCalendar[date] = new List<Match>();

            match = new Match(teamList.First(t => t.TeamName == "FC Antwerpen"), teamList.First(t => t.TeamName == "KV Gent"), stadiumList.First(s => s.Name == "Bosuilstadion"));
            match.SetScore(2, 1);
            matchCalendar[date].Add(match);

            match = new Match(teamList.First(t => t.TeamName == "Club Brugge"), teamList.First(t => t.TeamName == "RSC Anderlecht"), stadiumList.First(s => s.Name == "Jan Breydelstadion"));
            match.SetScore(3, 3);
            matchCalendar[date].Add(match);

            //Tomorrow
            date = DateTime.Today.AddDays(1);
            matchCalendar[date] = new List<Match>();

            match = new Match(teamList.First(t => t.TeamName == "KRC Genk"), teamList.First(t => t.TeamName == "FC Antwerpen"), stadiumList.First(s => s.Name == "Cegeka Arena"));
            match.SetScore(1, 0);
            matchCalendar[date].Add(match);

            match = new Match(teamList.First(t => t.TeamName == "KV Gent"), teamList.First(t => t.TeamName == "Club Brugge"), stadiumList.First(s => s.Name == "Ghelamco Arena"));
            match.SetScore(0, 2);
            matchCalendar[date].Add(match);

            //Yesterday
            date = DateTime.Today.AddDays(-1);
            matchCalendar[date] = new List<Match>();

            match = new Match(teamList.First(t => t.TeamName == "RSC Anderlecht"), teamList.First(t => t.TeamName == "KRC Genk"), stadiumList.First(s => s.Name == "Lotto Park"));
            match.SetScore(2, 2);
            matchCalendar[date].Add(match);

            return matchCalendar;
        }
    }
}