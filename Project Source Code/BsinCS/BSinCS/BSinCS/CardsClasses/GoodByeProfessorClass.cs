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

namespace GoodbyeProfessorClass
{
    public class GoodbyeProfessor : Card
    {
        public override string CardName { get { return "GoodBye Professor"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Room Of Retirement" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return new Score { Learning = 6, Craft = 6, Integrity = 6 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Good bye Professor.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 10;

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
