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

namespace PHIL270Class
{
    public class PHIL270 : Card
    {
        public override string CardName { get { return "PHIL 270"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "LA 5" }, new Room { RoomName = "Library Room" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override Score Prerequisite { get { return new Score { Integrity = 7 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "PHIL 270.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 3;
            successPlayer.Score.Learning += 1;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 3;
            return failedPlayer;
        }
    }
}
