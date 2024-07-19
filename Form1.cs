using GestionStockFarmacy.Mes_Classes;
using Microsoft.Data.SqlClient;
using System.Diagnostics;

namespace GestionStockFarmacy
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmVente frm = new frmVente();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmAchat frm = new FrmAchat();
            frm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmProduits frm = new FrmProduits();
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmConnexion frm = new frmConnexion();
            frm.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            DataAccess data = new DataAccess();
            bool isOpen = data.OpenConnection();
            if (isOpen)
            {
                MessageBox.Show("Connexion reussie");
            }
            else
            {
                MessageBox.Show("Connexion a echoue...");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string url = "https://isig.ac.cd";

            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }
    }
}
