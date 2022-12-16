using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TDOT.Content.Items
{
	public class OldLetter : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Old Letter"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("After the \"defeat\" of the Moonlord a horrible curse has plagued space\nwith it's increasing amount of planets have been infected\nthey have became inhabitable for years\nafter years later\nwhen the terrarian invokes the Moonlord one last time\nthe plague shall be released\nfor one final time\nto take over\nit's last victim\n\"Terraria\"\n");
		}

		public override void SetDefaults()
		{
		
			Item.width = 32;
			Item.height = 32;
			Item.value = 0;
			Item.rare = ItemRarityID.Lime;
		}

		
	}
}