using NightmaresTMod.Tiles.Stones;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Placeables.Blocks.Stones
{
	public class Dalbrix : ModItem
	{
		public override void SetDefaults()
		{
			item.Size = new Microsoft.Xna.Framework.Vector2(12);
			item.useTime = item.useAnimation = 10;
			item.useStyle = ItemUseStyleID.SwingThrow;
			item.value = Item.sellPrice(gold: 4);
			item.rare = ItemRarityID.Lime;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.consumable = true;
			item.maxStack = 999;
			item.createTile = ModContent.TileType<DalbrixTile>();
		}
	}
}