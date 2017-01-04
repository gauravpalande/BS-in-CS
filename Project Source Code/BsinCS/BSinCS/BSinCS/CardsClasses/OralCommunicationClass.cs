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

namespace OralCommunicationClass
{
    public class OralCommunication : Card
    {
        public override string CardName { get { return "Oral Communication"; } }

        public override List<Room> CardRoom
        {
            get
            {
                return new List<Room>
                {
                    new Room { RoomName = "Walter Pyramid" },
                    new Room { RoomName = "Student Parking" },
                    new Room { RoomName = "Rec Center" },
                    new Room { RoomName = "Library Room" },
                    new Room { RoomName = "LA 5" },
                    new Room { RoomName = "Bratwurst Hall" }
                };
            }
        }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Integrity = 4 }; } }

        public override bool RewardSelection { get { return true; } }

        public override Score Reward { get { return new Score { Craft = 1, Integrity = 1, Learning = 1 }; } }

        public override string ImageURL { get { return "Oral Communication.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 4;
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
            if (failedPlayer.Type == "Human")
            {
                BSinCSSettings.Default.ShouldRemoveCard = true;
            }
            return failedPlayer;
        }
    }

}

