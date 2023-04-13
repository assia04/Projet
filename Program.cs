using System.Collections;


namespace UA3Projet
{
    public class Client
    {
        public string Noms { get; set; }
        public string Prenoms { get; set; }
        public string Courriel { get; set; }
        public string CarteDeCredit { get; set; }
        public int NumeroDeChambre { get; set; }

        public Client(string nom, string prenom, string courriel, string carteDeCredit, int numeroDeChambre)
        {
            Nom = nom;
            Prenom = prenom;
            Courriel = courriel;
            CarteDeCredit = carteDeCredit;
            NumeroDeChambre = numeroDeChambre;
        }
    }

    public class Hotel
    {
        public ArrayList Clients { get; set; }

        public Hotel()
        {
            Clients = new ArrayList();
        }

        public void AjouterClient(Client client)
        {
            Clients.Add(client);
        }
    }

}
