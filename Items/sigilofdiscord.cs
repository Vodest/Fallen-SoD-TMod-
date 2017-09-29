using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
	public class sigilofdiscord : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Cursed Greatsword 'Thanatos'");
            Tooltip.SetDefault("She calls for Blood ...");
		}
		public override void SetDefaults()
		{
			item.damage = 65;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 10;
			item.value = 500000;
			item.rare = 5;
			item.UseSound = SoundID.Item1;
			item.autoReuse = true;
        }

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.GoldBar, 10);
			recipe.AddIngredient(ItemID.IronBar, 15);
			recipe.anyIronBar = true;
			recipe.AddIngredient(ItemID.SilverBar, 5);
            recipe.AddIngredient(null, "RegretLeadGreatsword", 1);
            recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
		
		public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            player.AddBuff(BuffID.Wrath, 5 * 60);
			player.AddBuff(BuffID.Rage, 5 * 60);
			player.AddBuff(BuffID.Sharpened, 5 * 60);      
		}
	}
}
