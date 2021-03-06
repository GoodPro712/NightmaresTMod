using Microsoft.Xna.Framework;
using NightmaresTMod.Placeables.Blocks.Ores;
using Terraria;
using Terraria.ModLoader;

namespace NightmaresTMod.Tiles.Ores
{
	public class CelestiumOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ModContent.ItemType<CelestiumOre>();
			minPick = 240;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Celestium Ore");
			AddMapEntry(new Color(100, 10, 255), name);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.4f;
			b = 0.5f;
		}
	}
}