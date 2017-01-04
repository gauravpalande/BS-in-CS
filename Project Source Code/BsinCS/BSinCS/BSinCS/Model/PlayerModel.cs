using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using RoomModel;

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
