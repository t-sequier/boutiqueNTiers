using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CLigneCommande
    {

        int _numero_commande;
        string _id_article;
        int _qte;
        float _prix_unitaire;
        float _poids;


        public int Numero_commande
        {
            get
            {
                return this._numero_commande;
            }
            set
            {
                this._numero_commande = value;
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

        public float Prix_unitaire
        {
            get
            {
                return this._prix_unitaire;
            }
            set
            {
                this._prix_unitaire = value;
            }
        }

        public float Poids
        {
            get
            {
                return this._poids;
            }
            set
            {
                this._poids = value;
            }
        }

        public CLigneCommande()
        {
            this._numero_commande = 1;
            this._id_article = "unset";
        }

        public CLigneCommande(int _numero_commande, String _id_article, int _qte, float _prix_unitaire, float _poids)
        {
            this._numero_commande = _numero_commande;
            this._id_article = _id_article;
            this._qte = _qte;
            this._prix_unitaire= _prix_unitaire;
            this._poids= _poids;
        }

    }
}
