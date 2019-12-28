using NightmaresTMod.Placeables.Blocks.Ores;
using NightmaresTMod.Tiles.Bars;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Materials.Bars
{
	public class RedtideBar : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'The bar form of the earliest ore you can obtain'");
		}

		public override void SetDefaults()
		{
			item.width = 12; // Hitbox Width
			item.height = 12; // Hitbox Height
			item.useTime = 10; // Speed before reuse
			item.useAnimation = 10; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword
			item.value = 9000; // 90 silver
			item.rare = 3; //??? Rarity
			item.UseSound = SoundID.Item1; // Sound effect of item on use
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false
			item.consumable = true; // Will consume the item when placed.
			item.maxStack = 999; // The maximum number you can have of this item.
			item.createTile = ModContent.TileType<RedtideBarTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RedtideOre>(), 2);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}