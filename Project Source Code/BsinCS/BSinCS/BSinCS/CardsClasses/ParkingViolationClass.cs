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
using System.Windows;
using BSinCS;

namespace ParkingViolationClass
{
    public class ParkingViolation : Card
    {
        public override string CardName { get { return "Parking Violation"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "Forbidden Parking" } }; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Parking Violation.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Learning += 1;
            if (successPlayer.Type == "Human")
            {
                string sMessageBoxText = "Do you want to discard a card and earn 1 Learning chip?";
                string sCaption = "Extra Chip";

                MessageBoxButton btnMessageBox = MessageBoxButton.YesNo;
                MessageBoxImage icnMessageBox = MessageBoxImage.Question;

                MessageBoxResult rsltMessageBox = MessageBox.Show(sMessageBoxText, sCaption, btnMessageBox, icnMessageBox);

                switch (rsltMessageBox)
                {
                    case MessageBoxResult.Yes:
                        if (successPlayer.Type == "Human")
                        {
                            BSinCSSettings.Default.ShouldRemoveCard = true;
                        }
                        successPlayer.Score.Learning += 1;
                        break;

                    case MessageBoxResult.No:
                        break;
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
