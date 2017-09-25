using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
    public class khammer : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Calamitous Greathammer");
            Tooltip.SetDefault("The Greathammer of a certain Knight - A Knight of Calamitous Courage.");
        }
        public override void SetDefaults()
        {
            item.damage = 199;
            item.melee = true;
            item.width = 80;
            item.height = 80;
            item.useTime = 40;
            item.useAnimation = 40;
            item.useStyle = 1;
            item.knockBack = 20;
            item.value = 99999999;
            item.rare = 11;
            item.UseSound = SoundID.Item1;
            item.autoReuse = false;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.anyIronBar = true;
            recipe.AddIngredient(ItemID.IronBar, 99);
            recipe.AddIngredient(ItemID.SoulofMight, 20);
            recipe.AddIngredient(ItemID.HallowedBar, 50);
            recipe.AddIngredient(ItemID.GoldBar, 99);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}