using KRPC.Client;
using KRPC.Client.Services.KRPC;
using KRPC.Client.Services.SpaceCenter;

public class Ksp : IDisposable
{
    private Connection connection;
    private KRPC.Client.Services.KRPC.Service KRPC;
    private Vessel vessel;
    private Flight flight;
    private Control control;
    public Ksp()
    {
        RefreshObjects();
    }
    void RefreshObjects()
    {
        try
        {
            if (connection == null)
            {
                connection = new Connection(name: "KSP");
            }
            if (KRPC == null)
            {
                KRPC = connection.KRPC();
            }
            //vessel = connection.SpaceCenter().ActiveVessel;
            //var kerbinRF = connection.SpaceCenter().Bodies["Kerbin"].ReferenceFrame;
            //var vesselNames = connection.SpaceCenter().Vessels.Select(t => t.Name + " - " + t.Type.ToString() + " - " +
            //t.Position(kerbinRF).ToString() + " - " + t.Orbit.OrbitalSpeed + " - " + t.Crew.Count).ToArray();
            //flight = vessel.Flight();
            //control = vessel.Control;
        }
        catch
        {
        }
    }

    //internal void Run()
    //{
    //    var kerbinRF = connection.SpaceCenter().Bodies["Kerbin"].ReferenceFrame;
    //    var vesselNames = connection.SpaceCenter().Vessels.Select(t => t.Name + " - " + t.Type.ToString() + " - " + t.Position(kerbinRF).ToString() + " - " + t.Orbit.OrbitalSpeed + " - " + t.Crew.Count).ToArray();
    //    var s = "";
    //    foreach (var item in vesselNames)
    //    {
    //        s += Environment.NewLine + item;
    //    }
    //    Console.WriteLine(s);
    //}

    public void Dispose()
    {
        connection?.Dispose();
    }
}
