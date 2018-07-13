using System;
using ScoreManagerLibrary;

namespace GamingSystemApp {
    public class Program {
        public static void Main() {
            var gamer = new Gamer {
                Name = "Player 1",
                Score = 291.32
            };
            var gamer2 = new Gamer {
                Name = "Player 2",
                Score = 4567.14
            };
            var gamer3 = new Gamer {
                Name = "Player 3",
                Score = 25.12
            };
            var gamer4 = new Gamer {
                Name = "Player 4",
                Score = 0.0
            };
            var gamer5 = new Gamer {
                Name = "Player 5",
                Score = 300
            };
            var gamer6 = new Gamer {
                Name = "Palyer 6",
                Score = 400
            };

            var gamer7 = new Gamer { Name = "Small Player", Score = 10000 };

            var scoreManager = new ScoringSystem();

            scoreManager.AddGamerInfo(gamer);
            scoreManager.AddGamerInfo(gamer2);
            scoreManager.AddGamerInfo(gamer3);
            scoreManager.AddGamerInfo(gamer4);
            scoreManager.AddGamerInfo(gamer5);
            scoreManager.AddGamerInfo(gamer6);
            scoreManager.AddGamerInfo(gamer7);

            scoreManager.DisplayScoreBoard();
            Console.ReadKey();
        }
    }
}
