﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley.Monsters;

namespace FarmTypeManager.Monsters
{
    /// <summary>A subclass of Stardew's SquidKid class, adjusted for use by this mod.</summary>
    public class SquidKidFTM : SquidKid
    {
        /// <summary>Creates an instance of Stardew's SquidKid class, but with adjustments made for this mod.</summary>
        public SquidKidFTM()
            : base()
        {

        }

        /// <summary>Creates an instance of Stardew's SquidKid class, but with adjustments made for this mod.</summary>
        /// <param name="position">The x,y coordinates of this monster's location.</param>
        public SquidKidFTM(Vector2 position)
            : base(position)
        {

        }

        //this override forces any instance of GameLocation to call drawAboveAllLayers, fixing a bug where flying monsters are invisible on some maps
        public override void drawAboveAlwaysFrontLayer(SpriteBatch b)
        {
            base.drawAboveAlwaysFrontLayer(b); //call the base version of this, if one exists
            base.drawAboveAllLayers(b); //call the extra draw method used by flying monsters
        }
    }
}
