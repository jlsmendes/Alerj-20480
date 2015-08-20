using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Allen20480.Controllers
{
    public class ContatoController : Controller
    {
        //
        // GET: /Contato/
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult EnviaMensagem(string nome, string email, string mensagem)
        {
            System.Threading.Thread.Sleep(5000);

            return Json(new
            {
                Message = "OK"
            });
        }


    }
}

