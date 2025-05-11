using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BackChat.Models;
using BackChat.Services;

namespace BackChat.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    private readonly PublicationService publicationService;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        publicationService = new PublicationService();
    }

    public IActionResult Index()
    {
        var publications = publicationService.getPublications();
        return View(publications);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Add()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
