using NightmaresTMod.Materials.Bars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Accessories.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class FaroziteWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Allows for flight and slow fall'");
		}

		public override void SetDefaults()
		{
			item.defense = 3;
			item.rare = 10;
			item.value = 70000000; //70 plat
			item.width = 18;
			item.height = 18;
			item.accessory = true;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			player.wingTimeMax = 2000;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<FaroziteBar>(), 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}