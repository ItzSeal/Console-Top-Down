using System;

namespace ConsoleRPG {
    public class Sprite {
        /// <summary>
        /// The <see cref="char"/> used to act as a sprite
        /// </summary>
        public char graphic;

        // NOTE: This has been made obsolete by accident
        // TODO: Fix the colouring of Sprites
        [Obsolete]
        public ConsoleColor colour;

    }
}
