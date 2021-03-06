using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class WeldingTorch : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Welding Torch");
	
			Tooltip.SetDefault("Spews a concentrated stream of fire"
				+ "\nUses gel for ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 32;
			item.ranged = true;
			item.width = 28;
			item.height = 44;
			item.useTime = 5;
			item.useAnimation = 25;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 20200;
			item.rare = 2;
			item.UseSound = SoundID.Item34;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("TorchFire");
			item.reuseDelay = 10;
			item.shootSpeed = 10f;
			item.useAmmo = AmmoID.Gel;
		}

		public override bool ConsumeAmmo(Player player)
		{
            		return !(player.itemAnimation < item.useAnimation - 2);
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 30f;
			if (Collision.CanHit(position, 0, 0, position + muzzleOffset, 0, 0))
			{
				position += muzzleOffset;
			}
			return true;
		}

		public override Vector2? HoldoutOffset()
		{
			return new Vector2(0, 3);
		}

		public override void AddRecipes()
		
		{
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.HellstoneBar, 12);
			recipe.AddIngredient(ItemID.Wire, 30);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);

			recipe.AddRecipe();
		
		}
	
	}
}
