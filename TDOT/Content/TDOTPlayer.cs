using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
namespace TDOT.Content
{
    public class TDOTPlayer : ModPlayer
    {

        public float spinDamage = 0f;



        public override void ResetEffects()
        {
            spinDamage = 0f;

        }

    }
}
