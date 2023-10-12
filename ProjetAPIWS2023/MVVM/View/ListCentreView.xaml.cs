using ProjetAPIWS2023.MVVM.Model;
using ProjetAPIWS2023.MVVM.ViewModel;
using ProjetAPIWS2023.Windows;
using System.Windows.Controls;

namespace ProjetAPIWS2023.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour ListCentreView.xaml
    /// </summary>
    public partial class ListCentreView : UserControl
    {
        public ListCentreView()
        {
            InitializeComponent();
        }

        private void listViewCentres_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            // Récupérez l'élément sélectionné
            ListCentreModel selectedModel = (sender as ListView).SelectedItem as ListCentreModel;

            if (selectedModel != null)
            {
                // Créez une nouvelle fenêtre pour afficher les détails
                DetailCentre detailsWindow = new DetailCentre();
                detailsWindow.DataContext = selectedModel; // Passez les données à la fenêtre de détails
                detailsWindow.ShowDialog(); // Affichez la fenêtre de détails en mode modal
            }
        }

    }

}
