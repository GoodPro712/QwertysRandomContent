using QwertysRandomContent.Config;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace QwertysRandomContent.Items.Fortress
{
    public class FortressWall : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("");
            if (ModContent.GetInstance<SpriteSettings>().ClassicFortress)
            {
                Main.itemTexture[item.type] = mod.GetTexture("Items/Fortress/FortressWall_Classic");
            }
        }

        public override void SetDefaults()
        {
            item.rare = 3;
            item.width = 12;
            item.height = 12;
            item.maxStack = 999;
            item.useTurn = true;
            item.autoReuse = true;
            item.useAnimation = 15;
            item.useTime = 7;
            item.useStyle = 1;
            item.consumable = true;
            item.createWall = mod.WallType("FortressWall");
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.ItemType("FortressBrick"));
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 4);
            recipe.AddRecipe();
        }
    }
}