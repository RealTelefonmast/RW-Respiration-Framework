using Verse;

namespace TRR;

public abstract class RespirationWorker
{
    public abstract void OnInterval(Pawn pawn, float needLevel, Need_Respiration need = null);
}