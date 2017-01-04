using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using RoomModel;
using CardModel;
using ScoreModel;

namespace PlayerModel
{
    public class Player : INotifyPropertyChanged
    {
        private string _playerName;

        public string PlayerName
        {
            get { return _playerName; }
            set
            {
                _playerName = value;
                RaisePropertyChanged("PlayerName");
            }
        }

        private string _type;

        public string Type
        {
            get { return _type; }
            set
            {
                _type = value;
                RaisePropertyChanged("Type");
            }
        }

        private Room _currentRoom;

        public Room CurrentRoom
        {
            get { return _currentRoom; }
            set
            {
                _currentRoom = value;
                RaisePropertyChanged("CurrentRoom");
            }
        }

        private Room _nextRoom;

        public Room NextRoom
        {
            get { return _nextRoom; }
            set
            {
                _nextRoom = value;
                RaisePropertyChanged("NextRoom");
            }
        }

        private List<Card> _hand;

        public List<Card> Hand
        {
            get { return _hand; }
            set
            {
                _hand = value;
                RaisePropertyChanged("Hand");
            }
        }

        private Card _selectedCard;

        public Card SelectedCard
        {
            get { return _selectedCard; }
            set
            {
                _selectedCard = value;
                RaisePropertyChanged("SelectedCard");
            }
        }

        private Score _score;

        public Score Score
        {
            get { return _score; }
            set
            {
                _score = value;
                RaisePropertyChanged("Score");
            }
        }

        private String _selectedChip;

        public String SelectedChip
        {
            get { return _selectedChip; }
            set
            {
                _selectedChip = value;
                RaisePropertyChanged("SelectedChip");
            }
        }

        private bool _hasSuccessDiscarded;
        public bool HasSuccessDiscarded
        {
            get { return _hasSuccessDiscarded; }
            set
            {
                _hasSuccessDiscarded = value;
                RaisePropertyChanged("HasSuccessDiscarded");
            }
        }

        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
