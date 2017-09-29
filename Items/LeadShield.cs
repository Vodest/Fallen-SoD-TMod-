using Terraria;
using Terraria.ModLoader;

namespace FallenSoD.Items
{
	[AutoloadEquip(EquipType.Shield)]
	public class LeadShield : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Lead-shield of a Regretful man,"
				+ "Heavy, but strangely Indestructable.");
		}

		public override void SetDefaults()
		{
			item.width = 24;
			item.height = 28;
			item.value = 0;
			item.rare = 3;
			item.accessory = true;
			item.defense = 15;
			item.lifeRegen = 20;
		}
	}
}