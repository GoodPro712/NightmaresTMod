using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Projectiles
{
	public class StarManiaProjectile : ModProjectile
	{
		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
		}

		public override void AI()
		{
			projectile.frame = Main.rand.Next(1, 2);
		}
	}
}