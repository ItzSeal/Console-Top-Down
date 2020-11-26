using ConsoleRPG.Maths;
using System;

namespace ConsoleRPG.Entities {
    public class TestEntity : Entity {

        public TestEntity() {
            position = new Vector2(5, 5);
            sprite = new Sprite() { graphic = 'C', colour = ConsoleColor.Red };
        }
    }
}
