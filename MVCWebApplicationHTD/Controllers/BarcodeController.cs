using Microsoft.AspNetCore.Mvc;
using System.Drawing.Imaging;
using System.Drawing;

namespace MVCWebApplicationHTD.Controllers
{
    public class BarcodeController : Controller
    {
        [HttpGet]
        public IActionResult GenerateBarCode()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GenerateBarCode(string barcode)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (Bitmap bitMap = new Bitmap(barcode.Length * 40, 80))
                {
                    using (Graphics graphics = Graphics.FromImage(bitMap))
                    {
                        Font oFont = new Font("IDAutomationHC39M", 16);
                        PointF point = new PointF(2f, 2f);
                        SolidBrush whiteBrush = new SolidBrush(Color.White);
                        graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                        SolidBrush blackBrush = new SolidBrush(Color.DarkBlue);
                        graphics.DrawString("*" + barcode + "*", oFont, blackBrush, point);
                    }
                    bitMap.Save(memoryStream, ImageFormat.Jpeg);
                    ViewBag.BarcodeImage = "data:image/png;base64," + Convert.ToBase64String(memoryStream.ToArray());
                }
            }
            return View();
        }
        public ActionResult BarCodeRead()
        {
            return View();
        }

    }
}
