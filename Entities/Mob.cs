using ConsoleRPG.Maths;

namespace ConsoleRPG.Entities {
    public abstract class Mob : Entity {

        /// <summary>
        /// Moves the <see cref="Mob"/>
        /// </summary>
        /// <param name="velocity">The velocity in which to move the player</param>
        public void Move(Vector2 velocity) {
            position.x += velocity.x;
            position.y += velocity.y;
        }
    }
}
