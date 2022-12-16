using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TDOT.Content.Projectiles.SpinProjectiles;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Collections.Generic;
using Terraria.DataStructures;

namespace TDOT.Content.Items
{
	public class NaturalCauses : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Natural Causes"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("(drop for full image)\n(use the item like a sword for a funni)");
		}

		public override void SetDefaults()
		{
			Item.damage = 0;
			Item.width = 28;
			Item.noMelee = true;
			Item.height = 28;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.DamageType = DamageClass.Default;
			Item.autoReuse = false;
			Item.rare = ItemRarityID.Lime;
			
		}

        public override bool? UseItem(Player player)
        {
			player.KillMe(PlayerDeathReason.ByCustomReason(player.name + " died by natural causes"), 0, 1);
			
			return false;
        }


        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.DirtBlock, 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.Register();
		}
	}
}