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

namespace StudentParkingClass
{
    public class StudentParking : Card
    {
        public override string CardName { get { return "Student Parking"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Student Parking" } }; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Student Parking.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
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
