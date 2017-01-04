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

namespace Math122Class
{
    public class Math122 : Card
    {
        public override string CardName { get { return "Math 122"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Library Room" }, }; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Integrity = 1, Learning = 1 }; } }

        public override string ImageURL { get { return "Math 122.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            if (RewardSelection && successPlayer.Type == "Human")
            {
                if (successPlayer.SelectedChip == "Learning")
                {
                    successPlayer.Score.Learning += 1;
                }
                else if (successPlayer.SelectedChip == "Integrity")
                {
                    successPlayer.Score.Integrity += 1;
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
