using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAO.Client
{
    public abstract class CClientDAO : DAO<CClient, int>
    {

        public CClientDAO(String connexionString) : base(connexionString) { }

        public override int create(CClient obj)
        {
            return 0;
        }

        public override List<CClient> getAll()
        {
            //TODO faire lever une exception 
            List<CClient> lstAll = new List<CClient>();
            return lstAll;
        }

        //récupère les régions d'un pays dont l'id est précisé en paramètre
        public List<CClient> getAll(int idPays)
        {
            List<CClient> lstAll = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM REGION WHERE ID_PAYS =" + idPays;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = (res["nom"].ToString());
                lstAll.Add(new CClient(id, nom));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CClient obj)
        {
            return true;
        }

        public override Boolean delete(CClient obj)
        {
            return true;
        }

        public override CClient find(int id)
        {
            CClient tmp = null;
            return tmp;
        }
    }
}
