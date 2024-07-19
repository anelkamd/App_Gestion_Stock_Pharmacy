using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockFarmacy.Mes_Classes
{
    internal class Ventes
    {
        public int IdVente { get; set; }
        public int IdProduit { get; set; }
        public int IdClient { get; set; }
        public int Quantite { get; set; }
        public DateTime DateVente { get; set; }
        public decimal PrixTotal { get; set; }

        public Ventes(int idVente, int idProduit, int idClient, int quantite, DateTime dateVente, decimal prixTotal)
        {
            IdVente = idVente;
            IdProduit = idProduit;
            IdClient = idClient;
            Quantite = quantite;
            DateVente = dateVente;
            PrixTotal = prixTotal;
        }
    }
}
