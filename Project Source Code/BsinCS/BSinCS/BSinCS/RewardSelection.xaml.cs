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
    /// Interaction logic for RewardSelection.xaml
    /// </summary>
    public partial class RewardSelection : Window
    {
        public RewardSelection()
        {
            InitializeComponent();
            if (BSinCSSettings.Default.ChipsToChoose.Contains("Craft"))
            {
                CraftButton.IsEnabled = true;
            }
            else
            {
                CraftButton.IsEnabled = false;
            }
            if (BSinCSSettings.Default.ChipsToChoose.Contains("Integrity"))
            {
                IntegrityButton.IsEnabled = true;
            }
            else
            {
                IntegrityButton.IsEnabled = false;
            }
            if (BSinCSSettings.Default.ChipsToChoose.Contains("Learning"))
            {
                LearningButton.IsEnabled = true;
            }
            else
            {
                LearningButton.IsEnabled = false;
            }
        }

        private void ContinueButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CraftButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionLabel.Content = "Craft Chip Selected!";
            BSinCSSettings.Default.SelectedChip = "Craft";
        }

        private void IntegrityButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionLabel.Content = "Integrity Chip Selected!";
            BSinCSSettings.Default.SelectedChip = "Integrity";
        }

        private void LearningButton_Click(object sender, RoutedEventArgs e)
        {
            SelectionLabel.Content = "Learning Chip Selected!";
            BSinCSSettings.Default.SelectedChip = "Learning";
        }
    }
}           
