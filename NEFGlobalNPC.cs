using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF
{
	public class NEFGlobalNPC : GlobalNPC
	{		
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.GoblinSummoner && Main.rand.Next(3) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Hexspitter"));
			}

			if (npc.type == NPCID.CultistBoss && Main.rand.Next(4) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheRaiju"));
			}
		}
	}
}