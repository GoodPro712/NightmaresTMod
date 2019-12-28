using Microsoft.Xna.Framework;
using NightmaresTMod.Projectiles;
using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Weapons.Melee
{
	public class StarMania : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("'Summons a volley of mighty stars'");
		}

		public override void SetDefaults()
		{
			item.damage = 620;
			item.crit = 2;
			item.melee = true;
			item.width = 32;
			item.height = 32;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 7f;
			item.value = 1200000; //1 Platinum, 20 Gold
			item.rare = 10; //Red rarity
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
			item.scale = 1.7f;
			item.shoot = ModContent.ProjectileType<StarManiaProjectile>();
			item.shootSpeed = 30f;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.StarWrath, 1);
			recipe.AddIngredient(ItemID.Starfury, 1);
			recipe.AddTile(412);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}

		public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
		{
			type = ModContent.ProjectileType<StarManiaProjectile>();
			int numberProjectiles = 4 + Main.rand.Next(6);  //This defines how many projectiles to shot
			for (int index = 0; index < numberProjectiles; ++index)
			{
				Vector2 vector2_1 = new Vector2((float)(player.position.X + player.width * 0.5 + Main.rand.Next(201) * -player.direction + (Main.mouseX + (double)Main.screenPosition.X - player.position.X)), (float)(player.position.Y + player.height * 0.5 - 600.0));   //this defines the projectile width, direction and position
				vector2_1.X = (float)((vector2_1.X + (double)player.Center.X) / 2.0) + Main.rand.Next(-200, 201);
				vector2_1.Y -= 100 * index;
				float num12 = Main.mouseX + Main.screenPosition.X - vector2_1.X;
				float num13 = Main.mouseY + Main.screenPosition.Y - vector2_1.Y;
				if (num13 < 0.0) num13 *= -1f;
				if (num13 < 20.0) num13 = 20f;
				float num14 = (float)Math.Sqrt(num12 * (double)num12 + num13 * (double)num13);
				float num15 = item.shootSpeed / num14;
				float num16 = num12 * num15;
				float num17 = num13 * num15;
				float SpeedX = num16 + Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile X position speed and randomnes
				float SpeedY = num17 + Main.rand.Next(-40, 41) * 0.02f;  //this defines the projectile Y position speed and randomnes
				Projectile.NewProjectile(vector2_1.X, vector2_1.Y, SpeedX, SpeedY, type, damage, knockBack, Main.myPlayer, 0.0f, Main.rand.Next(5));
			}
			return false;
		}
	}
}