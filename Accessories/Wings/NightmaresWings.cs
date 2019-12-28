using NightmaresTMod.Materials.Bars;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Accessories.Wings
{
	[AutoloadEquip(EquipType.Wings)]
	public class NightmaresWings : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Nightmare's Wings");
			Tooltip.SetDefault("'Allows the wearer to fly for up to one minute'");
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
			player.wingTimeMax = 3600;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<NightmariumBar>(), 16);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override void VerticalWingSpeeds(Player player, ref float ascentWhenFalling, ref float ascentWhenRising, ref float maxCanAscendMultiplier, ref float maxAscentMultiplier, ref float constantAscend)
		{
			ascentWhenFalling = 0.85f;
			ascentWhenRising = 0.15f;
			maxCanAscendMultiplier = 1f;
			maxAscentMultiplier = 3f;
			constantAscend = 0.135f;
		}

		public override void HorizontalWingSpeeds(Player player, ref float speed, ref float acceleration)
		{
			speed = 20f;
			acceleration *= 2.5f;
		}
	}
}