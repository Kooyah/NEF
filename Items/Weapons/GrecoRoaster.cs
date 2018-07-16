using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class GrecoRoaster : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Greco Roaster");
	
			Tooltip.SetDefault("Spews a burst of three lingering cinders"
				+ "\nUses gel for ammo"
				+ "\n75% chance to not consume ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 96;
			item.ranged = true;
			item.width = 56;
			item.height = 28;
			item.useTime = 24;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 5;
			item.value = 408000;
			item.rare = 5;
			item.UseSound = SoundID.Item11;
			item.autoReuse = true;
			item.shoot = ProjectileID.MolotovFire3;
			item.shootSpeed = 16f;
			item.useAmmo = AmmoID.Gel;
		}

		public override bool ConsumeAmmo(Player player)
		{
			return Main.rand.NextFloat() >= .75f;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			int numberProjectiles = 3 + Main.rand.Next(2);
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = new Vector2(speedX, speedY).RotatedByRandom(MathHelper.ToRadians(12)); 
				Projectile.NewProjectile(position.X, position.Y, perturbedSpeed.X, perturbedSpeed.Y, type, damage, knockBack, player.whoAmI);
			}
			return false;
		}

		public override void AddRecipes()
		
		{
	ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SpookyWood, 200);
			recipe.AddTile(TileID.MythrilAnvil);
			recipe.SetResult(this);

			recipe.AddRecipe();

		}
	
	}
}
