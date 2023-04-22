using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Abstractions;
using MVCPractica1.Models;

namespace MVCPractica1.Controllers {
    public class equiposController : Controller {

        private readonly equiposDbContext _equiposDbContext;
        public IActionResult Index() {
            return View();
        }

        //public async Task<IActionResult> Create(Bind("nombre", "descripcion", "tipo_equipo_id", "marca_id","modelo","")) {

        //    return View("Index");
        //}
    }
}
