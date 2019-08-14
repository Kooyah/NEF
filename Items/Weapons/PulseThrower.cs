using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF.Items.Weapons
{
	public class PulseThrower : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pulse Thrower");
	
			Tooltip.SetDefault("Fires a stream of pulse waves"
				+ "\nConsumes no ammo");
		}

		public override void SetDefaults()
		{
			item.damage = 47;
			item.ranged = true;
			item.width = 48;
			item.height = 22;
			item.useTime = 2;
			item.useAnimation = 2;
			item.useStyle = 5;
			item.noMelee = true;
			item.knockBack = 0;
			item.value = 450000;
			item.rare = 8;
			item.UseSound = SoundID.Item15;
			item.autoReuse = true;
			item.shoot = mod.ProjectileType("PulseFire");
			item.reuseDelay = 6;
			item.shootSpeed = 10f;
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
			return new Vector2(0, 0);
		}
	}
}
