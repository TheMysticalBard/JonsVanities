using JonsVanities.Items;
using Terraria;
using Terraria.ModLoader;

namespace JonsVanities
{
    class JonsPlayer : ModPlayer
    {
        public override void CatchFish(Item fishingRod, Item bait, int power, int liquidType, int poolSize, int worldLayer, int questFish, ref int caughtType, ref bool junk)
        {
            //This is equal to the very rare rarity of vanilla Terraria fish.
            float catchChance = 1 / (2250 / power);
            if (catchChance > 0.2f)
                catchChance = 0.2f;

            //If in the oceam (poolSize doesn't go higher than 75 for some reason) and the chance is met, catch the fish flops!
            if (poolSize >= 75 && player.ZoneBeach && Main.rand.NextFloat() <= catchChance)
            {
                caughtType = ModContent.ItemType<FishFlops>();
            }
        }
    }
}
