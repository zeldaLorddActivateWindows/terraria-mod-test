using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TDOT.Content.Items;

namespace TDOT.Content.NPCs
{
    class TDOTGlobalNPC : GlobalNPC
    {

        public override void SetupShop(int type, Chest shop, ref int nextSlot)
        {
            if(type == NPCID.Dryad && NPC.downedMoonlord)
            {
                shop.item[nextSlot].SetDefaults(ModContent.ItemType<OldLetter>());
                nextSlot++;
            }
        }

    }
}
