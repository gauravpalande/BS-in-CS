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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BSinCS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Application start
        public MainWindow()
        {
            BSinCSSettings.Default.IsRandom = false;
            // Initialize Windows components
            InitializeComponent();
        }
        // Events on Done! button click
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            // Update user setting value in Textbox.
            BSinCSSettings.Default.Human_Player_Name = Name_Box.Text;

            // Save name in the config file.
            BSinCSSettings.Default.Save();
            GameWindow win2 = new GameWindow();
            // Move to Game window
            win2.Show();
            // Close the Name Window
            this.Close();
        }
        // Logic upon text input
        private void NameBox_TextInput(object sender, TextCompositionEventArgs e)
        {
            Name_Button.IsEnabled = true;
            Name_Button.Focusable = true;
            Keyboard.Focus(Name_Button);
        }
        // Logic upon mouse click in text box
        private void Name_Box_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Name_Box.Focusable = true;
            Keyboard.Focus(Name_Box);
        }

        private void checkBox_Checked(object sender, RoutedEventArgs e)
        {
            Name_Box.Text = BSinCSSettings.Default.Human_Player_Name;
        }

        private void checkBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Name_Box.Text = "";
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            Name_Box.Text = Name_Box.Text==""? "Micheal": BSinCSSettings.Default.Human_Player_Name;
            checkBox.IsChecked = false;
            checkBox.IsEnabled = false;
            Name_Button.IsEnabled = true;
            BSinCSSettings.Default.IsRandom = BSinCSSettings.Default.FalseRandom;
            BSinCSSettings.Default.IsRandom = Random.IsChecked == true ?  true : false;
        }
    }
}
