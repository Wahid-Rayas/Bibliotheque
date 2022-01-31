using System;
namespace Bibliotheque
{
    public class Livre
    {
        private string titre;
        private string auteur;
        private int edition;
        protected bool diponible;
        private Employe locataire;

        public Livre(string titre, string auteur, int edition)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.edition = edition;
            diponible = true;
        }

        public void EstLoue()
        {

        }

        public string GetTitre()
        {
            return titre;
        }

        public void SetTitre(string value)
        {
            titre = value;
        }

        public string GetAuteur()
        {
            return auteur;
        }

        public void SetAuteur(string value)
        {
            auteur = value;
        }

        public int GetEdition()
        {
            return edition;
        }

        public void SetEdition(int value)
        {
            edition = value;
        }

        public void SetDisponible(bool value)
        {
            diponible = value;
        }
    }
}
