using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.Enums;

namespace NEF.Projectiles
{
    public class ShadowFire : ModProjectile
    {
        public override void SetStaticDefaults()
	    {
		    DisplayName.SetDefault("Shadow Fire");
	    }
		
	public override void SetDefaults()
        { 
            projectile.width = 7;      
            projectile.height = 7; 
            projectile.friendly = true;     
            projectile.melee = true;        
            projectile.tileCollide = true;   
            projectile.penetrate = 4;
	    projectile.alpha = 225;     
            projectile.timeLeft = 35;  
            projectile.light = 0.4f;
            projectile.extraUpdates = 1;
   		    projectile.ignoreWater = false;   
        }
        public override void AI()         
        {                                                    
            projectile.rotation = (float)Math.Atan2((double)projectile.velocity.Y, (double)projectile.velocity.X) + 1.57f;  
       	
		    if (Main.rand.Next(1) == 0)
			{
				int dustIndex = Dust.NewDust(new Vector2(projectile.position.X, projectile.position.Y), projectile.width, projectile.height, mod.DustType<Dusts.ShadowDust>(), projectile.velocity.X * 0.2f, projectile.velocity.Y * 0.2f, 200, default(Color), 0.7f);
				Main.dust[dustIndex].velocity += projectile.velocity * 1f;
				Main.dust[dustIndex].velocity *= 0.2f;
			}
		}

	public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
        	Player player = Main.player[projectile.owner];
		target.immune[projectile.owner] = 2;
		target.AddBuff(BuffID.ShadowFlame, 150, true);
    	}	
    }
}