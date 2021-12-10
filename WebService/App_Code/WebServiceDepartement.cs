using ClassLibrary1.Objets;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

public partial class WebService : System.Web.Services.WebService
{
    [WebMethod]
    public List<CDepartements> getTousLesDepartements(int idRegion)
    {
        List<CDepartements> CDepartements = new List<CDepartements>();
        CDepartements = ClassLibrary1.DAO.DAOFactory.getCDepartements().getAll(idRegion);
        return CDepartements;
    }
}