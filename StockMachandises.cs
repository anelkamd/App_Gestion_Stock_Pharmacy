using GestionStockFarmacy.Mes_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace GestionStockFarmacy
{
    public partial class FrmProduits : Form
    {
        public FrmProduits()
        {
            InitializeComponent();
        }

        Produits produits = new Produits();

        private void bindingClass(Produits produit)
        {
            produit.IdProduit = int.Parse(txCodeProduit.Text);
            produit.Designation = txDesignation.Text;
            produit.PrixUnitaire = double.Parse(txPrixUnitaire.Text);
            produit.Quantite = int.Parse(txQuantite.Text);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FrmProduits_Load(object sender, EventArgs e)
        {

        }

        private void Submite_Click(object sender, EventArgs e)
        {
            try
            {
                Produits produit = new Produits();

                bindingClass(produit);

                Produits produitsInstance = new Produits();

                int resultat = produitsInstance.Ajouter(produit);
                if (resultat > 0)
                {
                    MessageBox.Show("Ajout Réussi");
                }
                else
                {
                    MessageBox.Show("L'ajout a échoué");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Un problème s'est produit, veuillez réessayer !!!");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Produits produitsInstance = new Produits();
                List<Produits> produits = produitsInstance.GetProduits();
                dgProduits.DataSource = produits;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de Chargement Article");
            }
        }
    }
}
