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

namespace Physics151Class
{
    public class Physics151 : Card
    {
        public override string CardName { get { return "Physics 151"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "ECS 308" } }; } }

        public override bool HasPrerequisite { get { return true; } }

        public override bool HasFail { get { return true; } }

        public override Score Prerequisite { get { return new Score { Craft = 3 }; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Physics 151.png"; } }

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
