namespace ConsoleRPG.Maths {
    public class Vector2 {

        // The x and y of the Vector
        public int x, y;

        /// <summary>
        /// Creates a new <see cref="Vector2"/>
        /// </summary>
        public Vector2() {
            x = 0;
            y = 0;
        }

        /// <summary>
        /// Creates a new <see cref="Vector2"/>
        /// </summary>
        /// <param name="x">The value of x</param>
        /// <param name="y">The value of y</param>
        public Vector2(int x, int y) {
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// Returns a <see cref="Vector2"/> with the value of zero
        /// </summary>
        public static Vector2 Zero { get { return new Vector2(); } }

        /// <summary>
        /// Returns a <see cref="Vector2"/> with the value of one
        /// </summary>
        public static Vector2 One { get { return new Vector2(1, 1); } }
    }
}
