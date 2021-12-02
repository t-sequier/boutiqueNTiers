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
            return 0;
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
