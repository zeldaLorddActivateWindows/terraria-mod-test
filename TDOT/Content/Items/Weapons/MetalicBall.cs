using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TDOT.Content.Projectiles.SpinProjectiles;
using Microsoft.Xna.Framework;
using System.Linq;
using System.Collections.Generic;

namespace TDOT.Content.Items.Weapons
{
	public class MetalicBall : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Metalic Ball"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("V1");
		}

		public override void SetDefaults()
		{
			Item.damage = 11;
			Item.width = 28;
			Item.noMelee = true;
			Item.height = 28;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 1;
			Item.shoot = ModContent.ProjectileType<MetalicBallThrow>();
			Item.shootSpeed = 40;
			Item.autoReuse = true;
			Item.rare = ItemRarityID.White;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
		}

        public override void ModifyTooltips(List<TooltipLine> tooltips)
        {
			var line = tooltips.FirstOrDefault(x => x.Name=="Damage" && x.Mod == "Terraria");
			if(line != null)
            {
				string[] split = line.Text.Split(' ');
				line.Text = split.First() + " Spin " + split.Last();
            }
        }

        public override void ModifyWeaponDamage(Player player, ref StatModifier damage)
        {
			damage += player.GetModPlayer<TDOTPlayer>().spinDamage;
        }

        public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LeadBar,20);
			recipe.AddTile(TileID.WorkBenches);	 
			recipe.Register();
		}
	}
}