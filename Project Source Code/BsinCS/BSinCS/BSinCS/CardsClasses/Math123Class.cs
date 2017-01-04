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

namespace Math123Class
{
    public class Math123 : Card
    {
        public override string CardName { get { return "Math 123"; } }

        public override List<Room> CardRoom { get{ return new List<Room> { new Room { RoomName = "ECS 302" }, new Room { RoomName = "ECS 308" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Learning = 5 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Math 123.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 3;
            if (failedPlayer.Type == "Human")
            {
                BSinCSSettings.Default.ShouldRemoveCard = true;
            }
            return failedPlayer;
        }
    }
}
