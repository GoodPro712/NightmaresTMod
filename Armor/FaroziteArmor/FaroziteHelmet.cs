using NightmaresTMod.Materials.Bars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Armor.FaroziteArmor
{
	[AutoloadEquip(EquipType.Head)]
	public class FaroziteHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Farozite Helmet");
			Tooltip.SetDefault("'Protects the wearer against extreme temperatures'");
		}

		public override void SetDefaults()
		{
			item.defense = 19;
			item.rare = 9;
			item.value = 32000000; //32 platinum
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
			recipe.AddIngredient(ModContent.ItemType<FaroziteBar>(), 9);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}