using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAO
{
    public class _CLignePanierDAO : CLignePanierDAO
    {
        public _CLignePanierDAO(String connexionString) : base(connexionString) { }

        
    }
}
