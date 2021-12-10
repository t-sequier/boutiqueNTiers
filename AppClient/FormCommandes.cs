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
    public partial class FormCommandes : Form
    {
        CClient leClient;
        Webservice.WebServiceSoapClient wsClient = new Webservice.WebServiceSoapClient();

        public FormCommandes(CClient client)
        {
            InitializeComponent();
            leClient = client;

            //désactivation du bouton si pas de ligne dans la gridView (càd panier vide)
            

            //appel au Ws pour récupérer le panier
            wsClient.getLignePanierClientCompleted += Ws_client_getLignePanierClientCompleted;
            wsClient.getLignePanierClientAsync(leClient.Id);
        }

        private void Ws_client_getLignePanierClientCompleted(object sender, getLignePanierClientCompletedEventArgs e)
        {
            //remplissage de la gridView du panier
            dataGridViewPanierDansCommande.DataSource = wsClient.getLignePanierClient(leClient.Id);
        }


        /*Lors du click pour valider le panier*/
        private void buttonValiderPanier_Click(object sender, EventArgs e)
        {
            //si bouton désactiver (càd panier = vide) affichage messagebox information
            if (dataGridViewPanierDansCommande.Rows.Count == 0)
            {
                MessageBox.Show("Votre panier est vide, ajouter des articles pour passer une commande", "Panier vide !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //si panier pas vide, on transforme le panier en commande càd appel au Ws 
                wsClient.paniertToCommandeCompleted += Ws_client_paniertToCommandeCompleted;
                wsClient.paniertToCommandeAsync(leClient.Id);

            }
        }

        private void Ws_client_paniertToCommandeCompleted(object sender, paniertToCommandeCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
        }
    }
}
