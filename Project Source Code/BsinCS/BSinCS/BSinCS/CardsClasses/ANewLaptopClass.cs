using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PlayerModel;
using RoomModel;
using ScoreModel;
using CardModel;
using BSinCS;

namespace ANewLaptopClass
{
    public class ANewLaptop : Card
    {
        public override string CardName { get { return "A New Laptop"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Computer Lab" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override Score Prerequisite { get { return new Score { Integrity = 4 }; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Craft = 1, Integrity = 1, Learning = 1 }; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "A New Laptop.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 3;
            if (RewardSelection && successPlayer.Type == "Human")
            {
                if (successPlayer.SelectedChip == "Craft")
                {
                    successPlayer.Score.Craft += 1;
                }
                else if (successPlayer.SelectedChip == "Integrity")
                {
                    successPlayer.Score.Integrity += 1;
                }
                else if (successPlayer.SelectedChip == "Learning")
                {
                    successPlayer.Score.Learning += 1;
                }
            }

            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            if (failedPlayer.Type == "Human")
            {
                BSinCSSettings.Default.ShouldRemoveCard = true;
            }
            return failedPlayer;
        }
    }
}
