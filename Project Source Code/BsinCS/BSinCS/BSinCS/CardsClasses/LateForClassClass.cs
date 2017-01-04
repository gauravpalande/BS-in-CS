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

namespace LateForCLassClass
{
    public class LateForCLass : Card
    {
        public override string CardName { get { return "Late For CLass"; } }

        public override List<Room> CardRoom { get { return new List<Room>
                  { new Room { RoomName = "George Allen Field" },
                    new Room { RoomName = "Japanese Garden" },
                    new Room { RoomName = "Walter Pyramid" },
                    new Room { RoomName = "Student Parking" },
                    new Room { RoomName = "Rec Center" },
                    new Room { RoomName = "West Walkway" },
                    new Room { RoomName = "East Walkway" },
                    new Room { RoomName = "Library Room" },
                    new Room { RoomName = "LA 5" },
                    new Room { RoomName = "Bratwurst Hall"  }}; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Late for Class.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Craft += 1;
            BSinCSSettings.Default.Teleport = true;
            BSinCSSettings.Default.TeleportRoom = "Lactation Lounge";

            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
