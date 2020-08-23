using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using Terraria;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.UI;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Shaders;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;
using TheFunMod;
//using static TheFunMod.ModdWorld;

namespace TheFunMod
{
	public class TheFunMod : Mod
	{
        public bool poopBiome;

		public TheFunMod()
		{

		}
        /*
        public override void PostSetupContent()
        {
            Mod bossChecklist = ModLoader.GetMod("BossChecklist");
            if (bossChecklist != null)
            {
                // AddBoss, bossname, order or value in terms of vanilla bosses, inline method for retrieving downed value.
                //bossChecklist.Call(....
                // To include a description:
                //bossChecklist.Call("AddBoss", 15f, 603, this, "Cheddar Supreme", (Func<bool>)(() => ModdWorld.downedCheddarSupreme), ModContent.ItemType<Items.Cheese>(), ModCon);
                bossChecklist.Call("AddBossWithInfo", "Cheddar Supreme", 16f, (Func<bool>)(() => ModdWorld.downedCheddarSupreme), "Use a [i:" + ItemType("Cheese") + "] and wait to die.");
                bossChecklist.Call("AddMinibossWithInfo", "Big Boi", 15f, (Func<bool>)(() => ModdWorld.downedBigBoi), "Use a [i:" + ItemType("FunkyLookingEye") + "] during the night and get ready for things to get funky.");
                bossChecklist.Call("AddBossWithInfo", "Barry B. Benson", 17f, (Func<bool>)(() => ModdWorld.downedBarryBBenson), "Use a [i:" + ItemType("Beehemoth") + "] and prepare for total planetary annihilation.");
            }
        }

        public override void UpdateMusic(ref int music, ref MusicPriority priority)
        {
			if (Main.myPlayer == -1 || Main.gameMenu || !Main.LocalPlayer.active)
            {
				return;
			}

			// Make sure your logic here goes from lowest priority to highest so your intended priority is maintained.
			if (Main.LocalPlayer.GetModPlayer<ModdPlayer>().PoopBiome)
            {
				music = GetSoundSlot(SoundType.Music, "Sounds/Music/PoopBiome");
				priority = MusicPriority.Environment;
			}
		}
        */
    }
}
