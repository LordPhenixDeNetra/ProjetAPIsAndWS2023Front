using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ProjetAPIWS2023.Core
{
    internal class AllMethods
    {

        public static async void GetSumValues(string apiUrl, TextBlock textToUpdate)
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    
                    HttpResponseMessage response = await httpClient.GetAsync(apiUrl);

                    if (response.IsSuccessStatusCode)
                    {
                        string number = await response.Content.ReadAsStringAsync();
                        textToUpdate.Text = FormatStringNumberWithThousandsSeparator(number);
                        
                    }
                    else
                    {
                        /*MessageBox.Show($"Erreur HTTP : {response.StatusCode}");*/
                    }
                }
                catch (Exception ex)
                {
                    /*MessageBox.Show($"Une erreur s'est produite : {ex.Message}");*/
                }
            }
        }

        /*
        public static string FormatStringNumberWithThousandsSeparator_(string numberString)
        {
            if (!string.IsNullOrEmpty(numberString) && long.TryParse(numberString, out long number))
            {
                return string.Format("{0:#,0}", number);
            }
            return numberString;
        }
        */

        public static string FormatStringNumberWithThousandsSeparator(string numberString)
        {
            if (!string.IsNullOrEmpty(numberString) && long.TryParse(numberString, out long number))
            {
                CultureInfo culture = CultureInfo.InvariantCulture; // Utilisation de la culture "invariant" pour la virgule comme séparateur
                return number.ToString("#,0", culture);
            }
            return numberString;
        }
    }
}
