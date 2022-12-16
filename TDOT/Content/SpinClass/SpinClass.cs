using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TDOT.Content.Items;

namespace TDOT.Content.SpinClass
{
    class SpinClass: DamageClass
    {

        public override StatInheritanceData GetModifierInheritance(DamageClass damageClass)
        {
            if (damageClass == DamageClass.Generic)
                return StatInheritanceData.Full;

            return StatInheritanceData.None;
        }

        public override bool UseStandardCritCalcs => true;

    }
}
