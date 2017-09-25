using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
    public class IronGreatsword : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Iron Greatsword");
            Tooltip.SetDefault("Heavy, but stronger than the usual Broadsword");
        }
        public override void SetDefaults()
        {
            item.damage = 27;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 35;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 400;
            item.rare = 3;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 30);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
