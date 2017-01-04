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

namespace ProfessorHoffmanClass
{
    public class ProfessorHoffman : Card
    {
        public override string CardName { get { return "Professor Hoffman"; } }

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
                    new Room { RoomName = "Elevators Room" }
                };
            }
        }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Learning = 3 } ; } } 

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Professor Hoffman.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            if (successPlayer.Type == "Human")
            {
                successPlayer.Hand.Add(unusedDeck.First());
                successPlayer.Hand.Add(unusedDeck.First());
            }
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 5;
            BSinCSSettings.Default.Teleport = true;
            BSinCSSettings.Default.TeleportRoom = "Lactation Lounge";
            return failedPlayer;
        }
    }
}
