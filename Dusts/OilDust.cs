using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace NEF.Dusts
{
	public class OilDust : ModDust
	{
        	public override void OnSpawn(Dust dust)
        	{
        	   dust.color = new Color(14, 13, 29);  
        	   dust.alpha = 100;
        	   dust.scale = 1.13f;
		   dust.velocity.Y = Main.rand.Next(-10, 6) * 0.1f;
		   dust.velocity.X *= 0f;
        	   dust.noGravity = true;
       		   dust.noLight = false;
        	}

	        public override bool Update(Dust dust)
        	{
	            dust.position += dust.velocity;
	            dust.rotation += dust.velocity.X * 0.15f;
            	    dust.scale *= 0.9f;
		    dust.velocity.Y += -0f;                    
            	    float light = 0.35f * dust.scale;
            	    Lighting.AddLight(dust.position, 0f, 0f, 0f);

            	    if (dust.scale < 0.5f)
            	    {
                	dust.active = false;
                    }
            	    
		    return false;
        	}
    	}
}