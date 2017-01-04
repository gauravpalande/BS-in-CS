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
using ScoreModel;
using System.IO;
#region Classes
using ANewLaptopClass;
using BuddyUpClass;
using CECS100Class;
using CECS105Class;
using CHEM111Class;
using ChoosingAMajorClass;
using ElectiveClassClass;
using EnjoyingNatureClass;
using EnjoyingthePeaceClass;
using ExerciseMindAndBodyClass;
using FallInThePondClass;
using FindingTheLabClass;
using GoodbyeProfessorClass;
using KIN253Class;
using LateForCLassClass;
using LearningLinuxClass;
using LearningNetbeansClass;
using LoudBuzzingClass;
using LunchAtBratwurstHallClass;
using MakeAFriendClass;
using MakeTheDeansListClass;
using Math122Class;
using Math123Class;
using MeetTheDeanClass;
using OralCommunicationClass;
using ParkingViolationClass;
using PassSoccerClassClass;
using Physics151Class;
using PressTheRightFloorClass;
using ProfessorEnglertClass;
using ProfessorHoffmanClass;
using ProfessorMurgolosClass;
using ProgramCrashesClass;
using ResearchCompilersClass;
using ScoreaGoalClass;
using SoccerGoalieClass;
using StudentParkingClass;
using TheBigGameClass;
using TheOutpostClass;
using LBSUvsUCIClass;
using CarPoolClass;
using CECS274Class;
using CECS201Class;
using ENGL317Class;
using PHYS152Class;
using PHIL270Class;
using CECS228Class;
using CECS277Class;
using CECS285Class;
using CECS282Class;
using HaveASwimClass;
# endregion
using CardModel;

namespace BSinCS
{
    /// <summary>
    /// Interaction logic for GameWindow.xaml
    /// </summary>
    public partial class GameWindow : Window
    {
        #region Initialize Cards
        ANewLaptop ANewLaptopCard = new ANewLaptop();
        BuddyUp BuddyUpCard = new BuddyUp();
        CECS100 CECS100Card = new CECS100();
        CECS105 CECS105Card = new CECS105();
        CHEM111 CHEM111Card = new CHEM111();
        ChoosingAMajor ChoosingAMajorCard = new ChoosingAMajor();
        ElectiveClass ElectiveClassCard = new ElectiveClass();
        EnjoyingNature EnjoyingNatureCard = new EnjoyingNature();
        EnjoyingthePeace EnjoyingthePeaceCard = new EnjoyingthePeace();
        ExerciseMindAndBody ExerciseMindAndBodyCard = new ExerciseMindAndBody();
        FallInThePond FallInThePondCard = new FallInThePond();
        FindingTheLab FindingTheLabCard = new FindingTheLab();
        GoodbyeProfessor GoodbyeProfessorCard = new GoodbyeProfessor();
        KIN253 KIN253Card = new KIN253();
        LateForCLass LateForCLassCard = new LateForCLass();
        LearningLinux LearningLinuxCard = new LearningLinux();
        LearningNetbeans LearningNetbeansCard = new LearningNetbeans();
        LoudBuzzing LoudBuzzingCard = new LoudBuzzing();
        LunchAtBratwurstHall LunchAtBratwurstHallCard = new LunchAtBratwurstHall();
        MakeAFriend MakeAFriendCard = new MakeAFriend();
        MakeTheDeansList MakeTheDeansListCard = new MakeTheDeansList();
        Math122 Math122Card = new Math122();
        Math123 Math123Card = new Math123();
        MeetTheDean MeetTheDeanCard = new MeetTheDean();
        OralCommunication OralCommunicationCard = new OralCommunication();
        ParkingViolation ParkingViolationCard = new ParkingViolation();
        PassSoccerClass PassSoccerClassCard = new PassSoccerClass();
        Physics151 Physics151Card = new Physics151();
        PressTheRightFloor PressTheRightFloorCard = new PressTheRightFloor();
        ProfessorEnglert ProfessorEnglertCard = new ProfessorEnglert();
        ProfessorHoffman ProfessorHoffmanCard = new ProfessorHoffman();
        ProfessorMurgolos ProfessorMurgolosCard = new ProfessorMurgolos();
        ProgramCrashes ProgramCrashesCard = new ProgramCrashes();
        ResearchCompilers ResearchCompilersCard = new ResearchCompilers();
        ScoreaGoal ScoreaGoalCard = new ScoreaGoal();
        SoccerGoalie SoccerGoalieCard = new SoccerGoalie();
        StudentParking StudentParkingCard = new StudentParking();
        TheBigGame TheBigGameCard = new TheBigGame();
        TheOutpost TheOutpostCard = new TheOutpost();
        LBSUvsUCI LBSUvsUCICard = new LBSUvsUCI();
        CarPool CarPoolCard = new CarPool();
        CECS274 CECS274Card = new CECS274();
        CECS201 CECS201Card = new CECS201();
        ENGL317 ENGL317Card = new ENGL317();
        PHYS152 PHYS152Card = new PHYS152();
        PHIL270 PHIL270Card = new PHIL270();
        CECS228 CECS228Card = new CECS228();
        CECS277 CECS277Card = new CECS277();
        CECS285 CECS285Card = new CECS285();
        CECS282 CECS282Card = new CECS282();
        HaveASwim HaveASwimCard = new HaveASwim();
        List<Card> UnusedDeck = new List<Card>();
        List<Card> DiscradedDeck = new List<Card>();
        #endregion

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

