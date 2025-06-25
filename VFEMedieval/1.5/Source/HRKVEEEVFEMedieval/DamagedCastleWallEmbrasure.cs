using RimWorld;
using Verse;

namespace HRKVEEEVFEMedieval
{
    public class DamagedCastleWallEmbrasure : Building
    {
        public override void TickRare()
        {
            base.TickRare();

            if (this.HitPoints > 0.3 * MaxHitPoints)
            {
                Thing thingToMake = GenSpawn.Spawn(ThingMaker.MakeThing(HRKVEEEVFEMedieval_DefOf.HRK_CastleWallEmbrasure, this.Stuff), this.PositionHeld, this.Map);
                thingToMake.SetFaction(this.Faction);
                DamageInfo dinfo = new DamageInfo(DamageDefOf.Blunt, thingToMake.HitPoints * 0.4f);
                thingToMake.TakeDamage(dinfo);
                if (this.Spawned)
                {
                    this.Destroy();
                }


            }
        }

    }
}
