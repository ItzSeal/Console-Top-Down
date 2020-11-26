using ConsoleRPG.Entities;
using ConsoleRPG.Maths;
using System;
using System.Collections.Generic;

namespace ConsoleRPG {
    public class Screen {
        /// <summary>
        /// A reference to the <see cref="Level"/>
        /// </summary>
        public Level level;

        /// <summary>
        /// The <see cref="Entity"/> list used in the level
        /// </summary>
        public List<Entity> entities = new List<Entity>();

        /// <summary>
        /// Should the screen be redrawn?
        /// </summary>
        public bool shoudlRedraw = true;


        /// <summary>
        /// Starts the rendering
        /// </summary>
        /// <param name="level">A reference to the <see cref="Level"/></param>
        public void Start(Level level) {

            // Create a reference to the level
            this.level = level;

            // Redraw the screen
            shoudlRedraw = true;

            // Render the screen
            Render();
        }

        /// <summary>
        /// Sets the tile at the position to the sprite specified
        /// </summary>
        /// <param name="position">The position of the <see cref="Sprite"/></param>
        /// <param name="sprite">The <see cref="Sprite"/> to render</param>
        public void SetSprite(Vector2 position, Sprite sprite) {
            level.tiles[position.x, position.y] = sprite;
        }

        /// <summary>
        /// Clears and redraws the <see cref="Screen"/>
        /// </summary>
        public void Clear() {
            // Clear the console
            Console.Clear();
        }

        /// <summary>
        /// Render to the screen
        /// </summary>
        public void Render() {
            // The string to print to the console
            string screenOutput = "";

            // If the entities are on the screen
            foreach (Entity ent in entities) {

                if (ent.position.x >= level.width || ent.position.y >= level.width || ent.position.x < 0 || ent.position.y < 0) { 
                    continue;
                } else {
                    level.tiles[ent.position.x, ent.position.y] = ent.sprite;
                }
            }

            // Render the level
            for (int y = 0; y < level.height; y++) {
                for (int x = 0; x < level.width; x++) {
                    if (x == 0 && y == 0)
                        screenOutput = level.tiles[x, y].graphic.ToString();
                    else
                        screenOutput += level.tiles[x, y].graphic.ToString();
                }

                // Add a new line at each new Y pos
                screenOutput += "\n";
            }

            // Sets the colour to white
            Console.ForegroundColor = ConsoleColor.White;
            
            // Write to the console
            Console.Write(screenOutput);

            // Don't redraw the screen yet
            shoudlRedraw = false;

            // Add the bottom information
            Console.WriteLine("");
            Console.WriteLine("# = Player | C / █ = Collision Object");
            Console.WriteLine("WASD / Arrow Keys - Move");

            Console.WriteLine($"Player Position: ({entities[0].position.x}, {entities[0].position.y})");
        }
    }
}
