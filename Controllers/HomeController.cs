using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using workshop240926.Models;

namespace workshop240926.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        // 今日の日付を取得するViewDataオブジェクトを作成
        ViewData["Today"] = DateTime.Now.ToString("yyyy/MM/dd");
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
