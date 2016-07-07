using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class MovieDetails
    {
        public int Id { get; set; }

        public String Name { get; set; }

        public string Header { get; set; }

        public string Header_title { get; set; }

        public string Type { get; set; }

        public Overview Overview { get; set; }

        public Characters Characters { get; set; }

        public Cast Cast { get; set; }

        public Reviews Reviews { get; set; }
    }
}