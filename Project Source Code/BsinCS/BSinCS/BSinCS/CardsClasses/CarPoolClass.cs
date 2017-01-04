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

namespace CarPoolClass
{
    public class CarPool : Card
    {
        public override string CardName { get { return "Car Pool"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Student Parking" }, new Room { RoomName = "Forbidden Parking" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override Score Prerequisite { get { return new Score { Integrity = 5 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "Car Pool.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 3;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 2;
            return failedPlayer;
        }
    }
}
