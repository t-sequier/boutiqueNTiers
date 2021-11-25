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

        public FormClient()
        {
            InitializeComponent();

            /*Appel WS asynchrone*/
            wsClient.getTousLesClientsCompleted += WsClient_getTousLesClientsCompleted;
            wsClient.getTousLesClientsAsync();
        }

        private void WsClient_getTousLesClientsCompleted(object sender, Webservice.getTousLesClientsCompletedEventArgs e)
        {
            gvClientAll.DataSource = wsClient.getTousLesClients();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvCliAll_rempli()
        {
            //Todo: remplir la grid view au chargement (asynch) (avec WebServiceClient.getTousLesClients() ?)


        }

    }
}
