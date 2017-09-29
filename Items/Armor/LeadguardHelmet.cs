using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace FallenSoD.Items.Armor
{
	[AutoloadEquip(EquipType.Head)]
	public class LeadguardHelmet : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Helmet of a Regretful Man.");
		}

		public override void SetDefaults()
		{
			item.width = 18;
			item.height = 18;
			item.value = 1000;
			item.rare = 3;
			item.defense = 10;
		}

		public override bool IsArmorSet(Item head, Item body, Item legs)
		{
			return body.type == mod.ItemType("LeadguardArmor") && legs.type == mod.ItemType("LeadguardLeggings");
		}

		public override void UpdateArmorSet(Player player)
		{
			player.setBonus = "Town-defender";
			player.meleeDamage *= 0.25f;
			player.thrownDamage *= 0.25f;
			player.rangedDamage *= 0.25f;
			player.magicDamage *= 0.25f;
		}
    }
}