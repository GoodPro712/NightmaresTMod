using NightmaresTMod.Materials.Bars;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Tools
{
	public class FaroziteHamaxe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Farozite Hamaxe");
			Tooltip.SetDefault("'Shreds walls and trees'");
		}

		public override void SetDefaults()
		{
			item.damage = 92;
			item.crit = 2;
			item.melee = true;
			item.width = 36;
			item.height = 36;
			item.useTime = 5;
			item.useAnimation = 30;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 500000; //50 gold
			item.rare = 9; //Cyan(?) rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.4f;
			item.hammer = 135;
			item.axe = 165;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FaroziteBar>(), 11);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}