using Microsoft.AspNetCore.Mvc;

namespace EstoriasMalucas.Controllers
{
    public class HistoriaController : Controller
    {
        public IActionResult Historia()
        {

            Random num = new Random();
                        
            var historia = "historia"+num.Next(1,4);
            return View(historia);

        }
    }
}
