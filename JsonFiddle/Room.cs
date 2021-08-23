namespace JsonFiddle
{
    using System.Collections.Generic;
    
    class Room
    {
        public string uuid { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public int defaultRating { get; set; }
        public bool isFavorite { get; set; }
        public int type { get; set; }
    }
}
