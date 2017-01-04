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

namespace ChoosingAMajorClass
{
    public class ChoosingAMajor : Card
    {
        public override string CardName { get { return "Choosing A Major"; } }

        public override List<Room> CardRoom { get
            {
                return new List<Room>
                {
                    new Room { RoomName = "CECS Conference Room" }
                };
            } }

        public override Score Prerequisite { get { return new Score { Integrity = 3 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "Choosing a Major.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 3;
            return failedPlayer;
        }
    }
}
