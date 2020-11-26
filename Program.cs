using System;

namespace ConsoleRPG {
    public class Program {
        static void Main(string[] args) {

            // Sets the console title
            Console.Title = "Test Top Down Movement in Console!";
            
            // Creates and runs the game
            using (var game = new GameManager()) {
                game.Run();
            }
        }
    }
}
