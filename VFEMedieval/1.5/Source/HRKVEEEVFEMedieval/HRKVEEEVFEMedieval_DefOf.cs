using RimWorld;
using Verse;

namespace HRKVEEEVFEMedieval
{
    [DefOf]
    public class HRKVEEEVFEMedieval_DefOf
    {
        static HRKVEEEVFEMedieval_DefOf()
        {
            DefOfHelper.EnsureInitializedInCtor(typeof(HRKVEEEVFEMedieval_DefOf));
        }

        public static ThingDef HRK_CastleWallEmbrasure;
        public static ThingDef HRK_DamagedCastleWallEmbrasure;
    }
}
