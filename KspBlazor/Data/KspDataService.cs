using KspBlazor.Data;
using KspBlazor.Pages;
using Microsoft.AspNetCore.Components;

public class KspDataService
{
    public KspData kspData { get; set; }
    public static KspDataService? Instance;
    public static Timer timer = new Timer(UpdateTimerCallback, null, 0, 200);
    public static int counter = 0;
    public Ksp ksp;
    static void UpdateTimerCallback(object? state)
    {
        counter++;
        if (Instance != null)
        {
            Instance.kspData.Seconds = counter;
        }
    }
    public KspDataService()
    {
        ksp = new Ksp();
        kspData = ksp.GetData();
        kspData.Seconds = counter;
        Instance = this;
    }
    public void Refresh()
    {
        kspData = ksp.GetData();
    }
    public Task<KspData> GetDataAsync()
    {
        kspData = ksp.GetData();
        kspData.Seconds = counter;
        return Task.FromResult(kspData);
    }
}