using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BibliotecaUniversidad.Data;

namespace BibliotecaUniversidad.Controllers
{
    public class LoginController : Controller
    {
        BibliotecaEntities db = new BibliotecaEntities();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public ActionResult Index(Usuario user)
        {
            var myuser = db.Usuario.FirstOrDefault(u => u.username == user.username
                    && u.pass == user.pass);

            if (myuser != null)    
            {
                return View(user);
            }
            else    
            {
                return View();
            }
            
        }
    }
}