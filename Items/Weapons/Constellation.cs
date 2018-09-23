using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class Constellation : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Constellation");
	
			Tooltip.SetDefault("Creates a comet trail of stardust"
				+ "\nUses fallen stars for ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 28;
			item.ranged = true;
			item.width = 52;
			item.height = 18;
			item.useTime = 6;
			item.useAnimation = 30;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 1;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item34;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("StarFire");
			item.reuseDelay = 6;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.FallenStar;
		}

		public override bool ConsumeAmmo(Player player)
		{
            		return !(player.itemAnimation < item.useAnimation - 2);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 70f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(-5, 0);
		}

		public override void AddRecipes()
		
		{
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MeteoriteBar, 16);
			recipe.AddIngredient(ItemID.FallenStar, 8);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);

			recipe.AddRecipe();

		}
	
	}
}
