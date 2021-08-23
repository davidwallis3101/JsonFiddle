namespace JsonFiddle
{
    using System.Collections.Generic;
    using System.Text.Json;
    using System.Text.Json.Serialization;

    class Structure
    {
        public string lastModified { get; set; }
        //public TempClass.Msinfo msInfo { get; set; }
        //public TempClass.Globalstates globalStates { get; set; }
        //public TempClass.Operatingmodes operatingModes { get; set; }
        //public Rooms rooms { get; set; }
        public IDictionary<string, Room> rooms { get; set; }
        //public IList<Rooms> rooms { get; set; }
        //public Cats cats { get; set; }
        public IDictionary<string, Category> cats { get; set; }
        //public Controls controls { get; set; }
        public IDictionary<string, Control> controls { get; set; }
        //public Weatherserver weatherServer { get; set; }
        //public Times times { get; set; }
        //public Mediaserver mediaServer { get; set; }
        //public Autopilot autopilot { get; set; }
        //public Messagecenter messageCenter { get; set; }

        [JsonExtensionData]
        public IDictionary<string, JsonElement> ExtensionData { get; set; }
    }
}
