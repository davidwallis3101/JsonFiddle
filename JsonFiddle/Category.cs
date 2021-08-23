using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonFiddle
{
    public class Category
    {
        public string uuid { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int defaultRating { get; set; }
        public bool isFavorite { get; set; }
        public string type { get; set; }
        public string color { get; set; }

    }
}
