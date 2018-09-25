using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.JustinBailey
{
	[AutoloadEquip(EquipType.Body)]
	public class KooyahsWavemail : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Kooyah's Chestplate");
		}

		public override void SetDefaults()
		{
			item.width = 30;
			item.height = 20;
			item.value = 0;
			item.vanity = true;
			item.rare = -11;
			item.defense = 0;
		}
	}
}