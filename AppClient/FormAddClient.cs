using AppClient.Webservice;
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
    public partial class FormAddClient : Form
    {
        public FormAddClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //On récupère les valeurs entrés dans le form
            String nom = tbNom.Text;
            String prenom = tbPrenom.Text;
            String numRue = tbNumAdr.Text;
            String rue = tbRue.Text;
            String cp = tbCpAdr.Text; //Code postale devra être int pour insertion
            String email = tbEmail.Text;
            String tel = tbTel.Text;
            //Pour la civilite, on récupère la valeur du radio button selectionné:
            //on créer la variable
            String civ = "";
            //on vérifie si c'est le bouton 1 ou 2 qui a été séléctionné
            //puis on récupère la valeur correspondante
            bool isChecked = radioHomme.Checked;
            if (isChecked) {civ = radioHomme.Text; } else { civ = radioFemme.Text; }

            //On vérifie si tous les champs on été complété (sinon affiche popup avec message erreur)
            if (nom != "" || prenom != "" || numRue != "" || rue != "" || cp != "" || email != "" || tel != "")
            {
                //On vérifie ensuite que le code postal soit bien constitué uniquement de chiffres
                try
                {
                    //Si on peut le parser, c'est qu'il n'y a pas de caractères autre que des chiffres
                    int.Parse(cp);
                }
                catch (Exception)
                {
                    //Si on ne peut pas le parser, on renvoie une erreur
                    MessageBox.Show("Le code postal ne doit contenir que des chiffres, veuillez effectuer les modifications nécessaires",
                        "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //Si on arrive ici, c'est que tout est bon.
                //On créer un nouvel objet client
                CClient newClient = new CClient(nom, prenom, numRue, rue, int.Parse(cp), email, tel);

                //On appelle la méthode du WS qui fait l'insert du nouveau client créé

            }
            else
            {
                //Affiche popup erreur si tous les champs ne sont pas remplis
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            
            //On affiche une popup pour confirmer la création (et on résumes les infos)
            MessageBox.Show("Êtes-vous sûr de vouloir créer un nouveau client avec ses informations ?\n"
                + "(nom : " + nom 
                + ", prenom : " + prenom 
                + ", numRue : " + numRue 
                + ", rue : " + rue 
                + ", cp : " + cp 
                + ", email : " + email 
                + ", tel : " + tel 
                + ", civ : " + civ + ")"
                ,"Infos dev", MessageBoxButtons.YesNo);
        }

    }
}
