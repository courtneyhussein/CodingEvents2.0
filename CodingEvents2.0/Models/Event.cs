using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents2._0.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public int Id { get; }
        private static int _nextId = 1;

        public Event (string name, string description)
        {
            Name = name;
            Description = description;
            Id = _nextId;
            _nextId++;
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Event @event &&
                   Id == @event.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
