using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TreversalCoreProje.Models;

namespace TreversalCoreProje.Controllers
{
    public class ExcelController : Controller
    {
        public IActionResult Index()
        {
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sayfa1");
            workSheet.Cells[1,1].Value = "Rota";
            workSheet.Cells[1,2].Value = "Rehber";
            workSheet.Cells[1,3].Value = "Kontenjan";

            workSheet.Cells[2,1].Value = "Gürcistan Batum Turu";
            workSheet.Cells[2,2].Value = "Kadir Yıldız";
            workSheet.Cells[2,3].Value = "50";

            workSheet.Cells[3,1].Value = "Sırbistan - Makedonya Turu";
            workSheet.Cells[3,2].Value = "Zeynep Öztürk";
            workSheet.Cells[3,3].Value = "35";

            var bytes = excel.GetAsByteArray();
            return File(bytes,"application/vnd.openxmlformats-officedocument.spreadsheethtml.sheet","dosya1.xlsx");
        }
        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destination.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
            }
            return destinationModels;
        }
    }
}
