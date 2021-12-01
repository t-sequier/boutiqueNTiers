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
        Webservice.WebServiceSoapClient wsClient = new Webservice.WebServiceSoapClient();
        CRubrique[] toutesLesRubriques;
        CRubrique[] toutesLesRubriquesFilles;

        public FormArticles()
        {
             InitializeComponent();
             


            //appel au WS pour récupérer les rubriques
            wsClient.getToutesLesRubriquesCompleted += Ws_client_getToutesLesRubriquesCompleted;
            wsClient.getToutesLesRubriquesAsync();


        }


        private void Ws_client_getToutesLesRubriquesCompleted(object sender, getToutesLesRubriquesCompletedEventArgs e)
        {
            TreeNode treeNode;
            treeNode = treeViewInfosArticles.Nodes.Add("ROOT");
            toutesLesRubriques = e.Result;
            getRubriques(treeNode, toutesLesRubriques);
            
            
        }

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

            }   
        }

        public void rempliArticle(int idRubrique)
        {
            dataGridViewArticles.DataSource = wsClient.findUnArticleParRubrique(idRubrique);
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
            String nom="", description="", idRubrique="", poids="", prix="", quantiteStock="" ;
            foreach (DataGridViewRow row in dataGridViewArticles.SelectedRows)
            {
                nom  = row.Cells[1].Value.ToString();
                description = row.Cells[2].Value.ToString();
                idRubrique = row.Cells[3].Value.ToString();
                poids = row.Cells[4].Value.ToString();
                prix = row.Cells[5].Value.ToString();
                quantiteStock = row.Cells[6].Value.ToString();
                //MessageBox.Show(nom.ToString(),description.ToString()+" "+idRubrique.ToString()+" "+poids.ToString()+" "+prix.ToString()+" "+quantiteStock.ToString());
            }
            nomArticleModif.Text = nom;
            DescriptionArticleModif.Text = description;
            RubriqueArticleModif.Text = idRubrique;
            PoidsArticleModif.Text = poids;
            PrixArticleModif.Text = prix;
            QuantiteStockArticleModif.Text = quantiteStock;
        }

        private void BoutonModiferArticle_Click(object sender, EventArgs e)
        {
            /*Lors du clic sur le bouton pour modifier un article*/

            //vérification que tous les champs sont rentrés
            if (nomArticleModif.Text == "" || DescriptionArticleModif.Text == "" || RubriqueArticleModif.Text == "" || PoidsArticleModif.Text == "" || PrixArticleModif.Text == "" || QuantiteStockArticleModif.Text == "") {
                MessageBox.Show("Tous les champs doivent être remplis","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }

}
