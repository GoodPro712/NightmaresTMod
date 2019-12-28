using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using NightmaresTMod.Projectiles;
using NightmaresTMod.Materials.Bars;

namespace NightmaresTMod.Weapons.Summoning
{
	public class MagicArrow : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'I'm Mary Poppins, y'all!'"); //nice one, nightmare
		}

		public override void SetDefaults()
		{
			item.damage = 25;
			item.summon = true;
			item.mana = 14;
			item.width = 26;
			item.height = 26;
			item.useTime = 15;
			item.useAnimation = 15;
			item.useStyle = 1;
			item.noMelee = true;
			item.channel = true;
			item.knockBack = 8;
			item.value = Item.sellPrice(silver: 50);
			item.rare = 3;
			item.UseSound = SoundID.Item9;
			item.shoot = ModContent.ProjectileType<MagicArrowProjectile>();
			item.shootSpeed = 10f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ModContent.ItemType<NightmariumBar>(), 20);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}