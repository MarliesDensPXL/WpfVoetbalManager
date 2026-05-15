using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoetbalManager.Models
{
    internal class Stadium
    {
        public string Name { get; private set; }
        public string Location { get; private set; }
        public int Capacity { get; private set; }

        public Stadium(string name, string location, int capacity)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
        }

        public override string ToString()
        {
            return $"{Name} ({Location})";
        }
    }
}