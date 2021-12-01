using ClassLibrary1.DAO.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.DAO
{
    public class _CClientDAO : CClientDAO
    {
        public _CClientDAO(String connexionString) : base(connexionString) { }

    }
}
