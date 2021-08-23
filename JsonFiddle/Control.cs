using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFiddle
{
    class Control
    {
        public string name { get; set; }
        public string type { get; set; }
        public string uuidAction { get; set; }
        public string room { get; set; }
        public string cat { get; set; }
        public int defaultRating { get; set; }
        public bool isFavorite { get; set; }
        public bool isSecured { get; set; }
        //public object defaultIcon { get; set; }
        //public string states { get; set; }

        public States states { get; set; }
    }
}
