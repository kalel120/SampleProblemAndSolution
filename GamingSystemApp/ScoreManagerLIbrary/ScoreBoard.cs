using System;
using System.Collections.Generic;
using System.Linq;

namespace ScoreManagerLibrary {
    public class ScoreBoard {
        public List<Gamer> ListOfTopGamers { get; set; }

        public ScoreBoard() {
            ListOfTopGamers = new List<Gamer>();
        }

        public void DisplayScoreBoard() {
            foreach (var gamer in ListOfTopGamers) {
                Console.WriteLine("name: " + gamer.Name + "\tScore: " + gamer.Score);
            }
        }
    }
}