using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class Oiler : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Oiler");
	
			Tooltip.SetDefault("Shoots oil that increases damage from fire"
				+ "\nConsumes no ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 4;
			item.ranged = true;
			item.width = 38;
			item.height = 22;
			item.useTime = 55;
			item.useAnimation = 55;
			item.useStyle = 5;
			item.noMelee = false;
			item.knockBack = 0;
			item.value = 80000;
			item.rare = 0;
			item.UseSound = SoundID.Item11;
			item.autoReuse = false;
			item.shoot = mod.ProjectileType("OilFire");
			item.shootSpeed = 10f;
			item.useAmmo = 0;
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			Vector2 muzzleOffset = Vector2.Normalize(new Vector2(speedX, speedY)) * 55f;
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
	}
}
