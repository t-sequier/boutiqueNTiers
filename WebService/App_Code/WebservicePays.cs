using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    //WS
    [WebMethod]
    public List<CPays> getTousLesPays()
    {

        List<CPays> CPays = new List<CPays>();
        CPays = ClassLibrary1.DAO.DAOFactory.getCPaysDAO().getAll();
        return CPays;
    }
}