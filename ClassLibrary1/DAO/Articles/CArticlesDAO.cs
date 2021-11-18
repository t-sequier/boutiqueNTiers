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
            return true;
        }

        public override Boolean delete(CArticles obj)
        {
            return true;
        }

        public override CArticles find(int id)
        {
            CArticles tmp = null;

            return tmp;
        }
    }
}
