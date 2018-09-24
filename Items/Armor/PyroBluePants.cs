using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class PyroBluePants : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Incendiary Pants");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 50000;
			item.vanity = true;
			item.rare = 1;
			item.defense = 0;
		}
	}
}