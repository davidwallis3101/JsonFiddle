namespace JsonFiddle
{
    class TempClass
    {

        /// <summary>
  
        /// </summary>





        public class Rootobject
        {
            public string lastModified { get; set; }
            public Msinfo msInfo { get; set; }
            public Globalstates globalStates { get; set; }
            public Operatingmodes operatingModes { get; set; }
            public Rooms rooms { get; set; }
            public Cats cats { get; set; }
            public Controls controls { get; set; }
            public Weatherserver weatherServer { get; set; }
            public Times times { get; set; }
            public Mediaserver mediaServer { get; set; }
            public Autopilot autopilot { get; set; }
            public Messagecenter messageCenter { get; set; }
        }

        public class Msinfo
        {
            public string serialNr { get; set; }
            public string msName { get; set; }
            public string projectName { get; set; }
            public string localUrl { get; set; }
            public string remoteUrl { get; set; }
            public int tempUnit { get; set; }
            public string currency { get; set; }
            public string squareMeasure { get; set; }
            public string location { get; set; }
            public string languageCode { get; set; }
            public string heatPeriodStart { get; set; }
            public string heatPeriodEnd { get; set; }
            public string coolPeriodStart { get; set; }
            public string coolPeriodEnd { get; set; }
            public string catTitle { get; set; }
            public string roomTitle { get; set; }
            public int miniserverType { get; set; }
            public Currentuser currentUser { get; set; }
        }

        public class Currentuser
        {
            public string name { get; set; }
            public string uuid { get; set; }
            public bool isAdmin { get; set; }
            public bool changePassword { get; set; }
            public int userRights { get; set; }
        }

        public class Globalstates
        {
            public string operatingMode { get; set; }
            public string sunrise { get; set; }
            public string sunset { get; set; }
            public string pastTasks { get; set; }
            public string plannedTasks { get; set; }
            public string notifications { get; set; }
            public string modifications { get; set; }
            public string favColorSequences { get; set; }
            public string favColors { get; set; }
            public string miniserverTime { get; set; }
            public string liveSearch { get; set; }
            public string userSettings { get; set; }
            public string hasInternet { get; set; }
        }

        public class Operatingmodes
        {
            public string _0 { get; set; }
            public string _1 { get; set; }
            public string _2 { get; set; }
            public string _3 { get; set; }
            public string _4 { get; set; }
            public string _5 { get; set; }
            public string _6 { get; set; }
            public string _7 { get; set; }
            public string _8 { get; set; }
            public string _9 { get; set; }
            public string _10 { get; set; }
            public string _11 { get; set; }
            public string _12 { get; set; }
            public string _13 { get; set; }
            public string _14 { get; set; }
            public string _15 { get; set; }
        }

        public class Rooms
        {
            public _121Af59600Ce1B63Ffff1a9eccc1508b _121af59600ce1b63ffff1a9eccc1508b { get; set; }
            public _121Af59600D01B73Ffff1a9eccc1508b _121af59600d01b73ffff1a9eccc1508b { get; set; }
            public _121Af59600Dd1Bf1Ffff1a9eccc1508b _121af59600dd1bf1ffff1a9eccc1508b { get; set; }
            public _121Af59600De1BfdFfff1a9eccc1508b _121af59600de1bfdffff1a9eccc1508b { get; set; }
            public _123Bb2a7022D6BafFfff1a9eccc1508b _123bb2a7022d6bafffff1a9eccc1508b { get; set; }
            public _123D40df01366900Ffff1a9eccc1508b _123d40df01366900ffff1a9eccc1508b { get; set; }
            public _126F093002C4E2a8Ffff1a9eccc1508b _126f093002c4e2a8ffff1a9eccc1508b { get; set; }
            public _12B7a45c00492AbbFfff1a9eccc1508b _12b7a45c00492abbffff1a9eccc1508b { get; set; }
            public _1319Aeb9005DFa88Ffff1a9eccc1508b _1319aeb9005dfa88ffff1a9eccc1508b { get; set; }
            public _168B5b4d0351Cb89Ffff1a9eccc1508b _168b5b4d0351cb89ffff1a9eccc1508b { get; set; }
        }

        public class _121Af59600Ce1B63Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _121Af59600D01B73Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _121Af59600Dd1Bf1Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _121Af59600De1BfdFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _123Bb2a7022D6BafFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _123D40df01366900Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _126F093002C4E2a8Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _12B7a45c00492AbbFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _1319Aeb9005DFa88Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class _168B5b4d0351Cb89Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public int type { get; set; }
        }

        public class Cats
        {
            public _121Af59600A01A16Ffff1a9eccc1508b _121af59600a01a16ffff1a9eccc1508b { get; set; }
            public _121Af59600A01A1aFfff1a9eccc1508b _121af59600a01a1affff1a9eccc1508b { get; set; }
            public _121Af59600A21A2aFfff1a9eccc1508b _121af59600a21a2affff1a9eccc1508b { get; set; }
            public _121Af59600A51A46Ffff1a9eccc1508b _121af59600a51a46ffff1a9eccc1508b { get; set; }
            public _121Af59600A61A52Ffff1a9eccc1508b _121af59600a61a52ffff1a9eccc1508b { get; set; }
            public _121Af59600B11AacFfff1a9eccc1508b _121af59600b11aacffff1a9eccc1508b { get; set; }
            public _12B7a2c1001A97F4Ffff1a9eccc1508b _12b7a2c1001a97f4ffff1a9eccc1508b { get; set; }
            public _12F4ce270164389CFfff1a9eccc1508b _12f4ce270164389cffff1a9eccc1508b { get; set; }
            public _15457Dd801C0BfdaFfff1a9eccc1508b _15457dd801c0bfdaffff1a9eccc1508b { get; set; }
            public _169D57ea02443194Ffff1a9eccc1508b _169d57ea02443194ffff1a9eccc1508b { get; set; }
        }

        public class _121Af59600A01A16Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _121Af59600A01A1aFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _121Af59600A21A2aFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _121Af59600A51A46Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _121Af59600A61A52Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _121Af59600B11AacFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _12B7a2c1001A97F4Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _12F4ce270164389CFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _15457Dd801C0BfdaFfff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class _169D57ea02443194Ffff1a9eccc1508b
        {
            public string uuid { get; set; }
            public string name { get; set; }
            public string image { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public string type { get; set; }
            public string color { get; set; }
        }

        public class Controls
        {
            public _123D411002Be87A5Ffff1a9eccc1508b _123d411002be87a5ffff1a9eccc1508b { get; set; }
            public _16A58515016FAa6cFfff1a9eccc1508b _16a58515016faa6cffff1a9eccc1508b { get; set; }
            public _168B684b022E5C2eFfff1a9eccc1508b _168b684b022e5c2effff1a9eccc1508b { get; set; }
            public _12F7450600A5F308Ffff1a9eccc1508b _12f7450600a5f308ffff1a9eccc1508b { get; set; }
            public _156Cb92a0399Add8Ffff1a9eccc1508b _156cb92a0399add8ffff1a9eccc1508b { get; set; }
            public _169D560702C8763CFfff1a9eccc1508b _169d560702c8763cffff1a9eccc1508b { get; set; }
            public _169D61dd03Bd5F69Ffff1a9eccc1508b _169d61dd03bd5f69ffff1a9eccc1508b { get; set; }
            public _13Dddd3d0129Cd29Ffff68a2f0c4ff59 _13dddd3d0129cd29ffff68a2f0c4ff59 { get; set; }
            public _154C203a02913413Ffff1a9eccc1508b _154c203a02913413ffff1a9eccc1508b { get; set; }
            public _154C203a028B3410Ffff1a9eccc1508b _154c203a028b3410ffff1a9eccc1508b { get; set; }
            public _154C203a02983416Ffff1a9eccc1508b _154c203a02983416ffff1a9eccc1508b { get; set; }
            public _121Af60401B523A7Ffff1a9eccc1508b _121af60401b523a7ffff1a9eccc1508b { get; set; }
            public _15457D5a01Ac6D2eFfff1a9eccc1508b _15457d5a01ac6d2effff1a9eccc1508b { get; set; }
            public _156Cbdbe03Aa0085Ffff1a9eccc1508b _156cbdbe03aa0085ffff1a9eccc1508b { get; set; }
            public _156Cb9cf00581B51Ffffa01324234375 _156cb9cf00581b51ffffa01324234375 { get; set; }
            public _156Cb9cf00581B47Ffffa01324234375 _156cb9cf00581b47ffffa01324234375 { get; set; }
            public _156Cbccc0113A7b1Ffff1a9eccc1508b _156cbccc0113a7b1ffff1a9eccc1508b { get; set; }
            public _121Af5a402491C6eFfff1a9eccc1508b _121af5a402491c6effff1a9eccc1508b { get; set; }
            public _130F0d8002E5F070Ffff1a9eccc1508b _130f0d8002e5f070ffff1a9eccc1508b { get; set; }
            public _154C203a02F0343DFfff1a9eccc1508b _154c203a02f0343dffff1a9eccc1508b { get; set; }
            public _16317Fcb00437041Ffff1a9eccc1508b _16317fcb00437041ffff1a9eccc1508b { get; set; }
            public _163192480043F756Ffff66526367a341 _163192480043f756ffff66526367a341 { get; set; }
            public _15457D7f0359968BFfff1a9eccc1508b _15457d7f0359968bffff1a9eccc1508b { get; set; }
            public _15B9ad2503AbEd7dFfff550a7aedfe83 _15b9ad2503abed7dffff550a7aedfe83 { get; set; }
            public _15B9adb001A7419AFfffd21b83b2614b _15b9adb001a7419affffd21b83b2614b { get; set; }
            public _12D91a2002EdA824Ffff1a9eccc1508b _12d91a2002eda824ffff1a9eccc1508b { get; set; }
            public _12D923b202B2F162Ffff1a9eccc1508b _12d923b202b2f162ffff1a9eccc1508b { get; set; }
            public _121Af5a402451C47Ffff1a9eccc1508b _121af5a402451c47ffff1a9eccc1508b { get; set; }
            public _121Af5a402541C93Ffff1a9eccc1508b _121af5a402541c93ffff1a9eccc1508b { get; set; }
            public _121Af5a402541C96Ffff1a9eccc1508b _121af5a402541c96ffff1a9eccc1508b { get; set; }
            public _121Af5a402541C90Ffff1a9eccc1508b _121af5a402541c90ffff1a9eccc1508b { get; set; }
            public _15477Db900C7Be63Ffff1a9eccc1508b _15477db900c7be63ffff1a9eccc1508b { get; set; }
            public _121Af5a402531C8dFfff1a9eccc1508b _121af5a402531c8dffff1a9eccc1508b { get; set; }
            public _121Af5a402531C84Ffff1a9eccc1508b _121af5a402531c84ffff1a9eccc1508b { get; set; }
            public _121Af5a402521C7eFfff1a9eccc1508b _121af5a402521c7effff1a9eccc1508b { get; set; }
            public _121Af5a402531C81Ffff1a9eccc1508b _121af5a402531c81ffff1a9eccc1508b { get; set; }
            public _121Af5a402531C8aFfff1a9eccc1508b _121af5a402531c8affff1a9eccc1508b { get; set; }
            public _121Af5a402531C87Ffff1a9eccc1508b _121af5a402531c87ffff1a9eccc1508b { get; set; }
            public _12B79d91034E42D4Ffff1a9eccc1508b _12b79d91034e42d4ffff1a9eccc1508b { get; set; }
            public _12F8966a03CaA8bcFfff1a9eccc1508b _12f8966a03caa8bcffff1a9eccc1508b { get; set; }
            public _130B3e3802C7F399Ffff1a9eccc1508b _130b3e3802c7f399ffff1a9eccc1508b { get; set; }
            public _12B7a7690042Ad24Ffff9134f1f7a024 _12b7a7690042ad24ffff9134f1f7a024 { get; set; }
            public _13Cd99b102FdEb4dFfff1a9eccc1508b _13cd99b102fdeb4dffff1a9eccc1508b { get; set; }
            public _1301267702Cf366CFfff1a9eccc1508b _1301267702cf366cffff1a9eccc1508b { get; set; }
            public _12B7a67403498010Ffff1a9eccc1508b _12b7a67403498010ffff1a9eccc1508b { get; set; }
            public _13Cd99ae0185Dd87Ffff1a9eccc1508b _13cd99ae0185dd87ffff1a9eccc1508b { get; set; }
            public _123Bb5ef01F639E5Ffff1a9eccc1508b _123bb5ef01f639e5ffff1a9eccc1508b { get; set; }
            public _168B62ef004BCbd8Ffff1a9eccc1508b _168b62ef004bcbd8ffff1a9eccc1508b { get; set; }
        }

        public class _123D411002Be87A5Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States states { get; set; }
        }

        public class States
        {
            public string active { get; set; }
        }

        public class _16A58515016FAa6cFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public Details details { get; set; }
            public States1 states { get; set; }
        }

        public class Details
        {
            public bool isStairwayLs { get; set; }
        }

        public class States1
        {
            public string deactivationDelay { get; set; }
            public string deactivationDelayTotal { get; set; }
        }

        public class _168B684b022E5C2eFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details1 details { get; set; }
            public States2 states { get; set; }
        }

        public class Details1
        {
            public string server { get; set; }
            public int playerid { get; set; }
            public int clientType { get; set; }
            public int parameterConnections { get; set; }
        }

        public class States2
        {
            public string power { get; set; }
            public string serverState { get; set; }
            public string playState { get; set; }
            public string clientState { get; set; }
            public string volume { get; set; }
            public string maxVolume { get; set; }
            public string mute { get; set; }
            public string shuffle { get; set; }
            public string repeat { get; set; }
            public string source { get; set; }
            public string sourceList { get; set; }
            public string songName { get; set; }
            public string duration { get; set; }
            public string progress { get; set; }
            public string album { get; set; }
            public string artist { get; set; }
            public string station { get; set; }
            public string genre { get; set; }
            public string cover { get; set; }
            public string volumeStep { get; set; }
            public string queueIndex { get; set; }
            public string enableAirPlay { get; set; }
            public string enableSpotifyConnect { get; set; }
            public string hasInternet { get; set; }
            public string masterVolume { get; set; }
            public string alarmVolume { get; set; }
            public string bellVolume { get; set; }
            public string buzzerVolume { get; set; }
            public string ttsVolume { get; set; }
            public string defaultVolume { get; set; }
            public string equalizerSettings { get; set; }
        }

        public class _12F7450600A5F308Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details2 details { get; set; }
            public States3 states { get; set; }
        }

        public class Details2
        {
            public string format { get; set; }
        }

        public class States3
        {
            public string value { get; set; }
            public string error { get; set; }
        }

        public class _156Cb92a0399Add8Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details3 details { get; set; }
            public States4 states { get; set; }
        }

        public class Details3
        {
            public string format { get; set; }
        }

        public class States4
        {
            public string value { get; set; }
        }

        public class _169D560702C8763CFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details4 details { get; set; }
            public States5 states { get; set; }
        }

        public class Details4
        {
            public int favoritePad { get; set; }
            public Modelist modeList { get; set; }
        }

        public class Modelist
        {
            public _1 _1 { get; set; }
        }

        public class _1
        {
            public string name { get; set; }
            public int favoritePad { get; set; }
            public string[] usedButtons { get; set; }
        }

        public class States5
        {
            public string timeout { get; set; }
            public string mode { get; set; }
            public string active { get; set; }
        }

        public class _169D61dd03Bd5F69Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public States6 states { get; set; }
        }

        public class States6
        {
            public string active { get; set; }
        }

        public class _13Dddd3d0129Cd29Ffff68a2f0c4ff59
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details5 details { get; set; }
            public States7 states { get; set; }
            public Subcontrols subControls { get; set; }
        }

        public class Details5
        {
            public int movementScene { get; set; }
        }

        public class States7
        {
            public string activeMoods { get; set; }
            public string moodList { get; set; }
            public string favoriteMoods { get; set; }
            public string additionalMoods { get; set; }
        }

        public class Subcontrols
        {
            public _13Dddd3d0129Cd29Ffff68a2f0c4ff59AI1 _13dddd3d0129cd29ffff68a2f0c4ff59AI1 { get; set; }
        }

        public class _13Dddd3d0129Cd29Ffff68a2f0c4ff59AI1
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public States8 states { get; set; }
        }

        public class States8
        {
            public string active { get; set; }
        }

        public class _154C203a02913413Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details6 details { get; set; }
            public States9 states { get; set; }
        }

        public class Details6
        {
            public Text text { get; set; }
            public Color color { get; set; }
        }

        public class Text
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States9
        {
            public string active { get; set; }
        }

        public class _154C203a028B3410Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details7 details { get; set; }
            public States10 states { get; set; }
        }

        public class Details7
        {
            public Text1 text { get; set; }
            public Color1 color { get; set; }
        }

        public class Text1
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color1
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States10
        {
            public string active { get; set; }
        }

        public class _154C203a02983416Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details8 details { get; set; }
            public States11 states { get; set; }
        }

        public class Details8
        {
            public Text2 text { get; set; }
            public Color2 color { get; set; }
        }

        public class Text2
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color2
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States11
        {
            public string active { get; set; }
        }

        public class _121Af60401B523A7Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public States12 states { get; set; }
        }

        public class States12
        {
            public string position { get; set; }
            public string min { get; set; }
            public string max { get; set; }
            public string step { get; set; }
        }

        public class _15457D5a01Ac6D2eFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States13 states { get; set; }
        }

        public class States13
        {
            public string active { get; set; }
        }

        public class _156Cbdbe03Aa0085Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States14 states { get; set; }
        }

        public class States14
        {
            public string active { get; set; }
        }

        public class _156Cb9cf00581B51Ffffa01324234375
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States15 states { get; set; }
        }

        public class States15
        {
            public string textAndIcon { get; set; }
        }

        public class _156Cb9cf00581B47Ffffa01324234375
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details9 details { get; set; }
            public States16 states { get; set; }
        }

        public class Details9
        {
            public bool isStairwayLs { get; set; }
        }

        public class States16
        {
            public string deactivationDelay { get; set; }
            public string deactivationDelayTotal { get; set; }
        }

        public class _156Cbccc0113A7b1Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States17 states { get; set; }
        }

        public class States17
        {
            public string active { get; set; }
        }

        public class _121Af5a402491C6eFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details10 details { get; set; }
            public States18 states { get; set; }
        }

        public class Details10
        {
            public string format { get; set; }
        }

        public class States18
        {
            public string value { get; set; }
        }

        public class _130F0d8002E5F070Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details11 details { get; set; }
            public States19 states { get; set; }
        }

        public class Details11
        {
            public string format { get; set; }
        }

        public class States19
        {
            public string value { get; set; }
            public string error { get; set; }
        }

        public class _154C203a02F0343DFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details12 details { get; set; }
            public States20 states { get; set; }
        }

        public class Details12
        {
            public Text3 text { get; set; }
            public Color3 color { get; set; }
        }

        public class Text3
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color3
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States20
        {
            public string active { get; set; }
        }

        public class _16317Fcb00437041Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public States21 states { get; set; }
        }

        public class States21
        {
            public string active { get; set; }
        }

        public class _163192480043F756Ffff66526367a341
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details13 details { get; set; }
            public States22 states { get; set; }
        }

        public class Details13
        {
            public bool isStairwayLs { get; set; }
        }

        public class States22
        {
            public string deactivationDelay { get; set; }
            public string deactivationDelayTotal { get; set; }
        }

        public class _15457D7f0359968BFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details14 details { get; set; }
            public States23 states { get; set; }
        }

        public class Details14
        {
            public bool analog { get; set; }
            public Text4 text { get; set; }
        }

        public class Text4
        {
            public string on { get; set; }
            public string off { get; set; }
        }

        public class States23
        {
            public string mode { get; set; }
            public string _override { get; set; }
            public string value { get; set; }
            public string needsActivation { get; set; }
            public string modeList { get; set; }
            public string entriesAndDefaultValue { get; set; }
            public string resetActive { get; set; }
        }

        public class _15B9ad2503AbEd7dFfff550a7aedfe83
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details15 details { get; set; }
            public States24 states { get; set; }
        }

        public class Details15
        {
            public bool analog { get; set; }
            public Text5 text { get; set; }
        }

        public class Text5
        {
            public string on { get; set; }
            public string off { get; set; }
        }

        public class States24
        {
            public string mode { get; set; }
            public string _override { get; set; }
            public string value { get; set; }
            public string needsActivation { get; set; }
            public string modeList { get; set; }
            public string entriesAndDefaultValue { get; set; }
            public string resetActive { get; set; }
        }

        public class _15B9adb001A7419AFfffd21b83b2614b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details16 details { get; set; }
            public States25 states { get; set; }
        }

        public class Details16
        {
            public bool analog { get; set; }
            public Text6 text { get; set; }
        }

        public class Text6
        {
            public string on { get; set; }
            public string off { get; set; }
        }

        public class States25
        {
            public string mode { get; set; }
            public string _override { get; set; }
            public string value { get; set; }
            public string needsActivation { get; set; }
            public string modeList { get; set; }
            public string entriesAndDefaultValue { get; set; }
            public string resetActive { get; set; }
        }

        public class _12D91a2002EdA824Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States26 states { get; set; }
        }

        public class States26
        {
            public string active { get; set; }
        }

        public class _12D923b202B2F162Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public States27 states { get; set; }
        }

        public class States27
        {
            public string active { get; set; }
        }

        public class _121Af5a402451C47Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details17 details { get; set; }
            public States28 states { get; set; }
        }

        public class Details17
        {
            public string format { get; set; }
        }

        public class States28
        {
            public string value { get; set; }
            public string error { get; set; }
        }

        public class _121Af5a402541C93Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details18 details { get; set; }
            public States29 states { get; set; }
        }

        public class Details18
        {
            public string format { get; set; }
        }

        public class States29
        {
            public string value { get; set; }
        }

        public class _121Af5a402541C96Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details19 details { get; set; }
            public States30 states { get; set; }
        }

        public class Details19
        {
            public string format { get; set; }
        }

        public class States30
        {
            public string value { get; set; }
        }

        public class _121Af5a402541C90Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details20 details { get; set; }
            public States31 states { get; set; }
        }

        public class Details20
        {
            public string format { get; set; }
        }

        public class States31
        {
            public string value { get; set; }
        }

        public class _15477Db900C7Be63Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details21 details { get; set; }
            public States32 states { get; set; }
        }

        public class Details21
        {
            public string format { get; set; }
        }

        public class States32
        {
            public string value { get; set; }
        }

        public class _121Af5a402531C8dFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details22 details { get; set; }
            public States33 states { get; set; }
        }

        public class Details22
        {
            public string format { get; set; }
        }

        public class States33
        {
            public string value { get; set; }
        }

        public class _121Af5a402531C84Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details23 details { get; set; }
            public States34 states { get; set; }
        }

        public class Details23
        {
            public string format { get; set; }
        }

        public class States34
        {
            public string value { get; set; }
        }

        public class _121Af5a402521C7eFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details24 details { get; set; }
            public States35 states { get; set; }
        }

        public class Details24
        {
            public Text7 text { get; set; }
            public Color4 color { get; set; }
        }

        public class Text7
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color4
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States35
        {
            public string active { get; set; }
        }

        public class _121Af5a402531C81Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details25 details { get; set; }
            public States36 states { get; set; }
        }

        public class Details25
        {
            public string format { get; set; }
        }

        public class States36
        {
            public string value { get; set; }
        }

        public class _121Af5a402531C8aFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details26 details { get; set; }
            public States37 states { get; set; }
        }

        public class Details26
        {
            public string format { get; set; }
        }

        public class States37
        {
            public string value { get; set; }
        }

        public class _121Af5a402531C87Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details27 details { get; set; }
            public States38 states { get; set; }
        }

        public class Details27
        {
            public string format { get; set; }
        }

        public class States38
        {
            public string value { get; set; }
        }

        public class _12B79d91034E42D4Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details28 details { get; set; }
            public States39 states { get; set; }
        }

        public class Details28
        {
            public string format { get; set; }
        }

        public class States39
        {
            public string value { get; set; }
            public string error { get; set; }
        }

        public class _12F8966a03CaA8bcFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public object defaultIcon { get; set; }
            public Details29 details { get; set; }
            public States40 states { get; set; }
        }

        public class Details29
        {
            public string format { get; set; }
        }

        public class States40
        {
            public string value { get; set; }
            public string error { get; set; }
        }

        public class _130B3e3802C7F399Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public Details30 details { get; set; }
            public States41 states { get; set; }
        }

        public class Details30
        {
            public bool isStairwayLs { get; set; }
        }

        public class States41
        {
            public string deactivationDelay { get; set; }
            public string deactivationDelayTotal { get; set; }
        }

        public class _12B7a7690042Ad24Ffff9134f1f7a024
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details31 details { get; set; }
            public States42 states { get; set; }
        }

        public class Details31
        {
            public bool analog { get; set; }
            public Text8 text { get; set; }
        }

        public class Text8
        {
            public string on { get; set; }
            public string off { get; set; }
        }

        public class States42
        {
            public string mode { get; set; }
            public string _override { get; set; }
            public string value { get; set; }
            public string needsActivation { get; set; }
            public string modeList { get; set; }
            public string entriesAndDefaultValue { get; set; }
            public string resetActive { get; set; }
        }

        public class _13Cd99b102FdEb4dFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public Details32 details { get; set; }
            public States43 states { get; set; }
        }

        public class Details32
        {
            public Text9 text { get; set; }
            public Color5 color { get; set; }
        }

        public class Text9
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color5
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States43
        {
            public string active { get; set; }
        }

        public class _1301267702Cf366CFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public Details33 details { get; set; }
            public States44 states { get; set; }
        }

        public class Details33
        {
            public bool isStairwayLs { get; set; }
        }

        public class States44
        {
            public string deactivationDelay { get; set; }
            public string deactivationDelayTotal { get; set; }
        }

        public class _12B7a67403498010Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details34 details { get; set; }
            public States45 states { get; set; }
        }

        public class Details34
        {
            public bool analog { get; set; }
            public Text10 text { get; set; }
        }

        public class Text10
        {
            public string on { get; set; }
            public string off { get; set; }
        }

        public class States45
        {
            public string mode { get; set; }
            public string _override { get; set; }
            public string value { get; set; }
            public string needsActivation { get; set; }
            public string modeList { get; set; }
            public string entriesAndDefaultValue { get; set; }
            public string resetActive { get; set; }
        }

        public class _13Cd99ae0185Dd87Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public string defaultIcon { get; set; }
            public Details35 details { get; set; }
            public States46 states { get; set; }
        }

        public class Details35
        {
            public Text11 text { get; set; }
            public Color6 color { get; set; }
        }

        public class Text11
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class Color6
        {
            public string off { get; set; }
            public string on { get; set; }
        }

        public class States46
        {
            public string active { get; set; }
        }

        public class _123Bb5ef01F639E5Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details36 details { get; set; }
        }

        public class Details36
        {
            public Control[] controls { get; set; }
        }

        public class Control
        {
            public int id { get; set; }
            public string uuid { get; set; }
        }

        public class _168B62ef004BCbd8Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string type { get; set; }
            public string uuidAction { get; set; }
            public string room { get; set; }
            public string cat { get; set; }
            public int defaultRating { get; set; }
            public bool isFavorite { get; set; }
            public bool isSecured { get; set; }
            public Details37 details { get; set; }
        }

        public class Details37
        {
            public Control1[] controls { get; set; }
        }

        public class Control1
        {
            public int id { get; set; }
            public string uuid { get; set; }
        }

        public class Weatherserver
        {
            public States47 states { get; set; }
            public Format format { get; set; }
            public Weathertypetexts weatherTypeTexts { get; set; }
            public Weatherfieldtypes weatherFieldTypes { get; set; }
        }

        public class States47
        {
            public string actual { get; set; }
            public string forecast { get; set; }
        }

        public class Format
        {
            public string relativeHumidity { get; set; }
            public string temperature { get; set; }
            public string windSpeed { get; set; }
            public string precipitation { get; set; }
            public string barometricPressure { get; set; }
        }

        public class Weathertypetexts
        {
            public string _1 { get; set; }
            public string _2 { get; set; }
            public string _3 { get; set; }
            public string _4 { get; set; }
            public string _5 { get; set; }
            public string _6 { get; set; }
            public string _7 { get; set; }
            public string _8 { get; set; }
            public string _9 { get; set; }
            public string _10 { get; set; }
            public string _11 { get; set; }
            public string _12 { get; set; }
            public string _13 { get; set; }
            public string _14 { get; set; }
            public string _15 { get; set; }
            public string _16 { get; set; }
            public string _17 { get; set; }
            public string _18 { get; set; }
            public string _19 { get; set; }
            public string _20 { get; set; }
            public string _21 { get; set; }
            public string _22 { get; set; }
            public string _23 { get; set; }
            public string _24 { get; set; }
            public string _25 { get; set; }
            public string _26 { get; set; }
            public string _27 { get; set; }
            public string _28 { get; set; }
            public string _29 { get; set; }
        }

        public class Weatherfieldtypes
        {
            public _11 _1 { get; set; }
            public _2 _2 { get; set; }
            public _3 _3 { get; set; }
            public _4 _4 { get; set; }
            public _5 _5 { get; set; }
            public _6 _6 { get; set; }
            public _7 _7 { get; set; }
            public _8 _8 { get; set; }
            public _9 _9 { get; set; }
            public _10 _10 { get; set; }
            public _111 _11 { get; set; }
            public _26 _26 { get; set; }
            public _27 _27 { get; set; }
            public _28 _28 { get; set; }
            public _29 _29 { get; set; }
            public _30 _30 { get; set; }
            public _31 _31 { get; set; }
            public _32 _32 { get; set; }
            public _33 _33 { get; set; }
            public _34 _34 { get; set; }
        }

        public class _11
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _2
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _3
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string format { get; set; }
        }

        public class _4
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _5
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _6
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _7
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _8
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _9
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _10
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _111
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _26
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
            public string unit { get; set; }
            public string format { get; set; }
        }

        public class _27
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _28
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _29
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _30
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _31
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _32
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _33
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _34
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class Times
        {
            public _266 _266 { get; set; }
            public _267 _267 { get; set; }
            public _268 _268 { get; set; }
            public _269 _269 { get; set; }
            public _270 _270 { get; set; }
            public _271 _271 { get; set; }
            public _272 _272 { get; set; }
            public _273 _273 { get; set; }
            public _274 _274 { get; set; }
            public _275 _275 { get; set; }
            public _276 _276 { get; set; }
            public _277 _277 { get; set; }
            public _278 _278 { get; set; }
            public _281 _281 { get; set; }
            public _282 _282 { get; set; }
            public _283 _283 { get; set; }
            public _284 _284 { get; set; }
            public _285 _285 { get; set; }
            public _286 _286 { get; set; }
            public _287 _287 { get; set; }
            public _288 _288 { get; set; }
            public _289 _289 { get; set; }
            public _290 _290 { get; set; }
            public _291 _291 { get; set; }
            public _292 _292 { get; set; }
            public _293 _293 { get; set; }
            public _294 _294 { get; set; }
            public _295 _295 { get; set; }
            public _298 _298 { get; set; }
            public _299 _299 { get; set; }
        }

        public class _266
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _267
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _268
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _269
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _270
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _271
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _272
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _273
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _274
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _275
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _276
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _277
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _278
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _281
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _282
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _283
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _284
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _285
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _286
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _287
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _288
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _289
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _290
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _291
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _292
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _293
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _294
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _295
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _298
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class _299
        {
            public int id { get; set; }
            public string name { get; set; }
            public bool analog { get; set; }
        }

        public class Mediaserver
        {
            public _158Fa5cd00F5E1b4Ffff1a9eccc1508b _158fa5cd00f5e1b4ffff1a9eccc1508b { get; set; }
        }

        public class _158Fa5cd00F5E1b4Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public int type { get; set; }
            public string host { get; set; }
            public string uuidAction { get; set; }
            public bool useTriggerCard { get; set; }
            public States48 states { get; set; }
        }

        public class States48
        {
            public string audioEvents { get; set; }
            public string apiVersion { get; set; }
            public string serverState { get; set; }
            public string grouping { get; set; }
            public string connState { get; set; }
        }

        public class Autopilot
        {
            public _121Af596009E1A0aFfff1a9eccc1508b _121af596009e1a0affff1a9eccc1508b { get; set; }
        }

        public class _121Af596009E1A0aFfff1a9eccc1508b
        {
            public string name { get; set; }
            public string uuidAction { get; set; }
            public States49 states { get; set; }
        }

        public class States49
        {
            public string changed { get; set; }
            public string history { get; set; }
        }

        public class Messagecenter
        {
            public _125502Fc03111708Ffff1a9eccc1508b _125502fc03111708ffff1a9eccc1508b { get; set; }
        }

        public class _125502Fc03111708Ffff1a9eccc1508b
        {
            public string name { get; set; }
            public string uuidAction { get; set; }
            public States50 states { get; set; }
        }

        public class States50
        {
            public string changed { get; set; }
        }

    }
}
