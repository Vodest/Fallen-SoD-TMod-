using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items.Armor
{
    [AutoloadEquip(EquipType.Body)]
    public class LeadguardArmor : ModItem
	{
		public override void SetStaticDefaults()
		{
			base.SetStaticDefaults();
			DisplayName.SetDefault("Lead Townsguard Armor");
			Tooltip.SetDefault("The Armor of a Regretful Man."
				+ "\nThe Wearer is immune to 'On Fire!'");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 3;
            item.defense = 20;
		}

		public override void UpdateEquip(Player player)
		{
			player.buffImmune[BuffID.OnFire] = true;
			player.statManaMax2 += 40;
		}
	}
}