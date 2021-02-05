using ByteBank.Forum.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ByteBank.Forum.Controllers
{
    public class ContaController : Controller
    {
        //Action para que o user se registre
        public ActionResult Registrar()
        {
            //retornar a pagina que irei construir

            return View();
        }

        //Para receber o post do user
        [HttpPost]
        public ActionResult Registrar(ContaRegistrarViewModel modelo)
        {


            return View();

        }


    }
}
