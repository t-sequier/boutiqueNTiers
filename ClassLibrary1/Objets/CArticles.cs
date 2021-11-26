using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Objets
{
    public class CArticles
    {
        int id;
        String nom;
        String description;
        int idRubrique;
        float poids;
        float prixUnitaire;
        int quantiteStock;

        /*Accesseurs*/
        public int Id { get { return this.id; } set { this.id = value; } }
        public String Nom { get { return this.nom; } set { this.nom = value; } }
        public String Description { get { return this.description; } set { this.description = value; } }
        public int IdRubrique { get { return this.idRubrique; } set { this.idRubrique = value; } }
        public float Poids { get { return this.poids; } set { this.poids = value; } }
        public float PrixUnitaire { get { return this.prixUnitaire; } set { this.prixUnitaire = value; } }
        public int QuantiteStock { get { return this.quantiteStock; } set { this.poids = quantiteStock; } }

        public CArticles() { this.id = 1; this.nom = "unset";}

        /*Constructeur*/
        public CArticles(int id, String nom, String description, int idRubrique, float poids, float prixUnitaire, int quantiteStock)
        {
            this.id = id;
            this.nom = nom;
            this.description = description;
            this.IdRubrique = idRubrique;
            this.poids = poids;
            this.prixUnitaire = prixUnitaire;
            this.quantiteStock = quantiteStock;
        }
    }
}
