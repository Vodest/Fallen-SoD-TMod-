using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
	public class DiscordShards : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Shards and Shreds of the deepest and most betwixed minds.");
		}

		public override void SetDefaults()
		{
			item.width = 20;
			item.height = 20;
			item.maxStack = 99;
			item.value = 100000;
			item.rare = 3;
		}

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.SuspiciousLookingEye, 1);
            recipe.AddIngredient(ItemID.Bone, 20);
            recipe.AddIngredient(ItemID.Silk, 30);
            recipe.AddTile(TileID.DemonAltar);
            recipe.SetResult(this, 15);
            recipe.AddRecipe();
        }
    }
}
