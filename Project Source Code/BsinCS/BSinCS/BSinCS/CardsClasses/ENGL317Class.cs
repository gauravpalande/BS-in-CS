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

namespace ENGL317Class
{
    public class ENGL317 : Card
    {
        public override string CardName { get { return "ENGL 317"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "LA 5" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override Score Prerequisite { get { return new Score { Craft = 6 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "ENGL 317.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            BSinCSSettings.Default.Teleport = true;
            BSinCSSettings.Default.TeleportRoom = "Student Parking";
            return failedPlayer;
        }
    }
}
