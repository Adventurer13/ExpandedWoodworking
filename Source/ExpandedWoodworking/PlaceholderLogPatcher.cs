using RimWorld;
using Verse;
using System;
using System.Linq;
using System.Collections.Generic;

namespace ExpandedWoodworking
{
    public class PlaceholderLogPatcher
    {
        public void Patcher()
        {
            IEnumerable<ThingDef> treesUsingVanillaLogs = DefDatabase<ThingDef>.AllDefsListForReading.Where(x => x.plant != null && x.plant.harvestedThingDef != null && x.plant.harvestedThingDef == ThingDef.Named("WoodLog"));
            foreach (ThingDef tree in treesUsingVanillaLogs)
            {
                tree.plant.harvestedThingDef = ThingDef.Named("WoodLog_Generic");
            }
        }

    }
}