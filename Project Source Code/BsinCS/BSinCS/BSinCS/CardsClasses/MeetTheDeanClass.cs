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

namespace MeetTheDeanClass
{
    public class MeetTheDean : Card
    {
        public override string CardName { get { return "Meet the Dean"; } }

        public override List<Room> CardRoom { get {return new List<Room> {new Room { RoomName = "North Hall" }, new Room { RoomName = "South Hall" } };} }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Learning = 3, Integrity = 3, Craft=3 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Meet the Dean.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            if (successPlayer.Type == "Human")
                successPlayer.Hand.Add(unusedDeck.First());
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
