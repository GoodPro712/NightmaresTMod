using Microsoft.Xna.Framework;
using NightmaresTMod.Placeables.Blocks.Bricks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Tiles.Bricks
{
	public class FaroziteBrickTile : ModTile
	{
		public override void SetDefaults()
		{
			Main.tileSolid[Type] = true;
			Main.tileMergeDirt[Type] = false;
			Main.tileLighted[Type] = true;
			Main.tileBlockLight[Type] = true;
			drop = ModContent.ItemType<FaroziteBrick>();
			ModTranslation name = CreateMapEntryName();
			name.SetDefault("Farozite Brick");
			AddMapEntry(new Color(150, 200, 255), name);
			minPick = 145;
			dustType = DustID.Platinum;
			Main.tileLavaDeath[Type] = true;
		}

		public override void ModifyLight(int i, int j, ref float r, ref float g, ref float b)
		{
			r = 0.35f;
			g = 0.35f;
			b = 0.4f;
		}

		public override void NumDust(int i, int j, bool fail, ref int num)
		{
			num = fail ? 1 : 3;
		}
	}
}