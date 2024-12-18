namespace Celeste.Mod.MyCelesteMod;

public class MyCelesteModModule : EverestModule
{
    public static MyCelesteModModule Instance { get; private set; }

#if IncludeSettings
    public override Type SettingsType => typeof(MyCelesteModSettings);
    public static MyCelesteModSettings Settings => (MyCelesteModSettings)Instance._Settings;

#endif
#if IncludeSession
    public override Type SessionType => typeof(MyCelesteModSession);
    public static MyCelesteModSession Session => (MyCelesteModSession) Instance._Session;

#endif
#if IncludeSaveData
    public override Type SaveDataType => typeof(MyCelesteModSaveData);
    public static MyCelesteModSaveData SaveData => (MyCelesteModSaveData)Instance._SaveData;

#endif
    public override void Load()
    {
    }

    public override void Unload()
    {
    }
}