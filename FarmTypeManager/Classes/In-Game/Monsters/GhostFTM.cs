﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Monsters;

namespace FarmTypeManager.Monsters
{
    /// <summary>A subclass of Stardew's Ghost class, adjusted for use by this mod.</summary>
    public class GhostFTM : Ghost
    {
        /// <summary>Creates an instance of Stardew's Ghost class, but with adjustments made for this mod.</summary>
        public GhostFTM()
            : base()
        {

        }

        /// <summary>Creates an instance of Stardew's Ghost class, but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        public GhostFTM(Vector2 position)
            : base(position)
        {
            HideShadow = true;
        }

        /// <summary>Creates an instance of Stardew's Ghost class, but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        /// <param name="name">The name of the monster to be created. Use "Carbon Ghost" to create that subtype.</param>
        public GhostFTM(Vector2 position, string name)
            : base(position, name)
        {
            HideShadow = true;
        }

        //this override forces any instance of GameLocation to call drawAboveAllLayers, fixing a bug where flying monsters are invisible on some maps
        public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
        {
            base.drawAboveAlwaysFrontLayer(b); //call the base version of this, if one exists
            base.drawAboveAllLayers(b); //call the extra draw method used by flying monsters
        }
    }
}
