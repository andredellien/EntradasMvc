using EntradasMvc.Models;
using EntradasMvc.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EntradasMvc.Controllers;

public class EntradasController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        var viewModel = new CotizacionInputViewModel();

        return View(viewModel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Calcular(CotizacionInputViewModel viewModel)
    {
        if (!ModelState.IsValid)
        {
            return View("Index", viewModel);
        }

        return Content(
            $"Cliente: {viewModel.Cliente} - Cantidad: {viewModel.Cantidad}");
    }
}
