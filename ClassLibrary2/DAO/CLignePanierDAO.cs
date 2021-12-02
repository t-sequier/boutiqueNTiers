using ClassLibrary2.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public abstract class CLignePanierDAO : DAO<CLignePanier, int>
    {

        public CLignePanierDAO(String connexionString) : base(connexionString) { }

        public override int create(CLignePanier obj)
        {
            try
            {
                OracleCommand reqP = new OracleCommand();
                reqP.Connection = _connex;
                reqP.CommandType = System.Data.CommandType.StoredProcedure;
                reqP.CommandText = "ADDPANIER";

                OracleParameter paramRequeteClient = new OracleParameter("NUM_CLIENT_IN", OracleType.Number);
                paramRequeteClient.Value = obj.Numero_client;

                OracleParameter paramRequeteArticle = new OracleParameter("ID_ARTICLE_IN", OracleType.Number);
                paramRequeteArticle.Value = obj.Id_article;

                OracleParameter paramRequeteQte = new OracleParameter("QUANTITE_IN", OracleType.Number);
                paramRequeteQte.Value = obj.Qte;

                /* ajout des params*/
                reqP.Parameters.Add(paramRequeteClient);
                reqP.Parameters.Add(paramRequeteArticle);
                reqP.Parameters.Add(paramRequeteQte);

                reqP.ExecuteNonQuery();

                return 1;
            }
            catch(Exception e)
            {
                Console.Write(e);
                return 0;
            }
           
        }

        public override List<CLignePanier> getAll()
        {
            List<CLignePanier> lstAll = new List<CLignePanier>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM LIGNE_PANIER";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int numClient = int.Parse(res["NUMERO_CLIENT"].ToString());
                String id_article = (res["ID_ARTICLE"].ToString());
                int qte = int.Parse(res["QUANTITE"].ToString());
                lstAll.Add(new CLignePanier(numClient, id_article, qte));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CLignePanier obj)
        {
            return true;
        }

        public override Boolean delete(CLignePanier obj)
        {
            return true;
        }

        public override CLignePanier find(int id)
        {
            CLignePanier tmp = null;

            return tmp;
        }

    }
}
