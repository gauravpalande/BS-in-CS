using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PlayerModel;
using CardModel;

namespace RoomModel
{
    public class Room : INotifyPropertyChanged
    {
        private string _roomName;

        public string RoomName
        {
            get { return _roomName; }
            set
            {
                _roomName = value;
                RaisePropertyChanged("RoomName");
            }
        }

        private List<Player> _roomList;

        public List<Player> RoomList
        {
            get { return _roomList; }
            set
            {
                _roomList = value;
                RaisePropertyChanged("RoomListName");
            }
        }

        private List<Room> _accessibleRooms;

        public List<Room> AccessibleRooms
        {
            get { return _accessibleRooms; }
            set
            {
                _accessibleRooms = value;
                RaisePropertyChanged("AccessibleRooms");
            }
        }

        private Card _roomCard;

        public Card RoomCard
        {
            get { return _roomCard; }
            set
            {
                _roomCard = value;
                RaisePropertyChanged("RoomCard");
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
