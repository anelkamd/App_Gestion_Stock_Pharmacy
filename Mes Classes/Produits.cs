using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GestionStockFarmacy.Mes_Classes
{
    internal class Produits
    {
        public int IdProduit { get; set; }
        public string Designation { get; set; }
        public double PrixUnitaire { get; set; }
        public int Quantite { get; set; }

        public Produits(int idProduit, string designation, double prixUnitaire, int quantite)
        {
            IdProduit = idProduit;
            Designation = designation;
            PrixUnitaire = prixUnitaire;
            Quantite = quantite;
        }

        public Produits() { }

        private DataAccess data = new DataAccess();
        


        public int Ajouter(Produits produit)
        {
            int resultat = 0;
            string strQuery = "INSERT INTO Produits( Designation, PrixUnitaire, Quantite) VALUES(@Designation, @PrixUnitaire, @Quantite)";

            if (data.OpenConnection())
            {
                try
                {
                    using (SqlCommand cmd = new SqlCommand(strQuery, data.conn))
                    {
                        //cmd.Parameters.AddWithValue("@IdProduit", produit.IdProduit);
                        cmd.Parameters.AddWithValue("@Designation", produit.Designation);
                        cmd.Parameters.AddWithValue("@PrixUnitaire", produit.PrixUnitaire);
                        cmd.Parameters.AddWithValue("@Quantite", produit.Quantite);

                        resultat = cmd.ExecuteNonQuery();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'insertion du produit : {ex.Message}");
                }
                finally
                {
                    data.CloseConnection();
                }
            }
            else
            {
                MessageBox.Show("Impossible d'ouvrir la connexion à la base de données.");
            }

            return resultat;
        }


        public List<Produits> GetProduits()
        {
            List<Produits> list = new List<Produits>();
            string StrQuery = "select * from Produits";
            if (data.OpenConnection())
            {
                SqlCommand cmd = new SqlCommand(StrQuery, data.conn);
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Produits pro = new Produits();
                    pro.IdProduit = Convert.ToInt32(rd[IdProduit]);
                    pro.Designation = Convert.ToString(rd[Designation]);
                    pro.PrixUnitaire = Convert.ToInt32(rd["PrixUnitaire"]);
                    pro.Quantite = Convert.ToInt32(rd[Quantite]);
                    list.Add(pro);

                }
                rd.Close();
                cmd.Dispose();
                data.CloseConnection();
            }
            return list;
        }

    }
}
