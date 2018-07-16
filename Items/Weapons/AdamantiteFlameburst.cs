using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class AdamantiteFlameburst : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Adamantite Flameburst");
	
			Tooltip.SetDefault("Spews burning cinders that linger on the ground"
				+ "\nUses gel for ammo"
				+ "\n75% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 44;
			item.ranged = true;
			item.width = 44;
			item.height = 20;
			item.useTime = 5;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 450000;
			item.rare = 4;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.MolotovFire3;
			item.reuseDelay = 5;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Gel;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 65f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

		public override void AddRecipes()
		
		{
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.AdamantiteBar, 12);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);

			recipe.AddRecipe();

		}
	
	}
}
