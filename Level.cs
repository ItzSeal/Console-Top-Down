using System;
using ConsoleRPG.Entities;

namespace ConsoleRPG {
    public class Level {

        /// <summary>
        /// The width of the <see cref="Level"/>
        /// </summary>
        public int width;

        /// <summary>
        /// The height of the <see cref="Level"/>
        /// </summary>
        public int height;

        /// <summary>
        /// The tiles (<see cref="Sprite"/>s) of the <see cref="Level"/>
        /// </summary>
        public Sprite[,] tiles;

        /// <summary>
        /// Creates a new instance of the <see cref="Level"/>
        /// </summary>
        /// <param name="width">The width of the <see cref="Level"/></param>
        /// <param name="height">The height of the <see cref="Level"/></param>
        public Level(int width, int height) {

            // Sets the width of the level
            this.width = width;

            // Sets the height of the level
            this.height = height;

            // Creates an array of Sprites
            tiles = new Sprite[width, height];

            // Resets the look of the level
            ResetLevel();
        }

        /// <summary>
        /// Resets the level to how it is before the <see cref="Entity"/> list is rendererd
        /// </summary>
        public void ResetLevel() {

            // Loop through the width and height of the level
            for(int y = 0; y < height; y++) {
                for (int x = 0; x < width; x++) {

                    // Creates a new sprite
                    tiles[x, y] = new Sprite();

                    // Sets the character to a NULL character
                    tiles[x, y].graphic = '\0';

                    // Sets the colour of the tile
                    tiles[x, y].colour = ConsoleColor.Red;
                }
            }

            for(int y = 0; y < height; y++) {
                tiles[0, y].graphic = '█';
                tiles[width - 1, y].graphic = '█';
            }

            for (int x = 0; x < width; x++) {
                tiles[x, 0].graphic = '█';
                tiles[x, height - 1].graphic = '█';
            }
        }
    }
}
