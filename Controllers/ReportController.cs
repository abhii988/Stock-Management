using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SMS.Data;
using SMS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMS.Controllers
{
    public class ReportController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ReportController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StockListReport([FromQuery] string productname)
        {

            List<ProductStockViewModel> lstData = new List<ProductStockViewModel>();
            if (string.IsNullOrEmpty(productname))
            {

                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "SELECT p.ProductId as ProductId,Name as ProductName,Quantity from Product p inner join Stock ps on ps.StockId=p.ProductId";
                    _context.Database.OpenConnection();
                    using (var result = command.ExecuteReader())
                    {
                        ProductStockViewModel data;
                        while (result.Read())
                        {
                            data = new ProductStockViewModel();
                            data.ProductId = result.GetInt32(0);
                            data.ProductName = result.GetString(1);
                            data.Quantity = result.GetInt32(2);
                            lstData.Add(data);
                        }
                    }
                }
            }
            else
            {
                using (var command = _context.Database.GetDbConnection().CreateCommand())
                {
                    command.CommandText = "SELECT p.ProductId as ProductId,Name as ProductName,Quantity from Product p inner join Stock ps on ps.StockId=p.ProductId where Name='"+ productname+ "'";
                    _context.Database.OpenConnection();
                    using (var result = command.ExecuteReader())
                    {
                        ProductStockViewModel data;
                        while (result.Read())
                        {
                            data = new ProductStockViewModel();
                            data.ProductId = result.GetInt32(0);
                            data.ProductName = result.GetString(1);
                            data.Quantity = result.GetInt32(2);
                            lstData.Add(data);
                        }
                    }
                }
            }
            return View(lstData);

        }
    }
}
