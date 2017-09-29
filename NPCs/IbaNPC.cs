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
                return "This " + Main.npc[Dryad].GivenName + " ... How do we get rid of her? She is trying to 'cleanse' me!";
            }
            switch (Main.rand.Next(4))
            {
                case 0:
                    return "I hope Kazajirr isn't that much of a deal for you. He really tends to be hot-headded.";
                case 1:
                    return "This world has to be corrupt for you to be the true Lord of the Calamity";
                case 2:
                    return "Ever heard of the 'Knights of the Calamity'? They are quite a Chaotic bunch. They will try to kill you even if you are their next Lord.";
                case 3:
                    return "You probably ask yourself 'Why am I now the next Lord of the Calamity?' Well, I don't know!";
                case 4:
                    return "... What? Why are you staring at me?!";
                default:
                    return "Ah, Hello my Lord. Why I'm calling you my Lord? Well, I serve you dummy!";
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