using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.JustinBailey
{
	[AutoloadEquip(EquipType.Head)]
	public class KooyahsVisor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Kooyah's Visor");
		}

		public override void SetDefaults()
		{
			item.width = 28;
			item.height = 24;
			item.value = 0;
			item.vanity = true;
			item.rare = -11;
			item.defense = 0;
		}
	}
}