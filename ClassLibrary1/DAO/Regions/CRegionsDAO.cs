using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CRegionsDAO : DAO<CRegions, int>
    {
        public CRegionsDAO(String connexionString) : base(connexionString) { }

        public override int create(CRegions obj)
        {
            return 0;
        }

        public override List<CRegions> getAll()
        {
            //TODO faire lever une exception 
            List<CRegions> lstAll = new List<CRegions>();
            return lstAll;
        }

        //récupère les régions d'un pays dont l'id est précisé en paramètre
        public List<CRegions> getAll(int idPays)
        {
            List<CRegions> lstAll = new List<CRegions>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM REGION WHERE ID_PAYS ="+idPays;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = (res["nom"].ToString());
                lstAll.Add(new CRegions(id, nom));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CRegions obj)
        {
            return true;
        }

        public override Boolean delete(CRegions obj)
        {
            return true;
        }

        public override CRegions find(int id)
        {
            CRegions tmp = null;
            return tmp;
        }
    }
}
