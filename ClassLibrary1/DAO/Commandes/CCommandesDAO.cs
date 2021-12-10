using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CCommandesDAO : DAO<CCommandes, int>
    {
        public CCommandesDAO(String connexionString) : base(connexionString) { }

        public override int create(CCommandes obj)
        {
            try
            {
                OracleCommand reqP = new OracleCommand();
                reqP.Connection = _connex;
                reqP.CommandType = System.Data.CommandType.StoredProcedure;
                reqP.CommandText = "panier_to_commande";

                OracleParameter paramRequeteClient = new OracleParameter("NUMEROCLIENT", OracleType.Number);
                paramRequeteClient.Value = obj.IdCli;

                OracleParameter p_return = new OracleParameter("return", OracleType.Number);
                p_return.Direction = System.Data.ParameterDirection.ReturnValue;

                /* ajout des params*/
                reqP.Parameters.Add(paramRequeteClient);
                reqP.Parameters.Add(p_return);

                reqP.ExecuteNonQuery();

                return 1;
            }
            catch (Exception e)
            {
                Console.Write(e);
                return 0;
            }
        }

        public override List<CCommandes> getAll()
        {
            List<CCommandes> lstAll = new List<CCommandes>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM COMMANDE";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int idCom = int.Parse(res["numero_commande"].ToString());
                int idCli = int.Parse(res["numero_client"].ToString());
                int idStat = int.Parse(res["id_statut"].ToString());
                int idFP = int.Parse(res["id_frais_port"].ToString());
                lstAll.Add(new CCommandes(idCom, idCli, idStat, idFP));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }
            
        //recupere une commande par son numéro
        public List<CCommandes> getUn(int idCommande)
        {
            List<CCommandes> lstAll = new List<CCommandes>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM COMMANDE WHERE NUMERO_COMMANDE =" + idCommande;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int idCom = int.Parse(res["numero_commande"].ToString());
                int idCli = int.Parse(res["numero_client"].ToString());
                int idStat = int.Parse(res["id_statut"].ToString());
                int idFP = int.Parse(res["id_frais_port"].ToString());
                lstAll.Add(new CCommandes(idCom, idCli, idStat, idFP));


            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        //retourne toutes les commandes d'un client
        public List<CCommandes> getCommandeCompleteClient(int idClient)
        {
            List<CCommandes> lstAll = new List<CCommandes>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM COMMANDE WHERE NUMERO_CLIENT =" + idClient;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int idCom = int.Parse(res["numero_commande"].ToString());
                int idCli = int.Parse(res["numero_client"].ToString());
                int idStat = int.Parse(res["id_statut"].ToString());
                int idFP = int.Parse(res["id_frais_port"].ToString());
                List<CLigneCommande> lignesCommande = getLignesCommandes(idCom);
                lstAll.Add(new CCommandes(idCom, idCli, idStat, idFP, lignesCommande));
            }
            res.Close(); //fermeture lecteur BD

            return lstAll;
        }


        public List<CLigneCommande> getLignesCommandes(int idCommande)
        {
            return DAOFactory.getCLigneCommandeDAO().getByIdCommande(idCommande);
        }

        public override Boolean update(CCommandes obj)
        {
            return true;
        }

        public override Boolean delete(CCommandes obj)
        {
            return true;
        }

        public override CCommandes find(int id)
        {
            CCommandes tmp = null;

            return tmp;
        }
    }
}
