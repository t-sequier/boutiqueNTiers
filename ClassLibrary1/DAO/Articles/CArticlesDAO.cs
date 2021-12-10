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
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "INSERT INTO ARTICLE(ID, NOM, DESCRIPTION, ID_RUBRIQUE, POIDS, PRIX_UNITAIRE, QUANTITE_STOCK) VALUES("
                    + "s_id_article.nextval,"
                    + "'" + obj.Nom + "',"
                    + "'" + obj.Description + "',"
                    + "'" + obj.IdRubrique + "',"
                    + "'" + obj.Poids + "',"
                    + "'" + obj.PrixUnitaire + "',"
                    + "'" + obj.QuantiteStock + "')";
           
            try
            {
                int res = req.ExecuteNonQuery();
                if (res != 0) {
                    return 1;
                }
                else
                {
                    return 0;
                }
                
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return 0;
            }
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
            req.CommandText = "UPDATE Article SET NOM='"+obj.Nom+"',DESCRIPTION='"+obj.Description+"' ,ID_RUBRIQUE="+obj.IdRubrique+", POIDS="+obj.Poids+", PRIX_UNITAIRE="+obj.PrixUnitaire+", QUANTITE_STOCK= "+obj.QuantiteStock+" WHERE ID = " + obj.Id;


            try
            {
                int res = req.ExecuteNonQuery();
                if (res != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public List<CArticles> findArticleParRubrique(int idRubrique)
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
            req.CommandText = "DELETE FROM Article WHERE ID = " + obj.Id;

            try {
                int res = req.ExecuteNonQuery();
                if (res != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
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
