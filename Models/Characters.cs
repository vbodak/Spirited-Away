using System.Collections.Generic;

namespace Models
{
    public class Characters
    {
        public string Type { get; set; }

        public List<Card> Data { get; set; }

        public bool includeInMain { get; set; }
    }
}