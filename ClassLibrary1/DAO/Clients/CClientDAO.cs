using ClassLibrary1.Objets;
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
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "INSERT INTO CLIENT(S_ID_CLIENT.nextval,:nom,:prenom,:adresseNum,:adresseRue,:cp,:email,:tel,:civ)";

            req.Parameters.Add(new OracleParameter("nom", obj.Nom));
            req.Parameters.Add(new OracleParameter("prenom", obj.Prenom));
            req.Parameters.Add(new OracleParameter("adresseNum", obj.NumAdr));
            req.Parameters.Add(new OracleParameter("adresseRue", obj.RueAdr));
            req.Parameters.Add(new OracleParameter("cp", obj.Cp));
            req.Parameters.Add(new OracleParameter("email", obj.Email));
            req.Parameters.Add(new OracleParameter("tel", obj.Tel));
            req.Parameters.Add(new OracleParameter("civ", obj.Civ));

            try
            {
                int res = req.ExecuteNonQuery();
                if (res != 0)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return 0;
            }
        }

        //récupère la liste de tous les clients 
        public override List<CClient> getAll()
        {
            List<CClient> lstAll = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CLIENT";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id          = int.Parse(res["numero"].ToString());
                String nom      = (res["nom"].ToString());
                String prenom   = (res["prenom"].ToString());
                String numAdr   = (res["adresse_numero"].ToString());
                String rueAdr   = (res["adresse_rue"].ToString());
                int cp          = int.Parse(res["code_postal"].ToString());
                String email    = (res["email"].ToString());
                String tel      = (res["tel"].ToString());
                int civ         = int.Parse(res["id_civilite"].ToString());

                lstAll.Add(new CClient(id, nom, prenom, numAdr, rueAdr, cp, email, tel, civ));
            }

            res.Close(); //fermeture lecteur BD

            return lstAll;
        }

        //récupère les infos d'un client dont l'id (numero) est précisé en paramètre
        public List<CClient> getUn(int idClient)
        {
            List<CClient> lstUn = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CLIENT WHERE NUMERO =" + idClient;

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["numero"].ToString());
                String nom = (res["nom"].ToString());
                String prenom = (res["prenom"].ToString());
                String numAdr = (res["adresse_numero"].ToString());
                String rueAdr = (res["adresse_rue"].ToString());
                int cp = int.Parse(res["code_postal"].ToString());
                String email = (res["email"].ToString());
                String tel = (res["tel"].ToString());
                int civ = int.Parse(res["id_civilite"].ToString());
                lstUn.Add(new CClient(id, nom, prenom, numAdr, rueAdr, cp, email, tel, civ));
            }
            res.Close(); //fermeture lecteur BD
            return lstUn;
        }

        public override Boolean update(CClient obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "UPDATE Client SET NOM=:nom,PRENOM=:prenom,ADRESSE_NUMERO=:adrnum, ADRESSE_RUE=:adrrue, CODE_POSTAL=:cp, EMAIL=:email, TEL=:tel, ID_CIVILITE=:civ WHERE NUMERO=:numeroClient";
            OracleParameter[] parametres = new OracleParameter[]
            {
                new OracleParameter("nom",obj.Nom),
                new OracleParameter("prenom",obj.Prenom),
                new OracleParameter("adrnum",obj.NumAdr),
                new OracleParameter("adrrue",obj.RueAdr),
                new OracleParameter("cp",obj.Cp),
                new OracleParameter("email",obj.Email),
                new OracleParameter("tel",obj.Tel),
                new OracleParameter("civ",obj.Civ),
                new OracleParameter("numeroClient",obj.Id)
            };
            req.Parameters.AddRange(parametres);

            try
            {
                int res = req.ExecuteNonQuery();
                if (res != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public override Boolean delete(CClient obj)
        {
            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "DELETE FROM CLIENT WHERE NUMERO = " + obj.Id;

            try
            {
                int res = req.ExecuteNonQuery();
                if (res != 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
                return false;
            }
        }

        public override CClient find(int id)
        {
            CClient tmp = null;
            return tmp;
        }

        //récupères les infos sur le client qui se connecte à l'application
        public CClient getConnect(String pNom, String pMail)
        {
            List<CClient> lstUn = new List<CClient>();

            OracleCommand req = new OracleCommand();
            req.Connection = _connex;
            req.CommandText = "SELECT * FROM CLIENT WHERE NOM ='" + pNom + "' AND EMAIL = '" + pMail + "'";

            OracleDataReader res = req.ExecuteReader();
            while (res.Read())
            {
                int id = int.Parse(res["numero"].ToString());
                String nom = (res["nom"].ToString());
                String prenom = (res["prenom"].ToString());
                String numAdr = (res["adresse_numero"].ToString());
                String rueAdr = (res["adresse_rue"].ToString());
                int cp = int.Parse(res["code_postal"].ToString());
                String email = (res["email"].ToString());
                String tel = (res["tel"].ToString());
                int civ = int.Parse(res["id_civilite"].ToString());
                lstUn.Add(new CClient(id, nom, prenom, numAdr, rueAdr, cp, email, tel, civ));
            }
            res.Close(); //fermeture lecteur BD
            return lstUn[0];
        }


    }
}
