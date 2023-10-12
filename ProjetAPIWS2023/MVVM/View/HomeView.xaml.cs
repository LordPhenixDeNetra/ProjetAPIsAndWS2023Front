using ProjetAPIWS2023.Core;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using ProjetAPIWS2023.MVVM.Model;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;
using Newtonsoft.Json;

namespace ProjetAPIWS2023.MVVM.View
{
    /// <summary>
    /// Logique d'interaction pour HomeView.xaml
    /// </summary>
    public partial class HomeView : UserControl
    {
        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }

        public HomeView()
        {
            InitializeComponent();
            AllMethods.GetSumValues("http://localhost:8081/api/v1/country-values/totalConfirme", totalCase);
            AllMethods.GetSumValues("http://localhost:8081/api/v1/country-values/totalDeces", totalDeces);

            InitializeChartDataAsync();

        }

        private async Task<List<ContinentData>> GetInfoDecesParContinentAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    var apiUrl = "http://localhost:8081/api/v1/continent-mapping/deces-per-continent";

                    var response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var continentDataList = JsonConvert.DeserializeObject<List<ContinentData>>(content);
                        return continentDataList;
                    }
                    else
                    {
                        // Gérer les erreurs de requête HTTP ici (par exemple, en journalisant ou en levant une exception)
                        Console.WriteLine("Erreur de requête HTTP : " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, en journalisant ou en levant une exception)
                Console.WriteLine("Erreur lors de la récupération des données : " + ex.Message);
            }

            return null; // Ou une liste vide ou une autre gestion d'erreur
        }

        private async Task<List<ContinentData>> GetInfoConfirmeParContinentAsync()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    // Remplacez l'URL par celle de votre API
                    var apiUrl = "http://localhost:8081/api/v1/continent-mapping/confirme-per-continent";

                    var response = await client.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        var content = await response.Content.ReadAsStringAsync();
                        var continentDataList = JsonConvert.DeserializeObject<List<ContinentData>>(content);
                        return continentDataList;
                    }
                    else
                    {
                        // Gérer les erreurs de requête HTTP ici (par exemple, en journalisant ou en levant une exception)
                        Console.WriteLine("Erreur de requête HTTP : " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, en journalisant ou en levant une exception)
                Console.WriteLine("Erreur lors de la récupération des données : " + ex.Message);
            }

            return null; // Ou une liste vide ou une autre gestion d'erreur
        }

        private async void InitializeChartDataAsync()
        {
            var decesData = await GetInfoDecesParContinentAsync();
            var confirmeData = await GetInfoConfirmeParContinentAsync();

            if (decesData != null && confirmeData != null)
            {
                // Créez les séries pour le graphique
                this.SeriesCollection = new SeriesCollection
                {
                    /*new LineSeries
                    {
                        Title = "Total Décès",
                        Values = new ChartValues<long>(decesData.Select(data => data.TotalDeces)),

                    },*/
                    new LineSeries
                    {
                        Title = "Total Cas Confirmés",
                        Values = new ChartValues<long>(confirmeData.Select(data => data.TotalConfirme)),
                    },
                };

                // Les labels pour l'axe X peuvent être les continents
                Labels = decesData.Select(data => data.Continent.ToString()).ToArray();

                DataContext = this;
            }
            else
            {
                // Gérer le cas où les données sont null (par exemple, en affichant un message d'erreur)
                // Vous pouvez afficher un message dans l'interface utilisateur ou journaliser l'erreur.
            }
        }


    }


}
