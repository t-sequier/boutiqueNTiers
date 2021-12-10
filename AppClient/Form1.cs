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
    public partial class Form1 : Form
    {
        Webservice.WebServiceSoapClient WsClient = new Webservice.WebServiceSoapClient();

        public Form1()
        {
            InitializeComponent();

            /*webservice.CPays[] tmp = client.GetAllPays();
            foreach(webservice.CPays p in tmp)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }*/

            //client.GetAllPaysCompleted += Client_GetAllPaysCompleted;
            //client.GetAllPaysAsync();
        }

        /*private void Client_GetAllPaysCompleted(object sender, webservice.GetAllPaysCompletedEventArgs e)
        {
            foreach (webservice.CPays p in e.Result)
            {
                textBox1.Text += "\r\n" + p.Id + " - " + p.Nom;
            }
        }*/

   

        /*Clic sur le bouton annuler*/
        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        /*Clic sur le bouton de connexion*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(nomText.Text) || String.IsNullOrEmpty(mailText.Text))
            {
                MessageBox.Show("il faut remplir tout les champs", "erreur", MessageBoxButtons.OK);
            }
            else
            {
                WsClient.getConnectCompleted += Ws_client_getConnectCompleted;
                WsClient.getConnectAsync(nomText.Text, mailText.Text);

                //desactivation des boutons
                cancelButton.Enabled = false;
                connectButton.Enabled = false;
            }
        }

        private void Ws_client_getConnectCompleted(object sender, Webservice.getConnectCompletedEventArgs e)
        {
            try
            {
                //String infosClient = e.Result.Id + "\n" + e.Result.Nom + "\n" + e.Result.Prenom + "\n" + e.Result.NumAdr + "\n" + e.Result.RueAdr + "\n" + e.Result.Cp + "\n" + e.Result.Email + "\n" + e.Result.Tel + "\n" + e.Result.Civ;
                FormPagePrincipale form = new FormPagePrincipale(e.Result);
                form.Show();
                WsClient.getConnectCompleted -= Ws_client_getConnectCompleted;
            }
            catch
            {
                MessageBox.Show("echec de connexion, verifier vos informations", "erreur", MessageBoxButtons.OK);
                
                //réactivation des boutons
                cancelButton.Enabled = true;
                connectButton.Enabled = true;
                WsClient.getConnectCompleted -= Ws_client_getConnectCompleted;
            }

            

        }
    }
}

