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

namespace PressTheRightFloorClass
{
    public class PressTheRightFloor : Card
    {
        public override string CardName { get { return "Press the Right Floor"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Elevators Room"} }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Learning= 4 } ; } } 

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Press th Right Floor.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Craft += 2;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 2;
            return failedPlayer;
        }
    }
}
