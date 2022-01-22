﻿using Microsoft.Xna.Framework;
using StardewValley.Monsters;

namespace FarmTypeManager.Monsters
{
    /// <summary>A subclass of Stardew's RockGolem class, adjusted for use by this mod.</summary>
    public class RockGolemFTM : RockGolem
    {
        /// <summary>Creates an instance of Stardew's RockGolem class (Stone Golem subtype), but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        public RockGolemFTM()
            : base()
        {

        }

        /// <summary>Creates an instance of Stardew's RockGolem class (Stone Golem subtype), but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        public RockGolemFTM(Vector2 position)
            : base(position)
        {
            //immediately set the golem to its "hiding" state, fixing a bug when spawned near players
            Sprite.currentFrame = 16;
            Sprite.loop = false;
            Sprite.UpdateSourceRect();
        }

        /// <summary>Creates an instance of Stardew's RockGolem class (Wilderness Golem subtype), but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        /// <param name="difficultyMod">A number that affects the stats of this monster. This is normally the value of "Game1.player.CombatLevel".</param>
        public RockGolemFTM(Vector2 position, int difficultyMod)
            : base(position, difficultyMod)
        {
            //immediately set the golem to its "hiding" state, fixing a bug when spawned near players
            Sprite.currentFrame = 16;
            Sprite.loop = false;
            Sprite.UpdateSourceRect();
        }
    }
}
