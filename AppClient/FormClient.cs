using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppClient
{
    public partial class FormClient : Form
    {

        Webservice.WebServiceSoapClient wsClient = new Webservice.WebServiceSoapClient();

        //Récupère la cellule selectionnée
        private DataGridViewCell clickedCell;

        public FormClient()
        {
            InitializeComponent();

            /*Appel WS asynchrone*/
            wsClient.getTousLesClientsCompleted += WsClient_getTousLesClientsCompleted;
            wsClient.getTousLesClientsAsync();

            //Modifie les couleurs des boutons
            btnAddCli.ForeColor = Color.Green;
            btnDelCli.ForeColor = Color.Red;
            btnOkCli.ForeColor = Color.Blue;

        }

        private void WsClient_getTousLesClientsCompleted(object sender, Webservice.getTousLesClientsCompletedEventArgs e)
        {
            //définit la source de la gridView comme étant la liste retournée par le WS
            gvClientAll.DataSource = wsClient.getTousLesClients();
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOkCli_Click(object sender, EventArgs e)
        {
            //TODO: Enregistrer les modifications effectuées (ajout/modif/supp)

            //TODO: Affiche un message si les modifications on bien été pris en compte
            MessageBox.Show("Modification enregistrés ! (non)");
        }

        private void btnAddCli_Click(object sender, EventArgs e)
        {
            //Appel un form dans une autre fenêtre pour ajouter un nouveau client
            FormAddClient formAddCli = new FormAddClient();
            //On laisse en show pour avoir accès au tableau si besoin
            formAddCli.Show();
        }

        private void btnDelCli_Click(object sender, EventArgs e)
        {
            //TODO: Supprimer l'élément (ligne) sélectionné

        }
    }
}
