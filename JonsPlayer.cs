using JonsVanities.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;

namespace JonsVanities
{
    class JonsPlayer : ModPlayer
    {
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            if (poolSize >= 1000 && Main.rand.NextBool(10))
            {
                caughtType = ModContent.ItemType<FishFlops>();
            }
        }
    }
}
