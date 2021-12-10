using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    /*Recupère tous les articles*/
    [WebMethod]
    public List<CArticles> getTousLesArticles()
    {
        List<CArticles> CArticles = new List<CArticles>();
        CArticles = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().getAll();
        return CArticles;
    }

    /*Modification d'un article*/
    [WebMethod]
    public Boolean updateArticle(CArticles articleModifie)
    {
        //TODO faire la modification d'un article
        Boolean reponse;
        try {
            ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().update(articleModifie);
            reponse = true;
        }
        catch (Exception e){
            reponse = false;
        }
        return reponse;
        
    }

    /*Ajout d'un article*/
    [WebMethod]
    public int addArticle(CArticles articleAAjouter)
    {
        int reponse;
        try
        {
            ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().create(articleAAjouter);
            reponse = 1;
        }
        catch(Exception e)
        {
            reponse = 0;
        }
        return reponse;
    }


    /*Supression d'un article*/
    [WebMethod]
    public Boolean deleteArticle(CArticles articleASupprimer)
    {
        Boolean reponse;
        try
        {
            ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().delete(articleASupprimer);
            reponse = true;
        }
        catch (Exception e)
        {
            reponse = false;
        }
        return reponse;

    }

    //récupère un article dont l'id est précisé en paramètre
    [WebMethod]
    public CArticles findUnArticle(int idArticle)
    {
        CArticles article = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().find(idArticle);
        return article;
    }

    [WebMethod]
    public List<CArticles> findArticleParRubrique(int idRubrique)
    {
        List<CArticles> article = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().findArticleParRubrique(idRubrique);
        return article;
    }


}