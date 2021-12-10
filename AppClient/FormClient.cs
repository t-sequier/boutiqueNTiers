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
    public partial class FormClient : Form
    {

        Webservice.WebServiceSoapClient wsClient = new Webservice.WebServiceSoapClient();

        public FormClient()
        {
            InitializeComponent();
            afficheLesClients();
            

        }

        /*Pour afficher tous les clients*/
        public void afficheLesClients()
        {
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

       

        /*Lors du click pour ajouter un client*/
        private void btnAddCli_Click(object sender, EventArgs e)
        {

            //vérification que tous les champs sont rentrés
            if (NomClientAjouter.Text == "" || PrenomClientAjouter.Text == "" || NumAdrClientAjouter.Text == "" || RueAdrClientAjouter.Text == "" || CpClientAjouter.Text == "" || EmailClientAjouter.Text == "" || EmailClientAjouter.Text == "" || TelClientAjouter.Text == "")
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    int.Parse(CpClientAjouter.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Le code postal n'est pas correct", "Erreur sur le code postal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*Création d'un objet CClient si pas d'erreur dans le try catch*/
                string nom = NomClientAjouter.Text;
                string prenom = PrenomClientAjouter.Text;
                string numadr = NumAdrClientAjouter.Text;
                string rueadr = RueAdrClientAjouter.Text;
                int cp = int.Parse(CpClientAjouter.Text);
                string email = EmailClientAjouter.Text;
                string tel = TelClientAjouter.Text;
                int civ;

                /*récupération de la valeur du radio*/
                bool isChecked = radioHommeClientAjouter.Checked;
                if (isChecked)
                    civ = 1; //le radio homme est séléctionné
                else
                    civ = 2; //le radio femme est séléctionné


                CClient clientAAjouter = new CClient(nom, prenom, numadr, rueadr, cp, email, tel, civ);

                /*Appel WS asynchrone*/
                wsClient.addClientCompleted += WsClient_addClientCompleted;
                wsClient.addClientAsync(clientAAjouter);
            }
           
        }

        private void WsClient_addClientCompleted(object sender, addClientCompletedEventArgs e)
        {
            if (e.Result == 1)
            {
                MessageBox.Show("Ajout confirmé");
            }
            else
            {
                MessageBox.Show("Erreur pendant l'ajout du client");
            }
            wsClient.addClientCompleted -= WsClient_addClientCompleted;
        }



        /*Lors du click pour supprimer un client*/
        private void btnDelCli_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer l'article ?", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //vérification que tous les champs sont rentrés
                if (NomClientModifier.Text == "" && PrenomClientModifier.Text == "" && NumAdrClientModifier.Text == "" && RueAdrClientModifier.Text == "" && CpClientModifier.Text == "" && EmailClientModifier.Text == "" && EmailClientModifier.Text == "" && TelClientModifier.Text == "")
                {
                    MessageBox.Show("Sélectionnez un client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (IdClientModifier.Text == "")
                {
                    MessageBox.Show("Impossible de supprimer ce client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*Création d'un objet CClient si pas d'erreur dans le try catch*/
                    int id = int.Parse(IdClientModifier.Text);
                    string nom = NomClientModifier.Text;
                    string prenom = PrenomClientModifier.Text;
                    string numadr = NumAdrClientModifier.Text;
                    string rueadr = RueAdrClientModifier.Text;
                    int cp = int.Parse(CpClientModifier.Text);
                    string email = EmailClientModifier.Text;
                    string tel = TelClientModifier.Text;
                    int civ;
                    MessageBox.Show(id + "");
;
                    /*récupération de la valeur du radio*/
                    bool isChecked = radioHommeModifierClient.Checked;
                    if (isChecked)
                        civ = 1; //le radio homme est séléctionné
                    else
                        civ = 2; //le radio femme est séléctionné


                    CClient clientASupprimer = new CClient(id, nom, prenom, numadr, rueadr, cp, email, tel, civ);

                    //appel au WS pour mettre à jour les infos du client
                    wsClient.deleteClientCompleted += Ws_client_delete_clientCompleted;
                    wsClient.deleteClientAsync(clientASupprimer);

                }
            }
        }

        private void Ws_client_delete_clientCompleted(object sender, deleteClientCompletedEventArgs e)
        {
            if (e.Result.ToString() == "true")
            {
                MessageBox.Show("Suppression confirmée");
            }
            else
            {
                MessageBox.Show("Erreur pendant la suppression");
            }
            wsClient.deleteClientCompleted -= Ws_client_delete_clientCompleted;
        }



        /*Lors du clic sur un client*/
        private void clickSurUnClient(object sender, DataGridViewCellEventArgs e)
        {

            String nom = "", prenom = "", numAdr = "", rueAdr = "", cp = "", email = "", tel="", civ="", id = ""; //pour l'affichage des infos sur un client et sa modification
            foreach (DataGridViewRow row in gvClientAll.SelectedRows) {
                id = row.Cells[0].Value.ToString();
                nom = row.Cells[1].Value.ToString();
                prenom = row.Cells[2].Value.ToString();
                numAdr = row.Cells[3].Value.ToString();
                rueAdr = row.Cells[4].Value.ToString();
                cp = row.Cells[5].Value.ToString();
                email = row.Cells[6].Value.ToString();
                tel = row.Cells[7].Value.ToString();
                civ = row.Cells[8].Value.ToString();
            }

            IdClientModifier.Text = id;
            NomClientModifier.Text = nom;
            PrenomClientModifier.Text = prenom;
            NumAdrClientModifier.Text = numAdr;
            RueAdrClientModifier.Text = rueAdr;
            CpClientModifier.Text = cp;
            EmailClientModifier.Text = email;
            TelClientModifier.Text = tel;

            /*gestion de la civilité*/
            switch (civ)
            {
                case "1":
                    radioHommeModifierClient.Checked = true;
                    radioFemmeModifierClient.Checked = false;
                    break;
                case "2":
                    radioHommeModifierClient.Checked = false;
                    radioFemmeModifierClient.Checked = true;
                    break;
                default:
                    radioHommeModifierClient.Checked = false;
                    radioFemmeModifierClient.Checked = false;
                    break;

            }

            
        }

        /*Lors du click de confirmation de modification d'un client*/
        private void btnOkCli_Click(object sender, EventArgs e)
        {
            //vérification que tous les champs sont rentrés
            if (NomClientModifier.Text == "" || PrenomClientModifier.Text == "" || NumAdrClientModifier.Text == "" || RueAdrClientModifier.Text == "" || CpClientModifier.Text == "" || EmailClientModifier.Text == "" || EmailClientModifier.Text =="" || TelClientModifier.Text == "")
            {
                MessageBox.Show("Tous les champs doivent être remplis", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (IdClientModifier.Text == "")
            {
                MessageBox.Show("Impossible de modifier les informations de ce client", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    int.Parse(CpClientModifier.Text);
                }catch(Exception)
                {
                    MessageBox.Show("Le code postal n'est pas correct", "Erreur sur le code postal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*Création d'un objet CClient si pas d'erreur dans le try catch*/
                int id = int.Parse(IdClientModifier.Text);
                string nom = NomClientModifier.Text;
                string prenom = PrenomClientModifier.Text;
                string numadr = NumAdrClientModifier.Text;
                string rueadr = RueAdrClientModifier.Text;
                int cp = int.Parse(CpClientModifier.Text);
                string email = EmailClientModifier.Text;
                string tel = TelClientModifier.Text;
                int civ;

               /*récupération de la valeur du radio*/
                string valeur = "";
                bool isChecked = radioHommeModifierClient.Checked;
                if (isChecked)
                    civ = 1; //le radio homme est séléctionné
                else
                    civ = 2; //le radio femme est séléctionné


                CClient clientAModifier = new CClient(id, nom, prenom, numadr, rueadr, cp, email, tel, civ);

                MessageBox.Show("UPDATE Client SET NOM='" + clientAModifier.Nom + "',PRENOM='" + clientAModifier.Prenom + "' ,ADRESSE_NUMERO='" + clientAModifier.NumAdr + "', ADRESSE_RUE='" + clientAModifier.RueAdr + "', CODE_POSTAL=" + clientAModifier.Cp + ", EMAIL='" + clientAModifier.Email + "', TEL='" + clientAModifier.Tel + "', ID_CIVILITE=" + clientAModifier.Civ + " WHERE NUMERO = " + clientAModifier.Id);

                //appel au WS pour mettre à jour les infos du client
                wsClient.updateClientCompleted += Ws_client_update_clientCompleted;
                wsClient.updateClientAsync(clientAModifier);
            }
           
        }

        private void Ws_client_update_clientCompleted(object sender, updateClientCompletedEventArgs e)
        {
            if (e.Result.ToString() == "True")
            {
                MessageBox.Show("Modification effectuée");
                afficheLesClients();
            }
            else
            {
                MessageBox.Show("Erreur pendant la modification");
            } 
            wsClient.updateClientCompleted -= Ws_client_update_clientCompleted;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void FormClient_Load(object sender, EventArgs e)
        {

        }

        private void labelAdr_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
