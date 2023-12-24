namespace Celeste.Mod.MyCelesteMod;

public class MyCelesteModModule : EverestModule
{
    public override void Load()
    {
        Instance = this;
    }

    public override void Unload()
    {
    }
}