using Terraria.ID;
using Terraria.ModLoader;

namespace JonsVanities.Items
{
	//[AutoloadEquip(EquipType.Legs)]
	public class FishFlops : ModItem
	{
		public override void SetStaticDefaults() 
		{
			Tooltip.SetDefault("Woah! Fish for the... feet?");
		}

		public override void SetDefaults() 
		{
			item.rare = -1;
			item.vanity = true;
		}

        public override bool DrawLegs()
        {
			return false;
        }
    }
}