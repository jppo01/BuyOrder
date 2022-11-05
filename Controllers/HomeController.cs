using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using BuyOrder.Models;
using BuyOrder.Services;
using FastReport;

namespace BuyOrder.Controllers;

public class HomeController : Controller
{

    private readonly IOrderService _orderService;
    private readonly IWebHostEnvironment _webHostEnv;

/*
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

*/
    public HomeController(IWebHostEnvironment webHostEnv, IOrderService orderService)
    {
        _webHostEnv = webHostEnv;
        _orderService = orderService;
    }
        public IActionResult Index()
    {
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

    //Criando template pdf
    [Route("CreateReport")]
    public IActionResult CreateReport(){
        var wayReport = Path.Combine(_webHostEnv.WebRootPath, @"reports/ReportMVC.frx");
        var reportFile = wayReport;
            
        var freport = new FastReport.Report();

        var orderList = _orderService.GetOrders();

        freport.Dictionary.RegisterBusinessObject(orderList, "orderList", 10, true);
        freport.Report.Save(reportFile);
            
        return Ok($"Relatório Gerado: {wayReport}");
        }

}
