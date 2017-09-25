using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
	public class lilimscythe : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Lunar Greatscythe");
			Tooltip.SetDefault("The Tool and Weapon of the First Daughter.");
		}
		public override void SetDefaults()
		{
			item.damage = 87;
			item.melee = true;
			item.width = 80;
			item.height = 80;
			item.useTime = 40;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 5;
			item.value = 60000;
			item.rare = 7;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		/*public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
		    recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.IronBar, 55);
			recipe.AddIngredient(ItemID.CopperBar, 15);
			recipe.AddIngredient(ItemID.SilverBar, 15);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}*/
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            player.AddBuff(BuffID.Wrath, 5 * 60);
		}
	}
}
