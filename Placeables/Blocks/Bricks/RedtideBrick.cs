using NightmaresTMod.Materials.Bars;
using NightmaresTMod.Tiles.Bricks;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Placeables.Blocks.Bricks
{
	public class RedtideBrick : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Redtide Brick");
		}

		public override void SetDefaults()
		{
			item.width = 12; // Hitbox Width
			item.height = 12; // Hitbox Height
			item.useTime = 10; // Speed before reuse
			item.useAnimation = 10; // Animation Speed
			item.useStyle = 1; // 1 = Broadsword
			item.value = 240000; // 24 gold
			item.rare = 7; //Lime rarity
			item.UseSound = SoundID.Item1; // Sound effect of item on use
			item.autoReuse = true; // Do you want to torture people with clicking? Set to false
			item.consumable = true; // Will consume the item when placed.
			item.maxStack = 999; // The maximum number you can have of this item.
			item.createTile = ModContent.TileType<RedtideBrickTile>();
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<RedtideBar>(), 2);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}
	}
}