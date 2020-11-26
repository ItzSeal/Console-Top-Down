using ConsoleRPG.Maths;

namespace ConsoleRPG.Entities {
    /// <summary>
    /// Base Entity class
    /// </summary>
    public abstract class Entity {

        /// <summary>
        /// The position of the <seealso cref="Entity"/>
        /// </summary>
        public Vector2 position;

        /// <summary>
        /// The <see cref="Sprite"/> of the <see cref="Entity"/>
        /// </summary>
        public Sprite sprite;

        /// <summary>
        /// Creates a new instance of the <see cref="Entity"/> class
        /// </summary>
        public Entity() {
            sprite = new Sprite();
        }

        /// <summary>
        /// Updates the <see cref="Entity"/>
        /// </summary>
        public virtual void Tick() {
            return;
        }

        /// <summary>
        /// Draws the <see cref="Entity"/> to the screen
        /// </summary>
        /// <param name="screen">The instance of the <see cref="Screen"/></param>
        public void Render(Screen screen) {

            // Set the sprite to the screen
            screen.SetSprite(position, sprite);
        }
    }
}
