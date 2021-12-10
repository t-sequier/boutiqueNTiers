using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppClient.Webservice;

namespace AppClient
{
    public partial class FormPagePrincipale : Form
    {
        CClient leClient; //paramètre transmis depuis Form1
        public FormPagePrincipale(CClient client)
        {
            InitializeComponent();
            leClient = client;
            labelIdentiteUtilisateur.Text = leClient.Nom + " " + leClient.Prenom;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCommandes pageCommande = new FormCommandes(leClient);
            pageCommande.Show();
        }
        /// <summary>
        /// Redirection vers la pages des articles
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionArticles_Click(object sender, EventArgs e)
        {
            FormArticles gestionAticle = new FormArticles(leClient);
            gestionAticle.ShowDialog();

        }

        /// <summary>
        /// Redirection vers la pages des clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGestionClient_Click(object sender, EventArgs e)
        {
            FormClient gestionClient = new FormClient();
            gestionClient.ShowDialog();
        }
    }
}
