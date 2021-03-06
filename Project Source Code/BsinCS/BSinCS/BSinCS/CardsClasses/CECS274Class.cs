﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PlayerModel;
using RoomModel;
using ScoreModel;
using CardModel;

namespace CECS274Class
{
    public class CECS274 : Card
    {
        public override string CardName { get { return "CECS 274"; } }

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

        public override Score Prerequisite { get { return new Score { Learning = 7 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override bool HasFail { get { return true; } }

        public override string ImageURL { get { return "CECS 274.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.QualityPoints += 5;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            failedPlayer.Score.QualityPoints -= 3;
            return failedPlayer;
        }
    }
}
