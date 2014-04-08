using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Film
{
    public class Film
    {
        private string affiche;
        private string nom;

        public Film(string nom, string affiche) {
            this.nom = nom;
            this.affiche = affiche;
        }
        public string getAffiche() {
            return this.affiche;
        
        }
        public string getNom()
        {
            return this.nom;

        }
        public void setAffiche(string Affiche)
        {
            this.affiche = affiche;

        }

        public void setNom(string Affiche)
        {
            this.nom = nom;

        }

    }
}
