using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NEF
{
	public class NEFGlobalNPC : GlobalNPC
	{

		public override bool InstancePerEntity
		{
			get
			{
				return true;
			}
		}

		public bool NapalmFire1 = false;
		public bool NapalmFire2 = false;
		public bool NapalmFire3 = false;
		
		public override void UpdateLifeRegen(NPC npc, ref int damage)
		{
			if (NapalmFire1)
			{
				if (npc.lifeRegen > 0)
				{
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 10;	
			}

			if (NapalmFire2)
			{
				if (npc.lifeRegen > 0)
				{
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 10;	
			}

			if (NapalmFire3)
			{
				if (npc.lifeRegen > 0)
				{
					npc.lifeRegen = 0;
				}
				npc.lifeRegen -= 10;	
			}
		}

		public override void DrawEffects(NPC npc, ref Color drawColor)
		{
			if (NapalmFire3)
			{
				if (Main.rand.Next(5) < 4)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType<Dusts.NapalmDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 1f, 0.5f, 0.1f);
			}

			if (NapalmFire2)
			{
				if (Main.rand.Next(5) < 4)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType<Dusts.NapalmDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 1f, 0.5f, 0.1f);
			}

			if (NapalmFire1)
			{
				if (Main.rand.Next(5) < 4)
				{
					int dust = Dust.NewDust(npc.position - new Vector2(2f, 2f), npc.width + 4, npc.height + 4, mod.DustType<Dusts.NapalmDust>(), npc.velocity.X * 0.4f, npc.velocity.Y * 0.4f, 100, default(Color), 1f);
					Main.dust[dust].noGravity = true;
					Main.dust[dust].velocity *= 1.8f;
					Main.dust[dust].velocity.Y -= 0.5f;
					if (Main.rand.Next(4) == 0)
					{
						Main.dust[dust].noGravity = false;
						Main.dust[dust].scale *= 0.5f;
					}
				}
				Lighting.AddLight(npc.position, 1f, 0.5f, 0.1f);
			}
		}

		public override void ResetEffects(NPC npc)
		{
			NapalmFire1 = false;
			NapalmFire2 = false;
			NapalmFire3 = false;
		}
	
		public override void NPCLoot(NPC npc)
		{
			if (npc.type == NPCID.GoblinSummoner && Main.rand.Next(6) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("Hexspitter"));
			}

			if (npc.type == NPCID.GoblinSummoner && Main.rand.Next(60) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EasterEgg"));
			}

			if (npc.type == NPCID.Plantera && Main.rand.Next(7) <= 2)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("PestControl"));
			}

			if (npc.type == NPCID.Plantera && Main.rand.Next(70) <= 2)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EasterEgg"));
			}

			if (npc.type == NPCID.CultistBoss && Main.rand.Next(3) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("TheRaiju"));
			}

			if (npc.type == NPCID.CultistBoss && Main.rand.Next(30) <= 1)
			{
				Item.NewItem((int)npc.position.X, (int)npc.position.Y, npc.width, npc.height, mod.ItemType("EasterEgg"));
			}
		}

		public override void SetupShop(int type, Chest shop, ref int nextSlot)
		{
			if(type == NPCID.Demolitionist)
			{
				if(Main.hardMode)
				{
					if(!WorldGen.crimson)
					{
						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroBlueMask"));

						nextSlot++;

						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroBlueSuit"));
						nextSlot++;

						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroBluePants"));
						nextSlot++;
					}

					else
					{
						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroRedMask"));

						nextSlot++;

						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroRedSuit"));
						nextSlot++;

						shop.item[nextSlot].SetDefaults(mod.ItemType("PyroRedPants"));
						nextSlot++;
					}
				}
			}

			if(type == NPCID.TravellingMerchant)
			{
				if(Main.hardMode)
				{
					if(NPC.downedPlantBoss)
					{
						shop.item[nextSlot].SetDefaults(mod.ItemType("PulseThrower"));

						nextSlot++;
					}
				}
			}

			if(type == NPCID.Mechanic)
			{
				shop.item[nextSlot].SetDefaults(mod.ItemType("Oiler"));
				nextSlot++;
			}
		}
	}
}
