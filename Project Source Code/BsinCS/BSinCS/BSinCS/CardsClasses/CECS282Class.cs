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

namespace CECS282Class
{
    public class CECS282 : Card
    {
        public override string CardName { get { return "CECS 282"; } }

        public override List<Room> CardRoom
        {
            get
            {
                return new List<Room>
                {
                    new Room { RoomName = "Computer Lab" },
                    new Room { RoomName = "ECS 302" },
                    new Room { RoomName = "EAT Lab" },
                    new Room { RoomName = "CECS Conference Room" },
                    new Room { RoomName = "Room of Retirement" },
                    new Room { RoomName = "ECS 308" },
                    new Room { RoomName = "North Hall" },
                    new Room { RoomName = "South Hall" },
                    new Room { RoomName = "Lactation Lounge" },
                    new Room { RoomName = "Elevators Room" }
                };
            }
        }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Learning = 8, Craft = 8, Integrity = 8 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "CECS 282.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 2;
            if (failedPlayer.Type == "Human")
            {
                BSinCSSettings.Default.ShouldRemoveCard = true;
            }
            return failedPlayer;
        }
    }
}
