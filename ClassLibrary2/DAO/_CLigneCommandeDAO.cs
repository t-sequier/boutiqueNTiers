using ClassLibrary2.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.DAO
{
    public class _CLigneCommandeDAO : CLigneCommandeDAO
    {
        public _CLigneCommandeDAO(String connexionString) : base(connexionString) { }
    }
}
