using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionStockFarmacy.Mes_Classes
{
    internal class Achats
    {
        public int IdAchat { get; set; }
        public int IdProduit { get; set; }
        public int Quantite { get; set; }
        public DateTime DateAchat { get; set; }
        public decimal Montant { get; set; }

        public Achats(int idAchat, int idProduit, int quantite, DateTime dateAchat, decimal montant)
        {
            IdAchat = idAchat;
            IdProduit = idProduit;
            Quantite = quantite;
            DateAchat = dateAchat;
            Montant = montant;
        }
    }
}
