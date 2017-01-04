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

namespace ProfessorMurgolosClass
{
    public class ProfessorMurgolos : Card
    {
        public override string CardName { get { return "Professor Murgolo's CECS 174 Class"; } }

        public override List<Room> CardRoom { get { return new List<Room> { new Room { RoomName = "ECS 302" } }; } }

        public override bool HasPrerequisite { get { return false; } }

        public override bool HasFail { get { return false; } }

        public override Score Prerequisite { get { return null; } }

        public override bool RewardSelection { get { return false; } }

        public override Score Reward { get { return null; } }

        public override string ImageURL { get { return "Professor Murgolo's.png"; } }

        public override Player Play(Player successPlayer, List<Card> unusedDeck)
        {
            successPlayer.Score.Learning += 1;
            return successPlayer;
        }

        public override Player Fail(Player failedPlayer)
        {
            throw new NotImplementedException();
        }
    }
}
