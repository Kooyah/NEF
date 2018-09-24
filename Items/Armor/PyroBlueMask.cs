using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class PyroBlueMask : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Incendiary Mask");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.value = 50000;
			item.vanity = true;
			item.rare = 1;
			item.defense = 0;
		}
	}
}