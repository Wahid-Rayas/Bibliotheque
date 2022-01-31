using System;
namespace Bibliotheque
{
    public class Bibliothecaire : Employe
    {
        private int identifiant;

        public Bibliothecaire(string nom, string fonction, int identifiant) : base(nom, fonction)
        {
            this.identifiant = identifiant;
        }

        public void Retour()
        {

        }

        public void SetIdentifiant(int value)
        {
            identifiant = value;
        }

        public int GetIdentifiant()
        {
            return identifiant;
        }
    }
}
