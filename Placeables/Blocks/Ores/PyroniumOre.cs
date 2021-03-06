using NightmaresTMod.Tiles.Ores;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Placeables.Blocks.Ores
{
	public class PyroniumOre : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Pyronium Ore");
			Tooltip.SetDefault("'It burns so much, it feels cold");
		}

		public override void SetDefaults()
		{
			item.width = 12; // Hitbox Width
			item.height = 12; // Hitbox Height
			item.useTime = 10; // Speed before reuse
			item.useAnimation = 10; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword
			item.value = 7000; // 70 silver
			item.rare = 7; //Lime rarity
			item.UseSound = SoundID.Item1; // Sound effect of item on use
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false
			item.consumable = true; // Will consume the item when placed.
			item.maxStack = 999; // The maximum number you can have of this item.
			item.createTile = ModContent.TileType<PyroniumOreTile>();
		}
	}
}