        #region Defined Variables
        List<Room> RoomBoxList = new List<Room>();
        Player CurrentPlayer = new Player();
        int MoveCount = 3;
        bool IterationThreeAchieved = false;
        bool IterationThreeDone = false;
        int MilestoneDone = 0;
        private static Random rng = new Random();
        #endregion

        public GameWindow()
        {
            InitializeComponent();
            InitializeDecks();
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

        private void InitializeDecks()
        {
            UnusedDeck.Add(TheOutpostCard);
            UnusedDeck.Add(TheBigGameCard);
            UnusedDeck.Add(StudentParkingCard);
            UnusedDeck.Add(SoccerGoalieCard);
            UnusedDeck.Add(ScoreaGoalCard);
            UnusedDeck.Add(ResearchCompilersCard);
            UnusedDeck.Add(ProgramCrashesCard);
            UnusedDeck.Add(ProfessorMurgolosCard);
            UnusedDeck.Add(ProfessorHoffmanCard);
            UnusedDeck.Add(ProfessorEnglertCard);
            UnusedDeck.Add(PressTheRightFloorCard);
            UnusedDeck.Add(Physics151Card);
            UnusedDeck.Add(PassSoccerClassCard);
            UnusedDeck.Add(ParkingViolationCard);
            UnusedDeck.Add(OralCommunicationCard);
            UnusedDeck.Add(MeetTheDeanCard);
            UnusedDeck.Add(Math123Card);
            UnusedDeck.Add(Math122Card);
            UnusedDeck.Add(MakeTheDeansListCard);
            UnusedDeck.Add(MakeAFriendCard);
            UnusedDeck.Add(LunchAtBratwurstHallCard);
            UnusedDeck.Add(LoudBuzzingCard);
            UnusedDeck.Add(LearningNetbeansCard);
            UnusedDeck.Add(LearningLinuxCard);
            UnusedDeck.Add(LateForCLassCard);
            UnusedDeck.Add(KIN253Card);
            UnusedDeck.Add(GoodbyeProfessorCard);
            UnusedDeck.Add(FindingTheLabCard);
            UnusedDeck.Add(FallInThePondCard);
            UnusedDeck.Add(ExerciseMindAndBodyCard);
            UnusedDeck.Add(EnjoyingthePeaceCard);
            UnusedDeck.Add(EnjoyingNatureCard);
            UnusedDeck.Add(ElectiveClassCard);
            UnusedDeck.Add(ChoosingAMajorCard);
            UnusedDeck.Add(CHEM111Card);
            UnusedDeck.Add(CECS105Card);
            UnusedDeck.Add(CECS100Card);
            UnusedDeck.Add(BuddyUpCard);
            UnusedDeck.Add(ANewLaptopCard);
        }

        private void IsRandom()
        {
            List<string> PlayerNames = new List<string> { BSinCSSettings.Default.Human_Player_Name, "Gagandeep", "Gaurav" };
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
            #region Status Update
            StatusText.Text += "Human Player is " + Human.PlayerName;
            StatusText.ScrollToEnd();
            #endregion
            Human.CurrentRoom = ECS308;
            #region Randomization Logic
            int cardNumber = UnusedDeck.Count;
            Card value1 = null;
            while (cardNumber > 1)
            {
                cardNumber--;
                int randomCard = rng.Next(cardNumber + 1);
                value1 = UnusedDeck[randomCard];
                UnusedDeck[randomCard] = UnusedDeck[cardNumber];
                UnusedDeck[cardNumber] = value1;
            }
            #endregion
            var selected = UnusedDeck.Take(5).ToList();
            selected.ForEach(item => UnusedDeck.Remove(item));
            Human.Hand = new List<Card>();
            Human.Score = new Score { Craft = 2, Learning = 2, Integrity = 2, QualityPoints = 0 };
            Human.Score.PlayerName = PlayerNames[0];
            Human.Hand.AddRange(selected);
            Human.SelectedCard = Human.Hand.First();
            #region Card Image
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
            logo.EndInit();
            HandBox.Source = logo;
            #endregion
            CurrentPlayer = Human;
            ECS308List.Add(Human);

            AI1.PlayerName = PlayerNames[1];
            AI1.Type = "AI";
            AI1.Score = new Score { Craft = 10, Learning = 10, Integrity = 10, QualityPoints = 0 };
            AI1.Score.PlayerName = PlayerNames[1];
            AI1.CurrentRoom = ECS308;
            ECS308List.Add(AI1);

            AI2.PlayerName = PlayerNames[2];
            AI2.Type = "AI";
            AI2.Score = new Score { Craft = 10, Learning = 10, Integrity = 10, QualityPoints = 0 };
            AI2.Score.PlayerName = PlayerNames[2];
            AI2.CurrentRoom = ECS308;
            ECS308List.Add(AI2);
            #region Status Update
            StatusText.Text += "\n" + AI1.PlayerName + " and " + AI2.PlayerName + " are AI players.";
            StatusText.ScrollToEnd();
            #endregion
        }

        private void IsNotRandom()
        {
            InitializeHumanPlayer();
            InitializeAIPlayers();
        }

        private void UpdateItemSources()
        {
            DataGrid.ItemsSource = new List<Score> { Human.Score, AI1.Score, AI2.Score };
            UnusedLable.Content = "Cards in Deck: " + UnusedDeck.Count();
            DiscardedLable.Content = "Discards out of play: " + DiscradedDeck.Count();
            IdentifierLable.Content = "You are " + CurrentPlayer.PlayerName + " and you are in " + CurrentPlayer.CurrentRoom.RoomName;
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
            AI1.Score = new Score { Craft = 10, Learning = 10, Integrity = 10, QualityPoints = 0 };
            AI1.Score.PlayerName = AI1.PlayerName;
            AI1.CurrentRoom = ECS308;
            ECS308List.Add(AI1);

            AI2.PlayerName = BSinCSSettings.Default.AI2_Name;
            AI2.Type = "AI";
            AI2.Score = new Score { Craft = 10, Learning = 10, Integrity = 10, QualityPoints = 0 };
            AI2.Score.PlayerName = AI2.PlayerName;
            AI2.CurrentRoom = ECS308;
            ECS308List.Add(AI2);
            #region Status Update
            StatusText.Text += "\n" + AI1.PlayerName + " and " + AI2.PlayerName + " are AI players.";
            StatusText.ScrollToEnd();
            #endregion
        }

        public void InitializeHumanPlayer()
        {
            Human.PlayerName = BSinCSSettings.Default.Human_Player_Name;
            Human.Type = "Human";
            Human.Score = new Score { Craft = 2, Learning = 2, Integrity = 2, QualityPoints = 0 };
            Human.Score.PlayerName = Human.PlayerName;
            #region Status Update
            StatusText.Text += "Human Player is " + Human.PlayerName;
            StatusText.ScrollToEnd();
            #endregion
            Human.CurrentRoom = ECS308;
            #region Randomization Logic
            int cardNumber = UnusedDeck.Count;
            Card value = null;
            while (cardNumber > 1)
            {
                cardNumber--;
                int randomCard = rng.Next(cardNumber + 1);
                value = UnusedDeck[randomCard];
                UnusedDeck[randomCard] = UnusedDeck[cardNumber];
                UnusedDeck[cardNumber] = value;
            }
            #endregion
            var selected = UnusedDeck.Take(5).ToList();
            selected.ForEach(item => UnusedDeck.Remove(item));
            Human.Hand = new List<Card>();
            Human.Hand.AddRange(selected);
            Human.SelectedCard = Human.Hand.First();
            #region Card Image
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
            logo.EndInit();
            HandBox.Source = logo;
            #endregion
            CurrentPlayer = Human;
            #region Status Update
            StatusText.Text += "\nCurrent Player is " + CurrentPlayer.PlayerName;
            StatusText.ScrollToEnd();
            #endregion
            ECS308List.Add(Human);
        }

        private void MoveButton_Click(object sender, RoutedEventArgs e)
        {
            MoveCount--;
            CurrentPlayer.CurrentRoom.RoomList.Remove(CurrentPlayer);
            RefreshRoomListBoxes();
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " moved from " + CurrentPlayer.CurrentRoom.RoomName + " to " + CurrentPlayer.NextRoom.RoomName;
            StatusText.ScrollToEnd();
            #endregion
            CurrentPlayer.CurrentRoom = CurrentPlayer.NextRoom;
            CurrentPlayer.CurrentRoom.RoomList.Add(CurrentPlayer);
            RefreshRoomListBoxes();
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
            #region Collecting fallen cards
            if (CurrentPlayer.CurrentRoom == RoomOfRetirement && RoomOfRetirement.RoomCard!=null)
            {
                if (RoomOfRetirement.RoomCard == GoodbyeProfessorCard)
                {
                    CurrentPlayer.Hand.Add(GoodbyeProfessorCard);
                    RoomOfRetirement.RoomCard = null;
                }                
            }
            else if (CurrentPlayer.CurrentRoom == WalterPyramid && WalterPyramid.RoomCard != null)
            {
                if (WalterPyramid.RoomCard == LBSUvsUCICard)
                {
                    CurrentPlayer.Hand.Add(LBSUvsUCICard);
                    RoomOfRetirement.RoomCard = null;
                    #region Card Image
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri("/Images/Cards/" + LBSUvsUCICard.ImageURL, UriKind.Relative);
                    logo.EndInit();
                    HandBox.Source = logo;
                    #endregion
                }
            }
            else if (CurrentPlayer.CurrentRoom == RecCenter && RecCenter.RoomCard != null)
            {
                if (RecCenter.RoomCard == HaveASwimCard)
                {
                    CurrentPlayer.Hand.Add(HaveASwimCard);
                    RoomOfRetirement.RoomCard = null;
                    #region Card Image
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri("/Images/Cards/" + HaveASwimCard.ImageURL, UriKind.Relative);
                    logo.EndInit();
                    HandBox.Source = logo;
                    #endregion

                }
            }
            else if (CurrentPlayer.CurrentRoom == StudentParking && StudentParking.RoomCard != null)
            {
                if (StudentParking.RoomCard == CarPoolCard)
                {
                    CurrentPlayer.Hand.Add(CarPoolCard);
                    RoomOfRetirement.RoomCard = null;
                    #region Card Image
                    BitmapImage logo = new BitmapImage();
                    logo.BeginInit();
                    logo.UriSource = new Uri("/Images/Cards/" + CarPoolCard.ImageURL, UriKind.Relative);
                    logo.EndInit();
                    HandBox.Source = logo;
                    #endregion
                }
            }
            #endregion
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
            PlayCard();
            #region Discard SelectedCard
            if (Human.SelectedCard!=null)
            {
                #region Status Update
                StatusText.Text += "\n" + CurrentPlayer.SelectedCard.CardName + " is discrded from " + CurrentPlayer.PlayerName + "'s hand.";
                StatusText.ScrollToEnd();
                #endregion
                DiscradedDeck.Add(Human.SelectedCard);
                Human.Hand.Remove(Human.SelectedCard);
            }
            Human.SelectedCard = Human.Hand.First();
            #region Card Image
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
            logo.EndInit();
            HandBox.Source = logo;
            #endregion
            #endregion
            while (Human.Hand.Count > 7)
            {
                RemoveCardWindow();
            }
            MoveCount = 3;
            UpdateItemSources();
            IterationThree();
            GameCompletioCheck();
            DivisibleFifteenReward();
            MoveAI(AI1);
            IterationThree();
            GameCompletioCheck();
            MoveAI(AI2);
            IterationThree();
            GameCompletioCheck();
            #region Reset buttons for human player
            MoveButton.IsEnabled = false;
            PlayCardButton.IsEnabled = false;
            RoomBox.IsEnabled = false;
            DrawCardButton.IsEnabled = true;
            #endregion
        }

        private void DivisibleFifteenReward()
        {
            if (Human.Score.QualityPoints > 15 && MilestoneDone<15)
            {
                MilestoneReward();
                MilestoneDone = 15;
            }
            if (Human.Score.QualityPoints > 30 && MilestoneDone < 30)
            {
                MilestoneReward();
                MilestoneDone = 30;
            }
            if (Human.Score.QualityPoints > 45 && MilestoneDone < 45)
            {
                MilestoneReward();
                MilestoneDone = 45;
            }
            if (Human.Score.QualityPoints > 60 && MilestoneDone < 60)
            {
                MilestoneReward();
                MilestoneDone = 60;
            }
            if (Human.Score.QualityPoints > 75 && MilestoneDone < 75)
            {
                MilestoneReward();
                MilestoneDone = 75;
            }
            if (Human.Score.QualityPoints > 90 && MilestoneDone < 90)
            {
                MilestoneReward();
                MilestoneDone = 90;
            }
        }

        private void MilestoneReward()
        {
            #region Show choice Window
            BSinCSSettings.Default.ChipsToChoose += " Craft ";
            BSinCSSettings.Default.ChipsToChoose += " Integrity ";
            BSinCSSettings.Default.ChipsToChoose += " Learning ";
            // Move to Game window
            RewardSelection win3 = new RewardSelection();
            win3.ShowDialog();
            #endregion
            Human.SelectedChip = BSinCSSettings.Default.SelectedChip;
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " recieved " + CurrentPlayer.SelectedChip + " as reward.";
            StatusText.ScrollToEnd();
            #endregion
            #region Reward player based on chip selected
            if (Human.SelectedChip == "Craft")
            {
                Human.Score.Craft += 1;
            }
            else if (Human.SelectedChip == "Integrity")
            {
                Human.Score.Integrity += 1;
            }
            else if (Human.SelectedChip == "Learning")
            {
                Human.Score.Learning += 1;
            }
            #endregion
        }

        private void GameCompletioCheck()
        {
            if (CurrentPlayer.Score.QualityPoints>=100)
            {
                BSinCSSettings.Default.Winner = CurrentPlayer.PlayerName;
                GameComplete Win5 = new GameComplete();
                Win5.ShowDialog();
                Application.Current.Shutdown();
            }
        }

        private void IterationThree()
        {
            if (Human.Score.QualityPoints > 59 && AI1.Score.QualityPoints > 59 && AI2.Score.QualityPoints > 59 && !IterationThreeDone)
            {
                IterationThreeAchieved = true;
            }
            else
            {
                IterationThreeAchieved = false;
            }
            if (IterationThreeAchieved)
            {
                #region Discard Year 1 cards
                Human.Hand.Remove(CECS100Card); UnusedDeck.Remove(CECS100Card); DiscradedDeck.Remove(CECS100Card);
                Human.Hand.Remove(Math122Card); UnusedDeck.Remove(Math122Card); DiscradedDeck.Remove(Math122Card);
                Human.Hand.Remove(ProfessorMurgolosCard); UnusedDeck.Remove(ProfessorMurgolosCard); DiscradedDeck.Remove(ProfessorMurgolosCard);
                Human.Hand.Remove(CECS105Card); UnusedDeck.Remove(CECS105Card); DiscradedDeck.Remove(CECS105Card);
                Human.Hand.Remove(Math123Card); UnusedDeck.Remove(Math123Card); DiscradedDeck.Remove(Math123Card);
                Human.Hand.Remove(Physics151Card); UnusedDeck.Remove(Physics151Card); DiscradedDeck.Remove(Physics151Card);
                Human.Hand.Remove(KIN253Card); UnusedDeck.Remove(KIN253Card); DiscradedDeck.Remove(KIN253Card);
                Human.Hand.Remove(PassSoccerClassCard); UnusedDeck.Remove(PassSoccerClassCard); DiscradedDeck.Remove(PassSoccerClassCard);
                Human.Hand.Remove(ElectiveClassCard); UnusedDeck.Remove(ElectiveClassCard); DiscradedDeck.Remove(ElectiveClassCard);
                Human.Hand.Remove(OralCommunicationCard); UnusedDeck.Remove(OralCommunicationCard); DiscradedDeck.Remove(OralCommunicationCard);
                Human.Hand.Remove(CHEM111Card); UnusedDeck.Remove(CHEM111Card); DiscradedDeck.Remove(CHEM111Card);
                #endregion

                #region Add Year 2 cards
                UnusedDeck.Add(CECS274Card);
                UnusedDeck.Add(CECS201Card);
                UnusedDeck.Add(CECS277Card);
                UnusedDeck.Add(CECS228Card);
                UnusedDeck.Add(CECS285Card);
                UnusedDeck.Add(CECS282Card);
                UnusedDeck.Add(PHIL270Card);
                UnusedDeck.Add(ENGL317Card);
                UnusedDeck.Add(PHYS152Card);
                WalterPyramid.RoomCard = LBSUvsUCICard;
                RecCenter.RoomCard = HaveASwimCard;
                StudentParking.RoomCard = CarPoolCard;
                #endregion

                #region Update human players hand
                #region Randomization Logic
                int cardNumber = UnusedDeck.Count;
                Card value1 = null;
                while (cardNumber > 1)
                {
                    cardNumber--;
                    int randomCard = rng.Next(cardNumber + 1);
                    value1 = UnusedDeck[randomCard];
                    UnusedDeck[randomCard] = UnusedDeck[cardNumber];
                    UnusedDeck[cardNumber] = value1;
                }
                #endregion
                var selected = UnusedDeck.Take(5).ToList();
                selected.ForEach(item => UnusedDeck.Remove(item));
                Human.Hand = new List<Card>();
                Human.Hand.AddRange(selected);
                Human.SelectedCard = Human.Hand.First();
                #region Card Image
                BitmapImage logo = new BitmapImage();
                logo.BeginInit();
                logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
                logo.EndInit();
                HandBox.Source = logo;
                #endregion
                #endregion

                IterationThreeDone = true;
            }
        }

        private void PlayCard()
        {
            // Room Check
            if (CurrentPlayer.SelectedCard.CardRoom.Exists(x => x.RoomName == CurrentPlayer.CurrentRoom.RoomName))
            {
                // Prerequisite presence check
                if (CurrentPlayer.SelectedCard.HasPrerequisite)
                {
                    // Player Prerequisite check
                    if (CurrentPlayer.Score.Craft >= CurrentPlayer.SelectedCard.Prerequisite.Craft &&
                        CurrentPlayer.Score.Integrity >= CurrentPlayer.SelectedCard.Prerequisite.Integrity &&
                        CurrentPlayer.Score.Learning >= CurrentPlayer.SelectedCard.Prerequisite.Learning &&
                        CurrentPlayer.Score.QualityPoints >= CurrentPlayer.SelectedCard.Prerequisite.QualityPoints)
                    {
                        RewardSelectionSuccess();
                    }
                    // Player Prerequisite fail
                    else
                    {
                        // Card fail presence check
                        if (CurrentPlayer.SelectedCard.HasFail)
                        {
                            #region Status Update
                            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " played " + CurrentPlayer.SelectedCard.CardName + " and FAILED! Please complete card prerequisites.";
                            StatusText.ScrollToEnd();
                            #endregion
                            CurrentPlayer.Score.QualityPoints -= 2;
                            CurrentPlayer.SelectedCard.Fail(CurrentPlayer);
                            Teleport();
                            #region Leave card in RoR
                            if (CurrentPlayer.SelectedCard == GoodbyeProfessorCard && CurrentPlayer == Human)
                            {
                                RoomOfRetirement.RoomCard = GoodbyeProfessorCard;
                                CurrentPlayer.SelectedCard = null;
                                CurrentPlayer.Hand.Remove(GoodbyeProfessorCard);
                                #region Status Update
                                StatusText.Text += "\n" + CurrentPlayer.PlayerName + " left " + CurrentPlayer.SelectedCard.CardName + " in Room of Retirement.";
                                StatusText.ScrollToEnd();
                                #endregion
                            }
                            #endregion
                            if (BSinCSSettings.Default.ShouldRemoveCard == true && CurrentPlayer == Human)
                            {
                                RemoveCardFromHand();
                            }
                            BSinCSSettings.Default.ShouldRemoveCard = false;
                        }
                    }
                }
                // Prerequisite not present
                else
                {
                    // Logic for playing cards without prerequisite
                    RewardSelectionSuccess();
                }
            }
            // Room Check fail
            else
            {
                // Logic for not in room
                #region Status Update
                StatusText.Text += "\n" + CurrentPlayer.PlayerName + " played " + CurrentPlayer.SelectedCard.CardName + " and FAILED! Play in the correct room.";
                StatusText.ScrollToEnd();
                #endregion
                CurrentPlayer.Score.QualityPoints -= 2;
            }
        }

        private void Teleport()
        {
            if (BSinCSSettings.Default.Teleport)
            {
                #region Teleport
                #region Status Update
                StatusText.Text += "\n" + CurrentPlayer.PlayerName + " teleported from " + CurrentPlayer.CurrentRoom.RoomName;
                StatusText.ScrollToEnd();
                #endregion
                CurrentPlayer.CurrentRoom.RoomList.Remove(CurrentPlayer);
                RefreshRoomListBoxes();
                if (BSinCSSettings.Default.TeleportRoom == "Student Parking")
                {
                    CurrentPlayer.CurrentRoom = StudentParking;
                }
                else if (BSinCSSettings.Default.TeleportRoom == "Lactation Lounge")
                {
                    CurrentPlayer.CurrentRoom = LactationLounge;
                }
                else if (BSinCSSettings.Default.TeleportRoom == "Room Of Retirement")
                {
                    CurrentPlayer.CurrentRoom = RoomOfRetirement;
                }
                #region Status Update
                StatusText.Text += " to " + CurrentPlayer.CurrentRoom.RoomName;
                StatusText.ScrollToEnd();
                #endregion
                CurrentPlayer.CurrentRoom.RoomList.Add(CurrentPlayer);
                RefreshRoomListBoxes();
                RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
                UpdateItemSources();
                #endregion
                BSinCSSettings.Default.Teleport = false;
            }
        }

        private void RemoveCardFromHand()
        {
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.SelectedCard.CardName + " is discrded from " + CurrentPlayer.PlayerName + "'s hand.";
            StatusText.ScrollToEnd();
            #endregion
            Human.Hand.Remove(Human.SelectedCard);
            RemoveCardWindow();
        }

        private void RemoveCardWindow()
        {
            BSinCSSettings.Default.CardsInHand = new System.Collections.Specialized.StringCollection();
            BSinCSSettings.Default.CardToRemove = "";
            foreach (Card item in CurrentPlayer.Hand)
            {
                BSinCSSettings.Default.CardsInHand.Add(item.ImageURL);
            }
            RemoveFromHand win4 = new RemoveFromHand();
            win4.ShowDialog();
            #region Status Update
            StatusText.Text += "\n" + BSinCSSettings.Default.CardToRemove + " is discrded from " + CurrentPlayer.PlayerName + "'s hand.";
            StatusText.ScrollToEnd();
            #endregion
            DiscradedDeck.Add(CurrentPlayer.Hand.Find(x => x.ImageURL == BSinCSSettings.Default.CardToRemove));
            CurrentPlayer.Hand.RemoveAll(x => x.ImageURL == BSinCSSettings.Default.CardToRemove);
        }

        private void RewardSelectionSuccess()
        {
            // Reward selection check
            if (CurrentPlayer.SelectedCard.RewardSelection && CurrentPlayer.Type == "Human")
            {
                SelectReward();
                // Give reward
                #region Status Update
                StatusText.Text += "\n" + CurrentPlayer.PlayerName + " played " + CurrentPlayer.SelectedCard.CardName + " and SUCCEEDED! Enjoy the reward(s).";
                StatusText.ScrollToEnd();
                #endregion
                CurrentPlayer.SelectedCard.Play(CurrentPlayer, UnusedDeck);
                if (BSinCSSettings.Default.ShouldRemoveCard == true && CurrentPlayer == Human)
                {
                    RemoveCardFromHand();
                }
                BSinCSSettings.Default.ShouldRemoveCard = false;
                #region Update UnusedDeck after adding card to player
                if (CurrentPlayer.SelectedCard == ElectiveClassCard
                    || CurrentPlayer.SelectedCard == MeetTheDeanCard
                    || CurrentPlayer.SelectedCard == ProfessorHoffmanCard
                    || CurrentPlayer.SelectedCard == SoccerGoalieCard)
                {
                    UnusedDeck.Remove(UnusedDeck.First());
                    if(CurrentPlayer.SelectedCard==ProfessorHoffmanCard)
                    {
                        UnusedDeck.Remove(UnusedDeck.First());
                    }
                }
                #endregion
                Teleport();
            }
            // No reward selection
            else
            {
                #region Status Update
                StatusText.Text += "\n" + CurrentPlayer.PlayerName + " played " + CurrentPlayer.SelectedCard.CardName + " and SUCCEEDED! Enjoy the reward(s).";
                StatusText.ScrollToEnd();
                #endregion
                CurrentPlayer.SelectedCard.Play(CurrentPlayer, UnusedDeck);
                if (BSinCSSettings.Default.ShouldRemoveCard == true && CurrentPlayer==Human)
                {
                    RemoveCardFromHand();
                }
                #region Update UnusedDeck after adding card to player
                if (CurrentPlayer.SelectedCard == ElectiveClassCard
                    || CurrentPlayer.SelectedCard == MeetTheDeanCard)
                {
                    UnusedDeck.Remove(UnusedDeck.First());
                }
                #endregion
                Teleport();
            }
        }

        private void SelectReward()
        {
            //Reward selection logic
            #region Specify chips to choose
            BSinCSSettings.Default.ChipsToChoose = "";
            if (CurrentPlayer.SelectedCard.Reward.Craft == 1)
            {
                BSinCSSettings.Default.ChipsToChoose += " Craft ";
            }
            if (CurrentPlayer.SelectedCard.Reward.Integrity == 1)
            {
                BSinCSSettings.Default.ChipsToChoose += " Integrity ";
            }
            if (CurrentPlayer.SelectedCard.Reward.Learning == 1)
            {
                BSinCSSettings.Default.ChipsToChoose += " Learning ";
            }
            #endregion
            // Move to Game window
            RewardSelection win3 = new RewardSelection();
            win3.ShowDialog();
            CurrentPlayer.SelectedChip = BSinCSSettings.Default.SelectedChip;
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " selected " + CurrentPlayer.SelectedChip + " as reward.";
            StatusText.ScrollToEnd();
            #endregion
        }

        private void MoveAI(Player artificialPlayer)
        {
            CurrentPlayer = artificialPlayer;
            if (artificialPlayer == AI1)
            {
                #region Status Update
                StatusText.Text += "\nCurrent Player is " + artificialPlayer.PlayerName;
                StatusText.ScrollToEnd();
                #endregion
            }
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
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " moved from " + CurrentPlayer.CurrentRoom.RoomName + " to " + CurrentPlayer.NextRoom.RoomName;
            StatusText.ScrollToEnd();
            #endregion
            RefreshRoomListBoxes();
            CurrentPlayer.CurrentRoom = CurrentPlayer.NextRoom;
            CurrentPlayer.CurrentRoom.RoomList.Add(CurrentPlayer);
            RefreshRoomListBoxes();
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
            if (UnusedDeck.Exists(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName)))
            {
                CurrentPlayer.SelectedCard = CurrentPlayer == AI1 ? UnusedDeck.First(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName))
                    : UnusedDeck.Last(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName));
            }
            else if (DiscradedDeck.Exists(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName)))
            {
                CurrentPlayer.SelectedCard = CurrentPlayer == AI1 ? DiscradedDeck.First(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName))
                    : DiscradedDeck.Last(x => x.CardRoom.Exists(y => y.RoomName == CurrentPlayer.CurrentRoom.RoomName));
            }
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " selected " + CurrentPlayer.SelectedCard.CardName + " to play in " + CurrentPlayer.CurrentRoom.RoomName;
            StatusText.ScrollToEnd();
            #endregion
            PlayCard();
            CurrentPlayer = CurrentPlayer == AI2 ? Human: AI2;
            #region Status Update
            StatusText.Text += "\nCurrent Player is " + CurrentPlayer.PlayerName;
            StatusText.ScrollToEnd();
            #endregion
            RoomBoxList = CurrentPlayer.CurrentRoom.AccessibleRooms;
            UpdateItemSources();
        }

        private void HandBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Human.SelectedCard= Human.Hand[(Human.Hand.IndexOf(Human.SelectedCard) + 1) == Human.Hand.Count ? 0 : (Human.Hand.IndexOf(Human.SelectedCard) + 1)];
            #region Card Image
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
            logo.EndInit();
            HandBox.Source = logo;
            #endregion
        }

        private void DrawCardButton_Click(object sender, RoutedEventArgs e)
        {
            Card selected = UnusedDeck.First();
            UnusedDeck.Remove(selected);
            Human.Hand.Insert(0, selected);
            Human.SelectedCard = Human.Hand.First();
            #region Status Update
            StatusText.Text += "\n" + CurrentPlayer.PlayerName + " draws " + CurrentPlayer.SelectedCard.CardName + " from the unused deck.";
            StatusText.ScrollToEnd();
            #endregion
            #region Card Image
            BitmapImage logo = new BitmapImage();
            logo.BeginInit();
            logo.UriSource = new Uri("/Images/Cards/" + Human.SelectedCard.ImageURL, UriKind.Relative);
            logo.EndInit();
            HandBox.Source = logo;
            #endregion
            if (UnusedDeck.Count == 0)
            {
                #region Randomization Logic
                int cardNumber = DiscradedDeck.Count;
                Card value = null;
                while (cardNumber > 1)
                {
                    cardNumber--;
                    int randomCard = rng.Next(cardNumber + 1);
                    value = DiscradedDeck[randomCard];
                    DiscradedDeck[randomCard] = DiscradedDeck[cardNumber];
                    DiscradedDeck[cardNumber] = value;
                }
                #endregion
                foreach (Card item in DiscradedDeck)
                {
                    UnusedDeck.Add(item);
                }
                DiscradedDeck.Clear();                
            }
            PlayCardButton.IsEnabled = true;
            DrawCardButton.IsEnabled = false;
            RoomBox.IsEnabled = true;
        }
    }
}