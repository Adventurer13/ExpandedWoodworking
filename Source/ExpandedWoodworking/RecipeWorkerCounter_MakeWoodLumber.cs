using RimWorld;
using UnityEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;

namespace ExpandedWoodworking
{
	public class RecipeWorkerCounter_MakeWoodLumber : RecipeWorkerCounter
	{
		private List<ThingDef> WoodLumberDefs;

		public override bool CanCountProducts(Bill_Production bill)
		{
			return true;
		}

		public override int CountProducts(Bill_Production bill)
		{
			if (this.WoodLumberDefs == null)
			{
				ThingCategoryDef woodLumber = ThingCategoryDefOf.WoodLumber;
				this.WoodLumberDefs = new List<ThingDef>(16);
				foreach (ThingDef current in DefDatabase<ThingDef>.AllDefsListForReading)
				{
					if (current.thingCategories != null && current.thingCategories.Contains(woodLumber))
					{
						this.WoodLumberDefs.Add(current);
					}
				}
			}
			int num = 0;
			for (int i = 0; i < this.WoodLumberDefs.Count; i++)
			{
				num += bill.Map.resourceCounter.GetCount(this.WoodLumberDefs[i]);
			}
			return num;
		}

		public override string ProductsDescription(Bill_Production bill)
		{
			return ThingCategoryDefOf.WoodLumber.label;
		}
	}
}
