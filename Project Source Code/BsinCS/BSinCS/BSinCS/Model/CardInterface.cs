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

namespace CardInterface
{
    public interface ICard
    {
        string CardName { get; }

        List<Room> CardRoom { get; }

        Score Prerequisite { get; }

        bool RewardSelection { get; }

        Score Reward { get; } 

        bool HasPrerequisite { get; }

        bool HasFail { get; }

        string ImageURL { get; }

        Player Play(Player successPlayer, List<Card> unusedDeck);

        Player Fail(Player failPlayer);
    }
}
