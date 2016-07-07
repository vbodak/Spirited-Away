using System.Collections.Generic;

namespace Models
{
    public class Cast
    {
        public string Type { get; set; }

        public List<Card> data { get; set; }

        public bool IncludeInMain { get; set; }
    }
}