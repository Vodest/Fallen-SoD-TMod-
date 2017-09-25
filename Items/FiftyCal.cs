using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
	public class FiftyCal : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("A Step into a Dark Future.");
		}

		public override void SetDefaults()
		{
			item.damage = 93;
			item.ranged = true;
			item.width = 8;
			item.height = 8;
			item.maxStack = 999;
			item.consumable = true;             //You need to set the item consumable so that the ammo would automatically consumed
			item.knockBack = 1.5f;
			item.value = 10;
			item.rare = 2;
			item.shoot = mod.ProjectileType("FiftyCaliber");   //The projectile shoot when your weapon using this ammo
			item.shootSpeed = 16f;                  //The speed of the projectile
			item.ammo = AmmoID.Bullet;              //The ammo class this ammo belongs to.
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 50);
			recipe.AddIngredient(ItemID.LeadBar, 50);
            recipe.anyIronBar = true;
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this, 25);
			recipe.AddRecipe();
		}*/
	}
}
