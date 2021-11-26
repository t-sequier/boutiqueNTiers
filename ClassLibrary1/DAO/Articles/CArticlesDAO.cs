using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CArticlesDAO : DAO<CArticles, int>
    {
        public CArticlesDAO(String connexionString) : base(connexionString) { }

        public override int create(CArticles obj)
        {
            return 0;
        }


        public override List<CArticles> getAll()
        {
            List<CArticles> lstAll = new List<CArticles>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM Article";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = (res["nom"].ToString());
                String description = (res["description"].ToString());
                int idRubrique = int.Parse(res["id_rubrique"].ToString());
                float poids = float.Parse(res["poids"].ToString());
                float prixUnitaire = float.Parse(res["prix_unitaire"].ToString());
                int quantiteStock = int.Parse(res["quantite_stock"].ToString());
                lstAll.Add(new CArticles(id, nom,description,idRubrique,poids,prixUnitaire,quantiteStock));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }


        public override Boolean update(CArticles obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "UPDATE Article SET (NOM, ID_RUBRIQUE, POIDS, PRIX_UNITAIRE, QUANTITE_STOCK) = "+""+"WHERE ID = " + obj.Id;

            try
            {
                req.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public List<CArticles> findUnArticleParRubrique(int idRubrique)
        {
            List<CArticles> lstAll = new List<CArticles>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM ARTICLE WHERE ID_RUBRIQUE =" + idRubrique;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = (res["nom"].ToString());
                String description = (res["description"].ToString());
                int idRub = int.Parse(res["id_rubrique"].ToString());
                float poids = float.Parse(res["poids"].ToString());
                float prixUnitaire = float.Parse(res["prix_unitaire"].ToString());
                int quantiteStock = int.Parse(res["quantite_stock"].ToString());
                lstAll.Add(new CArticles(id, nom, description, idRub, poids, prixUnitaire, quantiteStock));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;


        }


        public override Boolean delete(CArticles obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "Delete * FROM Article WHERE ID = " + obj.Id;

            try {
                req.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }


        public override CArticles find(int id)
        {
            CArticles tmp = null;

            return tmp;
        }
    }
}
