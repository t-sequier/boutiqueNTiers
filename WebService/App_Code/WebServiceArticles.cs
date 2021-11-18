using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{

    [WebMethod]
    public List<CArticles> getTousLesArticles()
    {
        List<CArticles> CArticles = new List<CArticles>();
        CArticles = ClassLibrary1.DAO.DAOFactory.getCArticlesDAO().getAll();
        return CArticles;
    }
   
}