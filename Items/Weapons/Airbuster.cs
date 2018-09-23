using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class Airbuster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Airbuster");
	
			Tooltip.SetDefault("Creates a blast of air that knocks back enemies"
				+ "\nConsumes no ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 2;
			item.ranged = true;
			item.width = 46;
			item.height = 14;
			item.useTime = 55;
			item.useAnimation = 55;
			item.useStyle = 5;
			item.noMelee = false;
			item.knockBack = 18;
			item.value = 8000;
			item.rare = 0;
			item.UseSound = SoundID.Item34;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("AirFire");
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
			
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 20f;
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
			recipe.AddIngredient(ItemID.IronBar, 12);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Bottle, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);

			recipe.AddRecipe();



			recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.LeadBar, 12);
			recipe.AddIngredient(ItemID.Wood, 10);
			recipe.AddIngredient(ItemID.Bottle, 6);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);

			recipe.AddRecipe();

		
		}

	}
}
