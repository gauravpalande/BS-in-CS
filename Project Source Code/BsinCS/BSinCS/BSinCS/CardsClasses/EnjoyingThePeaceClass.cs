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

namespace EnjoyingthePeaceClass
{
    public class EnjoyingthePeace : Card
    {
        public override string CardName { get { return "Enjoying the Peace"; } }

        public override List<Room> CardRoom { get
            {
                return new List<Room>
                {
                    new Room { RoomName = "Japanese Garden" },
                };
            }
        }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Learning = 1, Integrity = 1 }; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override string ImageURL { get { return "Enjoying the Peace.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            if (RewardSelection && successPlayer.Type == "Human")
            {
                if (successPlayer.SelectedChip == "Integrity")
                {
                    successPlayer.Score.Integrity += 1;
                }
                else if (successPlayer.SelectedChip == "Learning")
                {
                    successPlayer.Score.Learning += 1;
                }
            }

            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
