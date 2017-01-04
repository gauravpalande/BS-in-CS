using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PlayerModel;
using RoomModel;
using ScoreModel;
using CardInterface;

namespace CardModel
{
    public abstract class Card : ICard
    {
        public abstract string CardName { get; }

        public abstract List<Room> CardRoom { get; }

        public abstract Score Prerequisite { get; }

        public abstract bool RewardSelection { get; }

        public abstract Score Reward { get; }

        public abstract bool HasPrerequisite { get; }

        public abstract bool HasFail { get; }

        public abstract string ImageURL { get; }

        public abstract Player Play(Player successPlayer, List<Card> unusedDeck);

        public abstract Player Fail(Player failedPlayer);
    }
}
