using ClassLibrary2.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public abstract class CLigneCommandeDAO : DAO<CLigneCommande, int>
    {

        public CLigneCommandeDAO(String connexionString) : base(connexionString) { }

        public override int create(CLigneCommande obj)
        {
            try
            {
                OracleCommand reqP = new OracleCommand();
                reqP.Connection = _connex;
                reqP.CommandType = System.Data.CommandType.StoredProcedure;
                reqP.CommandText = "panier_to_commande";

                OracleParameter paramRequeteClient = new OracleParameter("NUM_CLIENT_IN", OracleType.Number);
                paramRequeteClient.Value = obj.Numero_commande;

                /* ajout des params*/
                reqP.Parameters.Add(paramRequeteClient);
                
                reqP.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return 0;
            }

        }

        public override List<CLigneCommande> getAll()
        {
            List<CLigneCommande> lstAll = new List<CLigneCommande>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM LIGNE_COMMANDE";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int numClient = int.Parse(res["NUMERO_COMMANDE"].ToString());
                String id_article = (res["ID_ARTICLE"].ToString());
                int qte = int.Parse(res["QUANTITE"].ToString());
                float prix_unitaire = float.Parse(res["PRIX_UNITAIRE"].ToString());
                float poids = float.Parse(res["POIDS"].ToString());
                lstAll.Add(new CLigneCommande(numClient, id_article, qte, prix_unitaire, poids));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CLigneCommande obj)
        {
            return true;
        }

        public override Boolean delete(CLigneCommande obj)
        {
            return true;
        }

        public override CLigneCommande find(int id)
        {
            CLigneCommande tmp = null;

            return tmp;
        }

    }
}
