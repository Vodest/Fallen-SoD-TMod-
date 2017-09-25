using System.Linq;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.Utilities;

namespace FallenSoD.NPCs
{
    [AutoloadHead]
    public class IbaNPC : ModNPC
    {
        public override string Texture
        {
            get
            {
                return "FallenSoD/NPCs/IbaNPC";
            }
        }

        public override bool Autoload(ref string name)
        {
            name = "Priestess of the Calamity";
            return mod.Properties.Autoload;
        }

        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Priestess of the Calamity");
            Main.npcFrameCount[npc.type] = 25;
            NPCID.Sets.ExtraFramesCount[npc.type] = 9;
            NPCID.Sets.AttackFrameCount[npc.type] = 4;
            NPCID.Sets.DangerDetectRange[npc.type] = 700;
            NPCID.Sets.AttackType[npc.type] = 0;
            NPCID.Sets.AttackTime[npc.type] = 90;
            NPCID.Sets.AttackAverageChance[npc.type] = 30;
            NPCID.Sets.HatOffsetY[npc.type] = 4;
        }

        public override void SetDefaults()
        {
            npc.townNPC = true;
            npc.friendly = true;
            npc.width = 18;
            npc.height = 40;
            npc.aiStyle = 7;
            npc.damage = 500;
            npc.defense = 55;
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
                    return "Ibalia";
                default:
                    return "Iba";
            }
        }

        public override string GetChat()
        {
            int Dryad = NPC.FindFirstNPC(NPCID.Dryad);
            if (Dryad >= 0 && Main.rand.Next(4) == 0)
            {
                return "This " + Main.npc[Dryad].GivenName + " ... How do we get rid of her? She is awfully trying to cleanse this world of our Corruption!";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "This world seems too 'Happy'... Let's go and Corrupt EVERYTHING! *Laughs*";
                case 1:
                    return "Hmm... Oh! My bad. I was just thinking about how we could corrupt this world as fast as we can.";
                default:
                    return "The Calamity chose you as the next Lord of Madness, I hope you will be my worthy Master.";
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
            shop.item[nextSlot].SetDefaults(ItemID.Muramasa);
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