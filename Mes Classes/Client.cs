using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace GestionStockFarmacy
{
    internal class Client
    {
        public int IdClient { get; set; }
        public string Nom { get; set; }
        public string Postnom { get; set; }
        public string Prenom { get; set; }
        public char Sexe { get; set; }
        public string Telephone { get; set; }
        public string Adresse { get; set; }

        public Client() { }

        public Client(int idClient, string nom, string postnom, string prenom, char sexe, string telephone, string adresse)
        {
            IdClient = idClient;
            Nom = nom;
            Postnom = postnom;
            Prenom = prenom;
            Sexe = sexe;
            Telephone = telephone;
            Adresse = adresse;
        }
    }
}
