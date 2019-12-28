using Microsoft.Xna.Framework;
using NightmaresTMod.Placeables.Blocks.Ores;
using Terraria;
using Terraria.ModLoader;

namespace NightmaresTMod.Tiles.Ores
{
	public class PyroniumOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ModContent.ItemType<PyroniumOre>();
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("PyroniumOre");
			AddMapEntry(new Color(255, 100, 0), name);
			minPick = 220;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.20f;
			b = 0f;
		}
	}
}