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

namespace BSinCS
{
    /// <summary>
    /// Interaction logic for GameComplete.xaml
    /// </summary>
    public partial class GameComplete : Window
    {
        public GameComplete()
        {
            InitializeComponent();
            WinnerLable.Text = "Hurray! " + BSinCSSettings.Default.Winner + " has won!";
        }

        private void End_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
