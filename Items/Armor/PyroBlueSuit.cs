using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Armor
{
	[AutoloadEquip(EquipType.Body)]
	public class PyroBlueSuit : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Incendiary Suit");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 50000;
			item.vanity = true;
			item.rare = 1;
			item.defense = 0;
		}
	}
}