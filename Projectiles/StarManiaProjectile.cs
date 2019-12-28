using Terraria.ID;
using Terraria.ModLoader;

namespace NightmaresTMod.Projectiles
{
	public class StarManiaProjectile : ModProjectile
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Star Mania");
		}

		public override void SetDefaults()
		{
			projectile.CloneDefaults(ProjectileID.Starfury);
			aiType = ProjectileID.Starfury;
		}
	}
}