using Microsoft.Xna.Framework;
using NightmaresTMod.Placeables.Blocks.Ores;
using Terraria;
using Terraria.ModLoader;

namespace NightmaresTMod.Tiles.Ores
{
	public class RedtideOreTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = true;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ModContent.ItemType<RedtideOre>();
			minPick = 50;

			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Redtide Ore");
			AddMapEntry(new Color(255, 120, 175), name);
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.5f;
			g = 0.1f;
			b = 0.25f;
		}
	}
}