using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Salle
{
    public class Salle
    {
        private int nbPlace;
        private int nbPlaceTarifNormal;
        private int nbPlaceTarifReduit;
        private int pourcentageReduction;
        private double prix;

        public Salle(string titre, int nbPlace, double prixPlace, string photoAffiche)
        {
            this.nbPlace = nbPlace;

        }
    }
}
