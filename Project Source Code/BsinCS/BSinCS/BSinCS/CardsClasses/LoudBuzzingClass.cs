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

namespace LoudBuzzingClass
{
    public class LoudBuzzing : Card
    {
        public override string CardName { get { return "Loud Buzzing"; } }

        public override List<Room> CardRoom { get {return new List<Room> {new Room { RoomName = "Eat Lab" } };} }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Craft = 3 }; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Craft = 1, Learning = 1, Integrity = 1 }; } }

        public override string ImageURL { get { return "Loud Buzzing.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
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
            failedPlayer.Score.QualityPoints -= 2;
            return failedPlayer;
        }
    }
}
