using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.JustinBailey
{
	public class EasterEgg : ModItem
	{
		public override void SetDefaults()
		{

			item.width = 22;
			item.height = 26;
			item.maxStack = 1;
			item.value = 0;
			item.rare = -11;
		}
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Easter Egg");
			Tooltip.SetDefault("Right click to open\n'Thanks for supporting NEF!'");			
		}

        	public override bool CanRightClick()
        	{
            	return true;
        	}

        	public override void RightClick(Player player)
        	{
            	int choice = Main.rand.Next(0);
            	if (choice == 0)
            	{
			player.QuickSpawnItem(mod.ItemType("KooyahsHood"));
			player.QuickSpawnItem(mod.ItemType("KooyahsWavemail"));
			player.QuickSpawnItem(mod.ItemType("KooyahsGreaves"));
            	}
	}
}
}