using HarmonyLib;
using Verse;

namespace TAB;

public class AerobiosisMod : Mod
{
    private Harmony _harmony;
    
    public AerobiosisMod(ModContentPack content) : base(content)
    {
        _harmony = new Harmony("telefonmast.aerobiosis");
        _harmony.PatchAll();
    }
}