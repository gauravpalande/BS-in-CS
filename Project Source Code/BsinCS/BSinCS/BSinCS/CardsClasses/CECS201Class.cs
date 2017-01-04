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

namespace CECS201Class
{
    public class CECS201 : Card
    {
        public override string CardName { get { return "CECS 201"; } }

        public override List<Room> CardRoom
        {
            get
            {
                return new List<Room>
                {
                    new Room { RoomName = "ECS 302" },
                    new Room { RoomName = "ECS 308" },
                    new Room { RoomName = "Computer Lab" },
                    new Room { RoomName = "Eat Lab" }
                };
            }
        }

        public override bool HasPrerequisite { get { return true; } }

        public override Score Prerequisite { get { return new Score { Craft = 8 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "CECS 201.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Learning += 1;
            successPlayer.Score.Craft += 1;
            successPlayer.Score.Integrity += 1;
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
