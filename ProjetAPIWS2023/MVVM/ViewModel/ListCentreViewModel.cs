using Newtonsoft.Json;
using ProjetAPIWS2023.Core;
using ProjetAPIWS2023.MVVM.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace ProjetAPIWS2023.MVVM.ViewModel
{
    internal class ListCentreViewModel : ObservableObject
    {
        private ObservableCollection<ListCentreModel> listCentres;

        private bool isLoading;

        public ObservableCollection<ListCentreModel> ListCentres
        {
            get { return listCentres; }
            set
            {
                listCentres = value;
                OnPropertyChanged();
            }
        }

        public bool IsLoading
        {
            get { return isLoading; }
            set
            {
                isLoading = value;
                OnPropertyChanged();
            }
        }

        // Commande pour effectuer une action, par exemple, charger les données
        public ICommand LoadDataCommand { get; private set; }

        public ListCentreViewModel()
        {
            // Initialisez et chargez les données de ListCentres ici
            // Par exemple :
            
            /*ListCentres = new ObservableCollection<ListCentreModel>
            {
                new ListCentreModel(1, "Adresse 1", "Nom 1", "Contact 1", "Region 1", "Ville 1", "Commune 1", "Position 1"),
                new ListCentreModel(2, "Adresse 2", "Nom 2", "Contact 2", "Region 2", "Ville 2", "Commune 2", "Position 2"),
                // Ajoutez d'autres éléments de données ici
            };*/

            // Configurez la commande pour charger les données
            //LoadDataCommand = new RelayCommand(LoadData);

            ListCentres = new ObservableCollection<ListCentreModel>();

            LoadDataCommand = new RelayCommand(async o => await LoadDataAsync());

            LoadDataAsync();
        }

        public async Task LoadDataAsync()
        {
            try
            {
                IsLoading = true;

                using (HttpClient client = new HttpClient())
                {
                    HttpResponseMessage response = await client.GetAsync("http://localhost:8081/api/v1/centre");

                    if (response.IsSuccessStatusCode)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        // Désérialiser les données JSON en une liste d'objets ListCentreModel
                        List<ListCentreModel> listCentreModels = JsonConvert.DeserializeObject<List<ListCentreModel>>(content);

                        // Mettez à jour ListCentres avec les objets désérialisés
                        ListCentres.Clear(); // Effacez les données existantes
                        foreach (var centreModel in listCentreModels)
                        {
                            ListCentres.Add(centreModel); // Ajoutez les nouvelles données
                        }
                    }
                    else
                    {
                        // Gérez les erreurs en conséquence, par exemple, en affichant un message à l'utilisateur
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs génériques
                Console.WriteLine($"Erreur : {ex.Message}");

                MessageBox.Show($"Une erreur s'est produite : {ex.Message}");
            }
            finally
            {
                IsLoading = false;
            }

        }


    }
}
