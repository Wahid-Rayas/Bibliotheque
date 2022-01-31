using System;
namespace Bibliotheque
{
    public class Employe
    {
        private string nom;
        private string fonction;
        private int bureau;
        private string email;
     

        public Employe(string nom, string fonction)
        {
            this.nom = nom;
            this.fonction = fonction;
        }

        public void Afficher()
        {

        }

        public void Louer()
        {

        }

        public string GetNom()
        {
            return nom;
        }

        public void SetNom(string value)
        {
            nom = value;
        }

        public string GetFonction()
        {
            return fonction;
        }

        public void SetFonction(string value)
        {
            fonction = value;
        }

        public int GetBureau()
        {
            return bureau;
        }

        public void SetTitre(int value)
        {
            bureau = value;
        }

        public string GetEmail()
        {
            return email;
        }

        public void SetEmail(string value)
        {
            email = value;
        }

    }
}
