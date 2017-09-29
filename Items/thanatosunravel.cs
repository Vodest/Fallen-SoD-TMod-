using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
    public class thanatosunravel : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Thanatum Clamatis");
            Tooltip.SetDefault("She has awoken.");
        }
        public override void SetDefaults()
        {
            item.damage = 535;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = 1;
            item.knockBack = 10;
            item.value = 0;
            item.rare = 12;
            item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("SparklingBall");
            item.shootSpeed = 18f;
        }
		
		public override bool CanUseItem(Player player)
        {
            return Main.hardMode;
        }
		
        public override void AddRecipes()
        {
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "sigilofdiscord", 1);
			recipe.AddIngredient(ItemID.SoulofMight, 30);
			recipe.AddIngredient(ItemID.SoulofFright, 30);
			recipe.AddIngredient(ItemID.SoulofSight, 30);
			recipe.AddIngredient(ItemID.SoulofLight, 30);
			recipe.AddIngredient(ItemID.SoulofNight, 30);
			recipe.AddIngredient(ItemID.SoulofFlight, 30);
			recipe.AddIngredient(ItemID.LeadBar, 50);
            recipe.AddIngredient(null, "DiscordShards", 60);
			recipe.anyIronBar = true;
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}	
		
	    public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
            target.AddBuff(BuffID.OnFire, 5 * 60);
            player.AddBuff(BuffID.Wrath, 5 * 60);
            player.AddBuff(BuffID.Rage, 5 * 60);
            player.AddBuff(BuffID.Sharpened, 5 * 60);
        }
    }
}
