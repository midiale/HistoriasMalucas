using Microsoft.AspNetCore.Mvc;
using EstoriasMalucas.Models;

namespace EstoriasMalucas.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            return View(new Formulario());
           
        }

		[HttpPost]
		public ActionResult Index(Formulario formularioVM)
		{
             TempData["Nome"] = formularioVM.UsuarioName;
            var idade = formularioVM.Idade;
				if (idade >= 18)
				{
                    return RedirectToAction("Formulario", "Home");
                }

                 return RedirectToAction("Menor", "Home");

        }

        public IActionResult Formulario()
        {
            return View(new Formulario());

        }

        [HttpPost]
        public IActionResult Formulario(Formulario formularioVM)
        {
            
            TempData["Amigo1"] = formularioVM.Amigo1;
            TempData["Amigo3"] = formularioVM.Amigo3;
            TempData["Amigo5"] = formularioVM.Amigo5;
            TempData["Amigo7"] = formularioVM.Amigo7;
            TempData["Amigo9"] = formularioVM.Amigo9;
            TempData["Amiga2"] = formularioVM.Amiga2;
            TempData["Amiga4"] = formularioVM.Amiga4;
            TempData["Amiga6"] = formularioVM.Amiga6;
            TempData["Amiga8"] = formularioVM.Amiga8;
            TempData["Amiga10"] = formularioVM.Amiga10;

            if (ModelState.IsValid)

            {
                return RedirectToAction("Historia", "Historia");
            }

            return View();
            
        }

        public IActionResult Menor()
        {
            return View();
        }


    }
}
