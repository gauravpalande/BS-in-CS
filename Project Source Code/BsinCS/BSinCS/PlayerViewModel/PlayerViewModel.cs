using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerModel;

namespace PlayerViewModel
{
    public class PlayViewModel
    {
        private Player obj = new Player();
        public string George_Allen_Fieldtext
        {
            get { return obj.PlayerName; }
            set { obj.PlayerName = value; }
        }

        public string Japanese_GardenText
        {
            get { return obj.Type; }
            set { obj.Type = value; }
        }
    }
}