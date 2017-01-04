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

namespace KIN253Class
{
    public class KIN253 : Card
    {
        public override string CardName { get { return "KIN 253"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "George Allen Field" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Integrity = 4 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "KIN 253.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Craft += 2;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            BSinCSSettings.Default.Teleport = true;
            BSinCSSettings.Default.TeleportRoom = "Room Of Retirement";
            return failedPlayer;
        }
    }
}
