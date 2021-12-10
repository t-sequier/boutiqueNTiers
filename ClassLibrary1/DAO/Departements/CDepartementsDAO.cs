using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CDepartementsDAO : DAO<CDepartements, int>
    {
        public CDepartementsDAO(String connexionString) : base(connexionString) { }

        public override int create(CDepartements obj)
        {
            return 0;
        }

        public override List<CDepartements> getAll()
        {
            //TODO faire lever une exception 
            List<CDepartements> lstAll = new List<CDepartements>();
            return lstAll;
        }

        //récupère les régions d'un pays dont l'id est précisé en paramètre
        public List<CDepartements> getAll(int idRegion)
        {
            List<CDepartements> lstAll = new List<CDepartements>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            //Enchainement de simple cotes/doubles cotes car c'est une chaine de charactères dans la table, pas un int
            req.CommandText = "SELECT * FROM DEPARTEMENT WHERE ID_REGION = '" + idRegion + "'";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["numero"].ToString());
                String nom = (res["nom"].ToString());
                lstAll.Add(new CDepartements(id, nom));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CDepartements obj)
        {
            return true;
        }

        public override Boolean delete(CDepartements obj)
        {
            return true;
        }

        public override CDepartements find(int id)
        {
            CDepartements tmp = null;
            return tmp;
        }
    }
}
