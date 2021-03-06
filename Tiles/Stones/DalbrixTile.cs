using Microsoft.Xna.Framework;
using NightmaresTMod.Placeables.Blocks.Stones;
using Terraria;
using Terraria.ModLoader;

namespace NightmaresTMod.Tiles.Stones
{
	public class DalbrixTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ModContent.ItemType<Dalbrix>();
			minPick = 200;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Dalbrix");
			AddMapEntry(new Color(100, 155, 10), name);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.07f;
			g = 0.12f;
			b = 0f;
		}
	}
}