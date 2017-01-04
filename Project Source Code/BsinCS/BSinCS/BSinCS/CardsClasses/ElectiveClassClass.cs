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

namespace ElectiveClassClass
{
    public class ElectiveClass : Card
    {
        public override string CardName { get { return "Elective Class"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Library" } }; } }

        public override Score Prerequisite { get { return new Score { Learning = 2 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "Elective Class.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Learning += 1;
            if (successPlayer.Type=="Human")
            successPlayer.Hand.Add(unusedDeck.First());

            return successPlayer;
        }
        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints += 2;
            return failedPlayer;
        }
    }
}
