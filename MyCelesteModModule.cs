namespace MyCelesteMod;

public class MyCelesteModModule : EverestModule
{
    public override void Load()
    {
        Logger.Log(LogLevel.Info, "MyCelesteMod", "Hello World!");
        
    }

    public override void Unload()
    {
    }
}