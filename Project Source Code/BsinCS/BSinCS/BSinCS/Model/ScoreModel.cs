using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using PlayerModel;
using RoomModel;

namespace ScoreModel
{
    public class Score : INotifyPropertyChanged
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

        private int _learning;

        public int Learning
        {
            get { return _learning; }
            set
            {
                _learning = value;
                RaisePropertyChanged("Learning");
            }
        }

        private int _craft;

        public int Craft
        {
            get { return _craft; }
            set
            {
                _craft = value;
                RaisePropertyChanged("Craft");
            }
        }

        private int _integrity;

        public int Integrity
        {
            get { return _integrity; }
            set
            {
                _integrity = value;
                RaisePropertyChanged("Integrity");
            }
        }

        private int _qualityPoints;

        public int QualityPoints
        {
            get { return _qualityPoints; }
            set
            {
                _qualityPoints = value;
                RaisePropertyChanged("QualityPoints");
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
