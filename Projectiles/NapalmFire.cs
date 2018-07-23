using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Enums;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;

namespace NEF.Projectiles
{
    public class NapalmFire : ModProjectile
    {
        public override void SetStaticDefaults()
	    {
		    DisplayName.SetDefault("Napalm Fire");
	    }
		
	public override void SetDefaults()
        { 
            projectile.width = 7;      
            projectile.height = 7; 
            projectile.friendly = true;     
            projectile.melee = true;        
            projectile.tileCollide = true;   
            projectile.penetrate = 999;
	    projectile.alpha = 225;     
            projectile.timeLeft = 52;  
            projectile.light = 0.5f;
            projectile.extraUpdates = 1;
   		    projectile.ignoreWater = false;   
        }
        public override void AI()         
        {                                                    
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;  
       	
		    if (Main.rand.Next(1) == 0)
			{
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, mod.DustType<Dusts.MolotovDust>(), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 200, default(Color), 0.7f);
				Main.dust[dustIndex].velocity += projectile.velocity * 1f;
				Main.dust[dustIndex].velocity *= 0.2f;
			}
		}

		public override void OnHitNPC(NPC target, int damage, float knockback, bool crit) //if (target.FindBuffIndex(mod.BuffType("Debuff1") == -1)) has mod.BuffType("Debuff1") == -1 which evaluates to a bool, and target.FindBuffIndex(bool) doesn't exist
        	{

			if (Main.rand.Next(1) == 0)
			{
				target.AddBuff(BuffID.OnFire, 1000, true);
			}

			if (mod.BuffType("NapalmFire1") == -1)
			{
				if (Main.rand.Next(3) == 0)
				{
					target.AddBuff(mod.BuffType("NapalmFire1"), 1000, true);
				}
			}

			if (mod.BuffType("NapalmFire1") > -1)
			{
				if (Main.rand.Next(3) == 0)
				{
					target. AddBuff(mod.BuffType("NapalmFire2"), 1000, true);
				}
			}

			if (mod.BuffType("NapalmFire2") > -1)
			{
				if (Main.rand.Next(3) == 0)
				{
					target. AddBuff(mod.BuffType("NapalmFire3"), 1000, true);
				}
			}
    		}
	}
 }