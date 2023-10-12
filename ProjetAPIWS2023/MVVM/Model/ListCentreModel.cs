using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetAPIWS2023.MVVM.Model
{
    internal class ListCentreModel
    {
        public ListCentreModel( long id, 
                                string adresseCentre, 
                                string nomCentre, 
                                string contactCentre, 
                                string regionCentre, 
                                string villeCentre, 
                                string communeCentre, 
                                string positionCentre)
        {
            this.id = id;
            this.adresseCentre = adresseCentre;//
            this.nomCentre = nomCentre;//
            this.contactCentre = contactCentre;//
            this.regionCentre = regionCentre;
            this.villeCentre = villeCentre;//
            this.communeCentre = communeCentre;
            this.positionCentre = positionCentre;//
        }

        //private long IdCentre { get; set; }

        private long id;
        public long Id 
        {
            get { return id; }
            set
            {
                id = value;
            } 
        }


        private string adresseCentre;
        public string AdresseCentre
        {
            get { return adresseCentre; }
            set
            {
                adresseCentre = value;
            }
        }

        private string nomCentre;
        public string NomCentre
        {
            get { return nomCentre; }
            set
            {
                nomCentre = value;
            }
        }


        private string contactCentre;
        public string ContactCentre
        {
            get { return contactCentre; }
            set
            {
                contactCentre = value;
            }
        }

        private string regionCentre;
        public string RegionCentre
        {
            get { return regionCentre; }
            set
            {
                regionCentre = value;
            }
        }

        private string villeCentre;
        public string VilleCentre
        {
            get { return villeCentre; }
            set
            {
                villeCentre = value;
            }
        }

        private string communeCentre;
        public string CommuneCentre
        {
            get { return communeCentre; }
            set
            {
                communeCentre = value;
            }
        }

        private string positionCentre;
        public string PositionCentre
        {
            get { return positionCentre; }
            set
            {
                positionCentre = value;
            }
        }


    }


}
