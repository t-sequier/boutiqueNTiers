﻿using System;
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

        public CRubrique()
        {
            this._id = 1;
            this._nom = "unset";
        }

        public CRubrique(int _id, String _nom)
        {
            this._id = _id;
            this._nom = _nom;
        }
    }
