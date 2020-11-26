using ConsoleRPG.Maths;
using System;

namespace ConsoleRPG.Entities {
    public class Player : Mob {

        /// <summary>
        /// Reference to the <see cref="Screen"/> used during game play
        /// </summary>
        Screen screen;

        /// <summary>
        /// Creates an instance of the <see cref="Player"/> class
        /// </summary>
        /// <param name="sprite">The <see cref="Sprite"/> of the <see cref="Player"/></param>
        /// <param name="position">The position of the <see cref="Player"/></param>
        /// <param name="screen">The <see cref="Screen"/> used during game play</param>
        public Player(Sprite sprite, Vector2 position, ref Screen screen) {
            this.sprite = sprite;
            this.position = position;
            this.screen = screen;
        }

        /// <summary>
        /// Checks to see if this <see cref="Player"/> is colliding with another <see cref="Entity"/>
        /// </summary>
        /// <param name="velocity">The velocity of the player</param>
        /// <returns>If the <see cref="Player"/> is colliding</returns>
        public bool IsColliding(Vector2 velocity) {
            foreach(Entity ent in screen.entities) {

                // If this is this entity
                if (ent == this)
                    continue;

                if(ent.position.y == position.y + velocity.y && ent.position.x == position.x + velocity.x) {
                    return true;
                }
            }

            // Check up 
            if (position.y + velocity.y >= screen.level.height - 1 ||
                position.x + velocity.x >= screen.level.width - 1 ||
                position.x + velocity.x <= 0 ||
                position.y + velocity.y <= 0) {
                return true;
            }

            return false;
        }

        public override void Tick() {
            ConsoleKeyInfo currentKey = Console.ReadKey(true);

            Vector2 velocity = Vector2.Zero;

            // Get player input
            switch (currentKey.Key) 
            {
                case ConsoleKey.W:
                    velocity.y -= 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.A:
                    velocity.x -= 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.S:
                    velocity.y += 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.D:
                    velocity.x += 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.UpArrow:
                    velocity.y -= 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.LeftArrow:
                    velocity.x -= 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.DownArrow:
                    velocity.y += 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.RightArrow:
                    velocity.x += 1;
                    screen.shoudlRedraw = true;
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;

            }

            // If the player isn't colliding with anything
            if(!IsColliding(velocity)) {
                Move(velocity);
            }

        }
    }
}
