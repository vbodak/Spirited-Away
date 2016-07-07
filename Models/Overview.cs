using System.Collections.Generic;

namespace Models
{
    public class Overview
    {
        public string Type { get; set; }

        public List<string> Images { get; set; }

        public string Header_sub_title { get; set; }

        public string Discription { get; set; }

        public List<Ratings> Ratings { get; set; }

        public Dictionary<string,string> Additional_Discription { get; set; }
    }
}