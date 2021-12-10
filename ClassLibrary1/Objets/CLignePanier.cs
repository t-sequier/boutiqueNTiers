using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CLignePanier
    {
        int _numero_client;
        string _id_article;
        int _qte;



        public int Numero_client
        {
            get
            {
                return this._numero_client;
            }
            set
            {
                this._numero_client = value;
            }
        }

        public String Id_article
        {
            get
            {
                return this._id_article;
            }
            set
            {
                this._id_article = value;
            }
        }

        public int Qte
        {
            get
            {
                return this._qte;
            }
            set
            {
                this._qte = value;
            }
        }

        public CLignePanier()
        {
            this._numero_client = 1;
            this._id_article = "unset";
        }

        public CLignePanier(int _numero_client, String _id_article, int _qte)
        {
            this._numero_client = _numero_client;
            this._id_article = _id_article;
            this._qte = _qte;
        }
    }
}
