using NightmaresTMod.Tiles.Walls;
using Terraria.ModLoader;

namespace NightmaresTMod.Placeables.Walls
{
	public class CelestiumWall : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is a modded wall.");
		}

		public override void SetDefaults()
		{
			item.width = 12;
			item.height = 12;
			item.maxStack = 999;
			item.useTurn = true;
			item.autoReuse = true;
			item.useAnimation = 15;
			item.useTime = 7;
			item.useStyle = 1;
			item.consumable = true;
			item.createWall = ModContent.WallType<CelestiumWallTile>();
		}
	}
}