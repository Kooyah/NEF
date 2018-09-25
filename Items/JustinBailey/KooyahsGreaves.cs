using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.JustinBailey
{
	[AutoloadEquip(EquipType.Legs)]
	public class KooyahsGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Kooyah's Greaves");
		}

		public override void SetDefaults()
		{
			item.width = 22;
			item.height = 18;
			item.value = 0;
			item.vanity = true;
			item.rare = -11;
			item.defense = 0;
		}
	}
}