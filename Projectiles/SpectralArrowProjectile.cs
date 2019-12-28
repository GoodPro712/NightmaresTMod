using Terraria.ModLoader;

namespace NightmaresTMod.Projectiles
{
	public class SpectralArrowProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spectral Arrow");
		}

		public override void SetDefaults()
		{
			projectile.width = 20;
			projectile.height = 20;
			projectile.aiStyle = 1;
			projectile.friendly = true;
			projectile.melee = true;
			projectile.damage = 17;
			projectile.tileCollide = true;
			projectile.penetrate = 3;
			projectile.light = 2.5f;
			projectile.knockBack = 4;
			projectile.scale = 1f;
			projectile.arrow = true;
		}
	}
}