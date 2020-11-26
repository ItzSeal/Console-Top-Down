using ConsoleRPG.Entities;
using ConsoleRPG.Maths;
using System;

namespace ConsoleRPG {
    public class GameManager : IDisposable {

        /// <summary>
        /// Is the game running?
        /// </summary>
        public static bool Running = false;

        /// <summary>
        /// <see cref="Screen"/> used throughout the game
        /// </summary>
        Screen screen;

        /// <summary>
        /// <see cref="Player"/> instance
        /// </summary>
        Player playerEntity;

        // Just a test collidable entity
        TestEntity testEntity;

        /// <summary>
        /// The <see cref="Level"/> that is loaded
        /// </summary>
        Level level = new Level(30, 20);

        /// <summary>
        /// Start the game
        /// </summary>
        private void Start() {
            // Hide the console cursor
            Console.CursorVisible = false;

            // Creates a new instance of the screen
            screen = new Screen();

            // Creates the player
            playerEntity = new Player(new Sprite() { 
                graphic = '#', 
                colour = ConsoleColor.White
            }, new Vector2(3, 3), ref screen);

            // Creates the debug entity
            testEntity = new TestEntity();

            // Adds the two entities to the list
            screen.entities.Add(playerEntity);
            screen.entities.Add(testEntity);

            // Starts all rendering
            screen.Start(level);

            // Sets the game to be run
            Running = true;

        }

        /// <summary>
        /// Runs the game
        /// </summary>
        [STAThread]
        public void Run() {
            // Start the game
            Start();

            // Runs the game
            while(Running) {
                // Update the game
                Tick();

                // Draw the game
                Render();
            }
        }

        /// <summary>
        /// Updates the game
        /// </summary>
        private void Tick() {
            // Update the entites
            foreach (Entity ent in screen.entities) {
                ent.Tick();
            }
        }


        /// <summary>
        /// Renders the game
        /// </summary>
        private void Render() {
            // If the screen should render
            if(screen.shoudlRedraw) {

                // Reset the tiles
                level.ResetLevel();

                // Clear the screen
                screen.Clear();

                // Draw to the screen
                screen.Render();

            }
        }

        /// <summary>
        /// Disposes the game
        /// </summary>
        public void Dispose() {
            
        }
    }
}
