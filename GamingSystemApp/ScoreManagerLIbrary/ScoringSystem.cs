using System.Linq;

namespace ScoreManagerLibrary {
    public class ScoringSystem : ScoreBoard {
        public void AddGamerInfo(Gamer gamer) {

            if (IsPossibleToAddInScoreBoard(gamer)) {
                ListOfTopGamers.Add(gamer);
                RefreshTopGamerList();
            }
        }

        private void RefreshTopGamerList() {
            ListOfTopGamers = ListOfTopGamers.OrderByDescending(s => s.Score).Take(5).ToList();
        }

        private bool IsPossibleToAddInScoreBoard(Gamer gamer) {
            if (ListOfTopGamers.Count == 0 | ListOfTopGamers.Count < 5) {
                return true;
            }

            foreach (var existing in ListOfTopGamers) {
                if (existing.Score < gamer.Score) {
                    return true;
                }
            }
            return false;
        }
    }
}