using NightmaresTMod.Materials.Bars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Armor.CelestiumArmor
{
	[AutoloadEquip(EquipType.Legs)]
	public class CelestiumGreaves : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'no more hott'");
		}

		public override void SetDefaults()
		{
			item.defense = 23;
			item.rare = 9;
			item.value = 32000000; //32 plat
			item.width = 18;
			item.height = 18;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<CelestiumBar>(), 7);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}