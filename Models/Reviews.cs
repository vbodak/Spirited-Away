using System.Collections.Generic;

namespace Models
{
    public class Reviews
    {
        public string Type { get; set; }

        public List<Review> Data { get; set; }

        public bool IncludeInMain { get; set; }
    }
}