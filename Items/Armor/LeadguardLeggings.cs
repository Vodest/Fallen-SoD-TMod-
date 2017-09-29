using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items.Armor
{
	[AutoloadEquip(EquipType.Legs)]
	public class LeadguardLeggings : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("Leggings of a Regretful Man"
				+ "\n10% increased movement speed");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 2;
			item.defense = 10;
		}

		public override void UpdateEquip(Player player)
		{
			player.moveSpeed += 0.10f;
		}
	}
}