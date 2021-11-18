using ClassLibrary2.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Objets
{
    public class CRubrique
    {
        int _id;
        string _nom;
        string _description;
        int _id_parent;
        List<CRubrique> rubriquesFilles = new List<CRubrique>();

        public int Id
        {
            get
            {
                return this._id;
            }
            set
            {
                this._id = value;
            }
        }

        public String Nom
        {
            get
            {
                return this._nom;
            }
            set
            {
                this._nom = value;
            }
        }

        public String Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        public int Id_Parent
        {
            get
            {
                return this._id_parent;
            }
            set
            {
                this._id_parent = value;
            }
        }

        public List<CRubrique> RubriquesFilles
        {
            get
            {
                return this.rubriquesFilles;
            }
            set
            {
                this.rubriquesFilles = value;
            }
        }

        public CRubrique()
        {
            this._id = 1;
            this._nom = "unset";
        }

        public CRubrique(int _id, String _nom, String _description, int _id_parent)
        {
            this._id = _id;
            this._nom = _nom;
            this._description = _description;
            this._id_parent = _id_parent;
        }
    }
}
