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
    public partial class FormArticles : Form
    {
        CClient leClient; //paramètre transmis depuis le form PagePrincipal
        Webservice.WebServiceSoapClient wsClient = new Webservice.WebServiceSoapClient();
        CRubrique[] toutesLesRubriques; //pour le parcours des rubriques
        IDictionary<int, string> rubriques = new Dictionary<int, string>(); //stock les rubriques au format <int idRubrique><String nomRubrique>


        public FormArticles(CClient client)
        {
             InitializeComponent();
             leClient = client;
             


            //appel au WS pour récupérer les rubriques
            wsClient.getToutesLesRubriquesCompleted += Ws_client_getToutesLesRubriquesCompleted;
            wsClient.getToutesLesRubriquesAsync();

            //appel au Ws pour récupérer le panier
            affichePanier();
        }

        

        private void Ws_client_getToutesLesRubriquesCompleted(object sender, getToutesLesRubriquesCompletedEventArgs e)
        {
            TreeNode treeNode;
            treeNode = treeViewInfosArticles.Nodes.Add("ROOT");
            toutesLesRubriques = e.Result;
            getRubriques(treeNode, toutesLesRubriques);
            
            
        }

        /// <summary>
        /// Fonction récursive qui récupère toutes les rubriques. Dès qu'une rubrique fille est rencontrée, la fonction se rappelle
        /// </summary>
        /// <param name="node"></param>
        /// <param name="lesRubriques"></param>
        public void getRubriques(TreeNode node, CRubrique[] lesRubriques)
        {      
            for (int i = 0; i < lesRubriques.Length; i++)
            {
                if (lesRubriques[i].RubriquesFilles.Length == 0)
                {
                    //pas de rubriques filles
                    TreeNode newNode = new TreeNode(lesRubriques[i].Nom.ToString());
                    newNode.Tag = lesRubriques[i].Id.ToString();
                    node.Nodes.Add(newNode);
                }
                else
                {
                    //des rubriques filles
                    TreeNode newNode = new TreeNode(lesRubriques[i].Nom.ToString());
                    newNode.Tag = lesRubriques[i].Id.ToString();
                    node.Nodes.Add(newNode);
                    getRubriques(newNode, lesRubriques[i].RubriquesFilles);                 
                }
                /*remplissage du tableau des rubriques pour les combo box*/
                if (!rubriques.ContainsKey(lesRubriques[i].Id)) {
                    rubriques.Add(lesRubriques[i].Id, lesRubriques[i].Nom);
                }
                

            }
            /*Remplissage des combos box*/ 
            foreach (KeyValuePair<int, String> kvp in rubriques.OrderBy(x => x.Key))
                if (!RubriqueArticleAjouter.Items.Contains(kvp.Key + "-" + kvp.Value)){
                    RubriqueArticleAjouter.Items.Add(kvp.Key + "-" + kvp.Value);
                }
                
                    
        }

        public void rempliArticle(int idRubrique)
        {
            dataGridViewArticles.DataSource = wsClient.findArticleParRubrique(idRubrique);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /*click sur le bouton pour ajouter un article*/
        private void ajoutArticle(object sender, EventArgs e)
        {
            if (NomArticleAjouter.Text == "" || DescriptionArticleAjouter.Text == "" || RubriqueArticleAjouter.SelectedIndex == -1 || PoidsArticleAjouter.Text == "" || PrixArticleAjouter.Text == "" || QuantiteStockArticleAjouter.Text == "") {
                MessageBox.Show("Un où des champs n'ont pas été saisis", "Erreur de champ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else {

                /*essaie de convertir le poids en String en Float*/
                try {
                    float.Parse(PoidsArticleAjouter.Text);

                    if (float.Parse(PoidsArticleAjouter.Text) <= 0)
                    {
                        MessageBox.Show("Le poids entré doit être supérieur à 0", "Erreur sur le poids", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception){
                    PoidsArticleAjouter.Text = "";
                    MessageBox.Show("Le poids entré n'est pas correct", "Erreur sur le poids", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*essaie de convertir le prix en String en Float*/
                try {
                    float.Parse(PrixArticleAjouter.Text);

                    if (float.Parse(PrixArticleAjouter.Text) <= 0)
                    {
                        MessageBox.Show("Le poids entré doit être supérieur à 0", "Erreur sur le poids", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }catch (Exception) {
                    PrixArticleAjouter.Text = "";
                    MessageBox.Show("Le prix entré n'est pas correct", "Erreur sur le prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*essaie de convertir la quantite en String en int*/
                try {
                    int.Parse(QuantiteStockArticleAjouter.Text);

                    if (int.Parse(QuantiteStockArticleAjouter.Text) <= 0)
                    {
                        MessageBox.Show("La quantité à ajouter soit être supérieur à 0", "Erreur sur le poids", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception) {
                    QuantiteStockArticleAjouter.Text = "";
                    MessageBox.Show("La quantité entrée n'est pas correcte", "Erreur sur la quantité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*récupération des infos sur l'article*/
                String nom = NomArticleAjouter.Text;
                String description = DescriptionArticleAjouter.Text;
                String rubrique = (RubriqueArticleAjouter.SelectedItem.ToString());
                int idRubrique = int.Parse(rubrique.Substring(0, rubrique.IndexOf("-")));
                float poids = float.Parse(PoidsArticleAjouter.Text);
                float prix = float.Parse(PrixArticleAjouter.Text);
                int quantite = int.Parse(QuantiteStockArticleAjouter.Text);

                CArticles articleAAjouter = new CArticles(nom, description, idRubrique, poids, prix, quantite);

                /*Appel au WS pour ajouter l'article*/
                wsClient.addArticleCompleted+= Ws_client_addArticleCompleted;
                wsClient.addArticleAsync(articleAAjouter);

                //desactive les boutons
                desactiveBoutons();
            }
        }

        private void Ws_client_addArticleCompleted(object sender, addArticleCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());

            reactiveBoutons();
            wsClient.addArticleCompleted -= Ws_client_addArticleCompleted;
        }

        private void dataGridViewArticles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void treeViewInfosArticles_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag != null)
            {
                rempliArticle(int.Parse(e.Node.Tag.ToString()));
            }
        }

        private void clickSurUnProduit(object sender, DataGridViewCellEventArgs e)
        {
            String nom = "", description = "", idRubrique = "", poids = "", prix = "", quantiteStock = "", id = ""; //pour l'affichage des infos sur un article et sa modification
            foreach (DataGridViewRow row in dataGridViewArticles.SelectedRows)
            {
                id = row.Cells[0].Value.ToString();
                nom  = row.Cells[1].Value.ToString();
                description = row.Cells[2].Value.ToString();
                idRubrique = row.Cells[3].Value.ToString();
                poids = row.Cells[4].Value.ToString();
                prix = row.Cells[5].Value.ToString();
                quantiteStock = row.Cells[6].Value.ToString();
                //MessageBox.Show(nom.ToString(),description.ToString()+" "+idRubrique.ToString()+" "+poids.ToString()+" "+prix.ToString()+" "+quantiteStock.ToString());
            }
            IdModifArticle.Text = id;
            NomArticleModif.Text = nom;
            DescriptionArticleModif.Text = description;
            RubriqueArticleModif.Text = idRubrique;
            PoidsArticleModif.Text = poids;
            PrixArticleModif.Text = prix;
            QuantiteStockArticleModif.Text = quantiteStock;
        }

        /*Lors du clic sur le bouton pour modifier un article*/
        private void BoutonModiferArticle_Click(object sender, EventArgs e)
        {
            //vérification que tous les champs sont rentrés
            if (NomArticleModif.Text == "" || DescriptionArticleModif.Text == "" || RubriqueArticleModif.Text == "" || PoidsArticleModif.Text == "" || PrixArticleModif.Text == "" || QuantiteStockArticleModif.Text == "") {
                MessageBox.Show("Tous les champs doivent être remplis","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else if (IdModifArticle.Text == "")
            {
                MessageBox.Show("Impossible de modifier cet article", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {

                /*essaie de convertir le poids en String en Float*/
                try
                {
                    float.Parse(PoidsArticleAjouter.Text);
                }
                catch (Exception)
                {
                    PoidsArticleAjouter.Text = "";
                    MessageBox.Show("Le poids entré n'est pas correct", "Erreur sur le poids", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*essaie de convertir le prix en String en Float*/
                try
                {
                    float.Parse(PrixArticleAjouter.Text);
                }
                catch (Exception)
                {
                    PrixArticleAjouter.Text = "";
                    MessageBox.Show("Le prix entré n'est pas correct", "Erreur sur le prix", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                /*essaie de convertir le poids en String en int*/
                try
                {
                    int.Parse(QuantiteStockArticleAjouter.Text);
                }
                catch (Exception)
                {
                    QuantiteStockArticleAjouter.Text = "";
                    MessageBox.Show("La quantité entrée n'est pas correcte", "Erreur sur la quantité", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;

                }

                /*création d'un objet CArticle si pas d'erreur dans les try catch*/
                int id = int.Parse(IdModifArticle.Text);
                String nom = NomArticleModif.Text;
                String description = DescriptionArticleModif.Text;
                int idRubrique = int.Parse(RubriqueArticleModif.Text);
                float poids = float.Parse(PoidsArticleModif.Text);
                float prix = float.Parse(PrixArticleModif.Text);
                int quantite = int.Parse(QuantiteStockArticleModif.Text);

                CArticles articleModifie = new CArticles(id, nom, description, idRubrique, poids, prix, quantite);

                //appel au WS pour mettre à jour l'article
                wsClient.updateArticleCompleted += Ws_client_updateArticleCompleted;
                wsClient.updateArticleAsync(articleModifie);

                desactiveBoutons();
            }

        }

        private void Ws_client_updateArticleCompleted(object sender, updateArticleCompletedEventArgs e)
        {
            MessageBox.Show(e.Result.ToString());
            reactiveBoutons();
            wsClient.updateArticleCompleted -= Ws_client_updateArticleCompleted;
        }

        
        /*Lors du click pour supprimer un article*/
        private void BoutonSupprimerArticle_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Supprimer l'article ?", "Supression", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                //vérification que tous les champs sont remplis (on vérifie qu'un article soit séléctionné)
                if (NomArticleModif.Text == "" && DescriptionArticleModif.Text == "" && RubriqueArticleModif.Text == "" && PoidsArticleModif.Text == "" && PrixArticleModif.Text == "" && QuantiteStockArticleModif.Text == "")
                {
                    MessageBox.Show("Sélectionnez un article", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (IdModifArticle.Text == "")
                {
                    MessageBox.Show("Impossible de supprimer cet article", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    /*création d'un objet CArticle*/
                    int id = int.Parse(IdModifArticle.Text);
                    String nom = NomArticleModif.Text;
                    String description = DescriptionArticleModif.Text;
                    int idRubrique = int.Parse(RubriqueArticleModif.Text);
                    float poids = float.Parse(PoidsArticleModif.Text);
                    float prix = float.Parse(PrixArticleModif.Text);
                    int quantite = int.Parse(QuantiteStockArticleModif.Text);

                    CArticles articleSupprime = new CArticles(id, nom, description, idRubrique, poids, prix, quantite);

                    //appel au WS pour mettre à jour l'article
                    wsClient.deleteArticleCompleted += Ws_client_deleteArticleCompleted;
                    desactiveBoutons();
                    wsClient.deleteArticleAsync(articleSupprime);
                }
            }
        }

        private void Ws_client_deleteArticleCompleted(object sender, deleteArticleCompletedEventArgs e)
        {
            if (e.Result.ToString() == "True")
            {
                MessageBox.Show("L'article a été supprimé");
                IdModifArticle.Text = "";
                NomArticleModif.Text = "";
                DescriptionArticleModif.Text = "";
                RubriqueArticleModif.Text = "";
                PoidsArticleModif.Text = "";
                PrixArticleModif.Text = "";
                QuantiteStockArticleModif.Text = "";
            }
            else
            {
                MessageBox.Show("L'article n'a pas pu être supprimé");
            }
            wsClient.deleteArticleCompleted -= Ws_client_deleteArticleCompleted;
            reactiveBoutons();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        /*Lors du click pour ajouter au panier*/
        private void AjoutPanier(object sender, EventArgs e)
        {
            int quantiteAjoutPanier = int.Parse(QuantiteArticleAjoutPanier.Text);
            string idArticle = IdModifArticle.Text;

            //verif si artiocle choisi
            if (idArticle == "")
            {
                MessageBox.Show("Aucun article sélectionné, Impossible d'ajouter au panier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   //si artiocle bien choisi, alors vérif si quantité > 0
                if (quantiteAjoutPanier <= 0 || quantiteAjoutPanier > 99)
                {
                    MessageBox.Show("La quantité d'ajout doit être supérieur à 0 et inférieur à 99", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int quantiteStock = 0;
                    foreach (DataGridViewRow row in dataGridViewArticles.SelectedRows)
                    {
                        quantiteStock = int.Parse(row.Cells[6].Value.ToString());
                        //MessageBox.Show(nom.ToString(),description.ToString()+" "+idRubrique.ToString()+" "+poids.ToString()+" "+prix.ToString()+" "+quantiteStock.ToString());
                    }

                    //vérif de la quantite en stock
                    if (quantiteStock < quantiteAjoutPanier)
                    {
                        MessageBox.Show("La quantité en stock ne permet pas d'ajouter autant au panier\nAjout imposible.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //article choisi et quantité  > 0 alors appel au Ws pour ajouter au panier
                        wsClient.AddLignePanierCompleted += Ws_client_AddLignePanierCompleted;
                        wsClient.AddLignePanierAsync(leClient.Id, idArticle, quantiteAjoutPanier);

                        desactiveBoutons();
                    }                    
                }
            }
        }

        private void Ws_client_AddLignePanierCompleted(object sender, AddLignePanierCompletedEventArgs e)
        {     
            if (e.Result == 1)
            {
                MessageBox.Show("Ajout dans le panier confirmé");
                affichePanier();
            }
            else
            {
                MessageBox.Show("Ajout dans le panier impossible");
            }
            wsClient.AddLignePanierCompleted -= Ws_client_AddLignePanierCompleted;
            reactiveBoutons();
        }

        //appel au WS pour remplir le panier
        public void affichePanier()
        {
            wsClient.getLignePanierClientCompleted += Ws_client_getLignePanierClientCompleted;
            wsClient.getLignePanierClientAsync(leClient.Id);
        }
        private void Ws_client_getLignePanierClientCompleted(object sender, getLignePanierClientCompletedEventArgs e)
        {
            //remplissage de la gridView du panier
            dataGridViewPanier.DataSource = wsClient.getLignePanierClient(leClient.Id);
        }

        /*Desactive les boutons pendant l'appel au WS (pour éviter les spams sur les boutons)*/
        public void desactiveBoutons()
        {
            buttonAjoutArticle.Enabled = false;
            buttonAjoutPanier.Enabled = false;
            ButtonModiferArticle.Enabled = false;
            ButtonSupprimerArticle.Enabled = false;
        }

        /*réactive les boutons après reception de la réponse du WS*/
        public void reactiveBoutons()
        {
            buttonAjoutArticle.Enabled = true;
            buttonAjoutPanier.Enabled = true;
            ButtonModiferArticle.Enabled = true;
            ButtonSupprimerArticle.Enabled = true;
        }

    }

}
