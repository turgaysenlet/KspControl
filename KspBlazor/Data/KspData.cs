using KRPC.Client.Services.SpaceCenter;

namespace KspBlazor.Data
{
    public class KspData
    {
        public string? ActiveVesselName { get; set; }
        public Vessel[] Vessels{ get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Seconds { get; set; }
        public Flight Flight { get; set; }
        public Vessel Vessel { get; set; }
        public Control Control { get; set; }
    }
}