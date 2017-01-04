using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using PlayerModel;
using RoomModel;

namespace BSinCS
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        #region Initialize Players
        Player AI1 = new Player();
        Player AI2 = new Player();
        Player Human = new Player();
        # endregion

        #region Initialize Rooms
        Room GeorgeAllenField = new Room { RoomName = "George Allen Field"};
        Room JapaneseGarden = new Room { RoomName = "Japanese Garden"};
        Room StudentParking = new Room { RoomName = "Student Parking"};
        Room WalterPyramid = new Room { RoomName = "Walter Pyramid"};
        Room WestWalkway = new Room { RoomName = "West Walkway"};
        Room RecCenter = new Room { RoomName = "Rec Center"};
        Room ForbiddenParking = new Room { RoomName = "Forbidden Parking"};
        Room EastWalkway = new Room { RoomName = "East Walkway"};
        Room ComputerLab = new Room { RoomName = "Computer Lab"};
        Room ECS302 = new Room { RoomName = "ECS 302"};
        Room EatLab = new Room { RoomName = "Eat Lab"};
        Room CECSConferenceRoom = new Room { RoomName = "CECS Conference Room"};
        Room NorthHall = new Room { RoomName = "North Hall"};
        Room SouthHall = new Room { RoomName = "South Hall"};
        Room RoomOfRetirement = new Room { RoomName = "Room Of Retirement"};
        Room ElevatorsRoom = new Room { RoomName = "Elevators Room"};
        Room ECS308 = new Room { RoomName = "ECS 308"};
        Room LactationLounge = new Room { RoomName = "Lactation Lounge"};
        Room LibraryRoom = new Room { RoomName = "Library Room"};
        Room LA5 = new Room { RoomName = "LA 5"};
        Room BratwurstHall = new Room { RoomName = "Bratwurst Hall"};
        #endregion

        #region Initialize Players List in Rooms
        List<Player> GeorgeAllenFieldList = new List<Player>();
        List<Player> JapaneseGardenList = new List<Player>();
        List<Player> StudentParkingList = new List<Player>();
        List<Player> WalterPyramidList = new List<Player>();
        List<Player> WestWalkwayList = new List<Player>();
        List<Player> RecCenterList = new List<Player>();
        List<Player> ForbiddenParkingList = new List<Player>();
        List<Player> EastWalkwayList = new List<Player>();
        List<Player> ComputerLabList = new List<Player>();
        List<Player> ECS302List = new List<Player>();
        List<Player> EatLabList = new List<Player>();
        List<Player> CECSCoferenceRoomList = new List<Player>();
        List<Player> NorthHallList = new List<Player>();
        List<Player> SouthHallList = new List<Player>();
        List<Player> RoomOfRetirementList = new List<Player>();
        List<Player> ElevatorsRoomList = new List<Player>();
        List<Player> LactationLoungeList = new List<Player>();
        List<Player> LibraryRoomList = new List<Player>();
        List<Player> LA5List = new List<Player>();
        List<Player> BratwurstHallList = new List<Player>();
        List<Player> ECS308List = new List<Player>();
        #endregion

        List<Room> RoomBoxList = new List<Room>();
        Player CurrentPlayer = new Player();
        int MoveCount = 3;
        private static Random rng = new Random();

        public GameWindow()
        {
            InitializeComponent();
            InitializeRooms();
            if (BSinCSSettings.Default.IsRandom)
            {
                IsRandom();
            }
            else
            {
                IsNotRandom();
            }
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
        }

        private void IsRandom()
        {
            List<string> PlayerNames = new List<string> { BSinCSSettings.Default.Human_Player_Name, "Donald", "Hillary" };
            PlayerNames = PlayerNames.ToList();
            int n = PlayerNames.Count;
            String value = "";
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                value = PlayerNames[k];
                PlayerNames[k] = PlayerNames[n];
                PlayerNames[n] = value;
            }

            Human.PlayerName = PlayerNames[0];
            Human.Type = "Human";
            Human.CurrentRoom = ECS308;
            CurrentPlayer = Human;
            ECS308List.Add(Human);

            AI1.PlayerName = PlayerNames[1];
            AI1.Type = "AI";
            AI1.CurrentRoom = ECS308;
            ECS308List.Add(AI1);

            AI2.PlayerName = PlayerNames[2];
            AI2.Type = "AI";
            AI2.CurrentRoom = ECS308;
            ECS308List.Add(AI2);
        }

        private void IsNotRandom()
        {
            InitializeHumanPlayer();
            InitializeAIPlayers();
        }

        private void UpdateItemSources()
        {
            RoomBox.ItemsSource = RoomBoxList;
            George_Allen_Fieldtext.ItemsSource = GeorgeAllenFieldList;
            Japanese_GardenText.ItemsSource = JapaneseGardenList;
            Student_ParkingText.ItemsSource = StudentParkingList;
            Walter_PyramidText.ItemsSource = WalterPyramidList;
            West_WalkwayText.ItemsSource = WestWalkwayList;
            Rec_CenterText.ItemsSource = RecCenterList;
            Forbidden_ParkingText.ItemsSource = ForbiddenParkingList;
            East_WalkwayText.ItemsSource = EastWalkwayList;
            Computer_LabText.ItemsSource = ComputerLabList;
            North_HallText.ItemsSource = NorthHallList;
            South_HallText.ItemsSource = SouthHallList;
            ECS_302Text.ItemsSource = ECS302List;
            Eat_LabText.ItemsSource = EatLabList;
            CECS_Conference_RoomText.ItemsSource = CECSCoferenceRoomList;
            Room_Of_RetirementText.ItemsSource = RoomOfRetirementList;
            ElevatorsText.ItemsSource = ElevatorsRoomList;
            ECS_308Text.ItemsSource = ECS308List;
            Lactation_LoungeText.ItemsSource = LactationLoungeList;
            LibraryText.ItemsSource = LibraryRoomList;
            LA_5Text.ItemsSource = LA5List;
            Bratwurst_HallText.ItemsSource = BratwurstHallList;
        }

        private void InitializeRooms()
        {
            GeorgeAllenField.AccessibleRooms = new List<Room>() { JapaneseGarden, WalterPyramid, RecCenter, WestWalkway };
            GeorgeAllenField.RoomList = GeorgeAllenFieldList;
            JapaneseGarden.AccessibleRooms = new List<Room>() { GeorgeAllenField, WalterPyramid, StudentParking };
            JapaneseGarden.RoomList = JapaneseGardenList;
            StudentParking.AccessibleRooms = new List<Room>() { JapaneseGarden, WalterPyramid, ForbiddenParking, RecCenter };
            StudentParking.RoomList = StudentParkingList;
            WalterPyramid.AccessibleRooms = new List<Room>() { GeorgeAllenField, RecCenter, StudentParking, JapaneseGarden };
            WalterPyramid.RoomList = WalterPyramidList;
            WestWalkway.AccessibleRooms = new List<Room>() { GeorgeAllenField, RecCenter, NorthHall, LibraryRoom };
            WestWalkway.RoomList = WestWalkwayList;
            RecCenter.AccessibleRooms = new List<Room>() { GeorgeAllenField, WalterPyramid, StudentParking, ForbiddenParking, WestWalkway };
            RecCenter.RoomList = RecCenterList;
            ForbiddenParking.AccessibleRooms = new List<Room>() { RecCenter, EastWalkway, StudentParking };
            ForbiddenParking.RoomList = ForbiddenParkingList;
            EastWalkway.AccessibleRooms = new List<Room>() { ForbiddenParking, SouthHall, BratwurstHall };
            EastWalkway.RoomList = EastWalkwayList;
            ComputerLab.AccessibleRooms = new List<Room>() { NorthHall };
            ComputerLab.RoomList = ComputerLabList;
            NorthHall.AccessibleRooms = new List<Room>() { SouthHall, WestWalkway, ComputerLab, ECS302, RoomOfRetirement, ElevatorsRoom };
            NorthHall.RoomList = NorthHallList;
            SouthHall.AccessibleRooms = new List<Room>() { NorthHall, EastWalkway, ECS302, EatLab, CECSConferenceRoom, ECS308, LactationLounge };
            SouthHall.RoomList = SouthHallList;
            ECS302.AccessibleRooms = new List<Room>() { NorthHall, SouthHall};
            ECS302.RoomList = ECS302List;
            EatLab.AccessibleRooms = new List<Room>() { SouthHall };
            EatLab.RoomList = EatLabList;
            CECSConferenceRoom.AccessibleRooms = new List<Room>() { SouthHall };
            CECSConferenceRoom.RoomList = CECSCoferenceRoomList;
            RoomOfRetirement.AccessibleRooms = new List<Room>() { NorthHall };
            RoomOfRetirement.RoomList = RoomOfRetirementList;
            ElevatorsRoom.AccessibleRooms = new List<Room>() { NorthHall, LA5 };
            ElevatorsRoom.RoomList = ElevatorsRoomList;
            ECS308.AccessibleRooms = new List<Room>() { SouthHall };
            ECS308.RoomList = ECS308List;
            LactationLounge.AccessibleRooms = new List<Room>() { SouthHall };
            LactationLounge.RoomList = LactationLoungeList;
            LibraryRoom.AccessibleRooms = new List<Room>() { WestWalkway, LA5 };
            LibraryRoom.RoomList = LibraryRoomList;
            LA5.AccessibleRooms = new List<Room>() { LibraryRoom, ElevatorsRoom, BratwurstHall };
            LA5.RoomList = LA5List;
            BratwurstHall.AccessibleRooms = new List<Room>() { LA5, EastWalkway };
            BratwurstHall.RoomList = BratwurstHallList;
        }

        public void InitializeAIPlayers()
        {
            AI1.PlayerName = BSinCSSettings.Default.AI1_Name;
            AI1.Type = "AI";
            AI1.CurrentRoom = ECS308;
            ECS308List.Add(AI1);

            AI2.PlayerName = BSinCSSettings.Default.AI2_Name;
            AI2.Type = "AI";
            AI2.CurrentRoom = ECS308;
            ECS308List.Add(AI2);
        }

        public void InitializeHumanPlayer()
        {
            Human.PlayerName = BSinCSSettings.Default.Human_Player_Name;
            Human.Type = "Human";
            Human.CurrentRoom = ECS308;
            CurrentPlayer = Human;
            ECS308List.Add(Human);
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            MoveCount--;
            CurrentPlayer.CurrentRoom.RoomList.Remove(CurrentPlayer);
            RefreshRoomListBoxes();
            CurrentPlayer.CurrentRoom = CurrentPlayer.NextRoom;
            CurrentPlayer.CurrentRoom.RoomList.Add(CurrentPlayer);
            RefreshRoomListBoxes();
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
            MoveButton.IsEnabled = false;
        }

        private void RefreshRoomListBoxes()
        {
            switch (CurrentPlayer.CurrentRoom.RoomName)
            {
                case "George Allen Field":
                    George_Allen_Fieldtext.Items.Refresh();
                    break;
                case "Japanese Garden":
                    Japanese_GardenText.Items.Refresh();
                    break;
                case "Student Parking":
                    Student_ParkingText.Items.Refresh();
                    break;
                case "Walter Pyramid":
                    Walter_PyramidText.Items.Refresh();
                    break;
                case "West Walkway":
                    West_WalkwayText.Items.Refresh();
                    break;
                case "Rec Center":
                    Rec_CenterText.Items.Refresh();
                    break;
                case "Forbidden Parking":
                    Forbidden_ParkingText.Items.Refresh();
                    break;
                case "East Walkway":
                    East_WalkwayText.Items.Refresh();
                    break;
                case "Computer Lab":
                    Computer_LabText.Items.Refresh();
                    break;
                case "ECS 302":
                    ECS_302Text.Items.Refresh();
                    break;
                case "Eat Lab":
                    Eat_LabText.Items.Refresh();
                    break;
                case "CECS Conference Room":
                    CECS_Conference_RoomText.Items.Refresh();
                    break;
                case "Room Of Retirement":
                    Room_Of_RetirementText.Items.Refresh();
                    break;
                case "Elevators Room":
                    ElevatorsText.Items.Refresh();
                    break;
                case "ECS 308":
                    ECS_308Text.Items.Refresh();
                    break;
                case "Lactation Lounge":
                    Lactation_LoungeText.Items.Refresh();
                    break;
                case "Library Room":
                    LibraryText.Items.Refresh();
                    break;
                case "LA 5":
                    LA_5Text.Items.Refresh();
                    break;
                case "Bratwurst Hall":
                    Bratwurst_HallText.Items.Refresh();
                    break;
                case "North Hall":
                    North_HallText.Items.Refresh();
                    break;
                case "South Hall":
                    South_HallText.Items.Refresh();
                    break;
            }
        }

        public void RoomBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MoveCount < 1)
            {
                MoveButton.IsEnabled = false;
                UpdateItemSources();
            }
            else
                MoveButton.IsEnabled = true;
            Room NewRoom = ((sender as ListBox).SelectedItem as Room);
            CurrentPlayer.NextRoom = NewRoom;
        }

        private void PlayCardButton_Click(object sender, RoutedEventArgs e)
        {
            MoveCount = 3;
            UpdateItemSources();
            MoveAI(AI1);
            MoveAI(AI2);
        }

        private void MoveAI(Player artificialPlayer)
        {
            CurrentPlayer = artificialPlayer;
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            List<Room> RandomRooms = CurrentPlayer.CurrentRoom.AccessibleRooms.ToList();
            int n = RandomRooms.Count;
            Room value = null;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                value = RandomRooms[k];
                RandomRooms[k] = RandomRooms[n];
                RandomRooms[n] = value;
            }
            CurrentPlayer.NextRoom = CurrentPlayer==AI1? RandomRooms.Last() : RandomRooms.First();
            CurrentPlayer.CurrentRoom.RoomList.Remove(CurrentPlayer);
            RefreshRoomListBoxes();
            CurrentPlayer.CurrentRoom = CurrentPlayer.NextRoom;
            CurrentPlayer.CurrentRoom.RoomList.Add(CurrentPlayer);
            RefreshRoomListBoxes();
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
            CurrentPlayer = CurrentPlayer == AI2 ? Human: AI2;
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
        }
    }
}