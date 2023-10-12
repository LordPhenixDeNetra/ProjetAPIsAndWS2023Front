using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAPIWS2023.MVVM.Model
{
    internal class ContinentData
    {

        private string continent;
        public string Continent
        {
            get { return continent; }
            set
            {
                continent = value;
            }
        }

        private long totalDeces;
        public long TotalDeces
        {
            get { return totalDeces; }
            set
            {
                totalDeces = value;
            }
        }

        private long totalConfirme;
        public long TotalConfirme
        {
            get { return totalConfirme; }
            set
            {
            totalConfirme = value;
            }
        }

        public ContinentData(string continent, long totalDeces, long totalConfirme)
        {
            this.continent = continent;
            this.totalDeces = totalDeces;
            this.totalConfirme = totalConfirme;
        }
    }
}
