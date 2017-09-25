using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace FallenSoD.NPCs
{
    [AutoloadHead]
    public class kazarknight : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "FallenSoD/NPCs/kazarknight";
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Knight of the Calamity";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Knight of the Calamity");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 8;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 500;
            npc.defense = 90;
            npc.lifeMax = 400;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.knockBackResist = 0.5f;
            animationType = NPCID.Guide;
        }

        public static bool TownSpawn()
        {
            if (Main.hardMode)
                return false;
            else
                return false;
        }

        public override string TownNPCName()
        {
            switch (WorldGen.genRand.Next(4))
            {
                case 0:
                    return "Kazajirr";
                default:
                    return "Kazar";
            }
        }

        public override string GetChat()
        {
            int Dryad = NPC.FindFirstNPC(NPCID.Dryad);
            if (Dryad >= 0 && Main.rand.Next(4) == 0)
            {
                return "This " + Main.npc[Dryad].GivenName + " ... Tell me, is she single? I know she's about 500 years old, but I need this information for a Friend!";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "Have you seen my Hammer? It is quite big, not really that unnoticeable....";
                case 2:
                    return "Hmpf.. You being the next lord? 'tis frustrating....";
                case 3:
                    return "I sell Bars. 'tis my duty to sell 'em, Don' ask.";
                case 4:
                    return "Lookin' for material for ye Armor? Came to the right place, I say.";
                default:
                    return "SO! The Calamity chose you? I hope you will be a worthy Lord.";
            }
        }

        public override void SetChatButtons(ref string button, ref string button2)
        {
            button = Lang.inter[28].Value;
        }

        public override void OnChatButtonClicked(bool firstButton, ref bool shop)
        {
            if (firstButton)
            {
                shop = true;
            }
        }

        public override void SetupShop(Chest shop, ref int nextSlot)
        {
            shop.item[nextSlot].SetDefaults(ItemID.CorruptSeeds);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.CrimsonSeeds);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.GoldBar);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.IronBar);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.LeadBar);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.SilverBar);
            nextSlot++;
            shop.item[nextSlot].SetDefaults(ItemID.HallowedBar);
            nextSlot++;
        }
        public override void TownNPCAttackStrength(ref int damage, ref float knockback)
        {
            damage = 20;
            knockback = 4f;
        }

        public override void TownNPCAttackCooldown(ref int cooldown, ref int randExtraCooldown)
        {
            cooldown = 30;
            randExtraCooldown = 30;
        }

        public override void TownNPCAttackProj(ref int projType, ref int attackDelay)
        {
            projType = mod.ProjectileType("SparklingBall");
            attackDelay = 1;
        }

        public override void TownNPCAttackProjSpeed(ref float multiplier, ref float gravityCorrection, ref float randomOffset)
        {
            multiplier = 12f;
            randomOffset = 2f;
        }
    }
}