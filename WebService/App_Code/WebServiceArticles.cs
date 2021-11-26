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

    /*MModification d'un article*/
    [WebMethod]
    public List<CArticles> updateArticle()
    {
        //TODO faire la modification d'un article
        List<CArticles> CArticles = new List<CArticles>();
        CArticles = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().getAll();
        return CArticles;
    }


    /*Supression d'un article*/
    [WebMethod]
    public List<CArticles> deleteArticle()
    {
        //TODO faire la suppression d'un article
        List<CArticles> CArticles = new List<CArticles>();
        CArticles = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().getAll();
        return CArticles;
    }

    //récupère un article dont l'id est précisé en paramètre
    [WebMethod]
    public CArticles findUnArticle(int idArticle)
    {
        CArticles article = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().find(idArticle);
        return article;
    }

    [WebMethod]
    public List<CArticles> findUnArticleParRubrique(int idRubrique)
    {
        List<CArticles> article = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().findUnArticleParRubrique(idRubrique);
        return article;
    }


}