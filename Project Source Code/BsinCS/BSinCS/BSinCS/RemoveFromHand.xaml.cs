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
using RemoveModel;

namespace BSinCS
{
    /// <summary>
    /// Interaction logic for RemoveFromHand.xaml
    /// </summary>
    public partial class RemoveFromHand : Window
    {
        public RemoveFromHand()
        {
            InitializeComponent();
            List<Remove> CardImagesList = new List<Remove>();
            foreach (string item in BSinCSSettings.Default.CardsInHand)
            {
                CardImagesList.Add(new Remove { Url = "/Images/Cards/" + item });
            }
            CardImages.ItemsSource = CardImagesList;
        }

        private void CardImages_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Remove DiscardedCard = ((sender as ListBox).SelectedItem as Remove);
            BSinCSSettings.Default.CardToRemove = DiscardedCard.Url.Substring(DiscardedCard.Url.LastIndexOf('/') + 1);
            SelectionLabel.Content = BSinCSSettings.Default.CardToRemove.Substring(0, BSinCSSettings.Default.CardToRemove.LastIndexOf('.'));
        }

        private void RemoveButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
