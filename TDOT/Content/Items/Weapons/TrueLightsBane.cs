using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TDOT.Content.Items.Weapons
{
	public class TrueLightsBane : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("True Light's Bane"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("\"Bury the light!\"");
		}

		public override void SetDefaults()
		{
			Item.damage = 85;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = 1;
			Item.knockBack = 6;
			Item.value = 10;
			Item.shoot = ProjectileID.ShadowBeamFriendly;
			Item.shootSpeed = 25;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item9;
			Item.autoReuse = true;
		}

		public override void AddRecipes()
		{
			Recipe recipe = CreateRecipe();
			recipe.AddIngredient(ItemID.LightsBane,1);
			recipe.AddIngredient(ItemID.ChlorophyteBar, 5);
			recipe.AddIngredient(ItemID.BrokenHeroSword, 1);
			recipe.AddTile(TileID.MythrilAnvil);	 
			recipe.Register();
		}
	}
}