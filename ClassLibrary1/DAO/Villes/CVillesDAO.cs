using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassLibrary1.DAO
{
    public abstract class CVillesDAO : DAO<CVilles, int>
    {
        public CVillesDAO(String connexionString) : base(connexionString) { }

        public override int create(CVilles obj)
        {
            return 0;
        }

        public override List<CVilles> getAll()
        {
            //TODO faire lever une exception 
            List<CVilles> lstAll = new List<CVilles>();
            return lstAll;
        }

        //récupère les régions d'un pays dont l'id est précisé en paramètre
        public List<CVilles> getAll(int idDepartement)
        {
            List<CVilles> lstAll = new List<CVilles>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            //Enchainement de simple cotes/doubles cotes car c'est une chaine de charactères dans la table, pas un int
            req.CommandText = "SELECT * FROM VILLE WHERE NUMERO_DEPARTEMENT = '" + idDepartement + "'";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["code_postal"].ToString());
                String nom = (res["nom"].ToString());
                lstAll.Add(new CVilles(id, nom));
            }
            res.Close(); //fermeture lecteur BD
            return lstAll;
        }

        public override Boolean update(CVilles obj)
        {
            return true;
        }

        public override Boolean delete(CVilles obj)
        {
            return true;
        }

        public override CVilles find(int id)
        {
            CVilles tmp = null;
            return tmp;
        }
    }
}
