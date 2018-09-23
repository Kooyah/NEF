using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class Airbuster2 : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Airbuster II");
	
			Tooltip.SetDefault("Creates a blast of air that knocks back enemies"
				+ "\nConsumes no ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 6;
			item.ranged = true;
			item.width = 54;
			item.height = 20;
			item.useTime = 55;
			item.useAnimation = 55;
			item.useStyle = 5;
			item.noMelee = false;
			item.knockBack = 28;
			item.value = 16000;
			item.rare = 2;
			item.UseSound = SoundID.Item34;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("AirFire2");
			item.shootSpeed = 10f;
			item.useAmmo = 0;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{

			float numberProjectiles = 5 + Main.rand.Next(1);
			float rotation = MathHelper.ToRadians(15);
			position += Vector2.Normalize(new Vector2(speedX, speedY)) * 65f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * .7f;
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
			
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 30f;
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
			recipe.AddIngredient(null,"Airbuster");
			recipe.AddIngredient(ItemID.EmptyBullet, 50);
			recipe.SetResult(this);

			recipe.AddRecipe();


		}

	}
}
