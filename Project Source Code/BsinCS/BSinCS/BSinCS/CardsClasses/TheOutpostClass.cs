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

namespace TheOutpostClass
{
    public class TheOutpost : Card
    {
        public override string CardName { get { return "The Outpost"; } }

        public override List<Room> CardRoom
        {
            get
            {
                return new List<Room>
                {
                    new Room { RoomName = "George Allen Field" },
                    new Room { RoomName = "Japanese Garden" },
                    new Room { RoomName = "Student Parking" },
                    new Room { RoomName = "Walter Pyramid" },
                    new Room { RoomName = "West Walkway" },
                    new Room { RoomName = "Rec Center" },
                    new Room { RoomName = "East Walkway" },
                    new Room { RoomName = "Library Room" },
                    new Room { RoomName = "LA 5" },
                    new Room { RoomName = "Bratwurst Hall" }
                };
            }
        }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Craft = 1 , Integrity = 1 , Learning = 1}; } }

        public override string ImageURL { get { return "The Outpost.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            if (RewardSelection && successPlayer.Type == "Human")
            {
                if (successPlayer.SelectedChip == "Craft")
                {
                    successPlayer.Score.Craft += 1;
                }
                else if (successPlayer.SelectedChip == "Integrity")
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
