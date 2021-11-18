using ClassLibrary2.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public abstract class CRubriqueDAO : DAO<CRubrique, int>
    {
        public CRubriqueDAO(String connexionString) : base(connexionString) { }

        public override int create(CRubrique obj)
        {
            return 0;
        }

        public List<CRubrique> RecurRubrique(Nullable<int> idR)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            if(idR == null)
            {
                req.CommandText = "select * from rubrique";
            }
            else
            {
                req.CommandText = "select * from rubrique where id_parent = " + idR;
            }
            req.CommandText = "select * from rubrique where id_parent = "+idR;
            OracleDataReader res = req.ExecuteReader();
            List<CRubrique> rubriquesFilles = new List<CRubrique>();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = res["nom"].ToString();
                String description = res["description"].ToString();

                int id_parent;
                if (res["id_parent"].ToString() == "")
                {
                    id_parent = -1;
                }
                else
                {
                    id_parent = int.Parse(res["id_parent"].ToString());
                }

                CRubrique rubrique = new CRubrique(id, nom, description, id_parent);
                rubrique.RubriquesFilles = RecurRubrique(id_parent);
                rubriquesFilles.Add(rubrique);

            }
            res.Close();
            return rubriquesFilles;
        }

        public override List<CRubrique> getAll()
        {
            List<CRubrique> lstAll = RecurRubrique(null);


            /*OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "select * from rubrique";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["id"].ToString());
                String nom = res["nom"].ToString();
                String description = res["description"].ToString();

                int id_parent;
                if (res["id_parent"].ToString() == "")
                {
                    id_parent = -1;
                }
                else
                {
                    id_parent = int.Parse(res["id_parent"].ToString());
                }
               
                lstAll.Add(new CRubrique(id, nom, description, id_parent));
            }
            res.Close();*/


            return lstAll;
        }

        public override Boolean update(CRubrique obj)
        {
            return true;
        }

        public override Boolean delete(CRubrique obj)
        {
            return true;
        }

        public override CRubrique find(int id)
        {
            CRubrique tmp = null;

            return tmp;
        }
    }
}
