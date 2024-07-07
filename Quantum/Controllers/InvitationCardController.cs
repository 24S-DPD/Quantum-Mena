using Microsoft.AspNetCore.Mvc;
using Quantum.Models;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using Microsoft.AspNetCore.Html;





namespace Quantum.Controllers

{

    //public static class BitMapExtension
    //{
    //    public static byte[] ConvertBitMapToByteArray(this  Bitmap bitmap)
    //    {
    //        using (MemoryStream ms = new MemoryStream())
    //        {
    //            bitmap.Save(ms, ImageFormat.Png);

    //            return ms.ToArray();
    //        }

    //    }
    //}


    public class InvitationCardController : Controller
    {


        [HttpGet]
        public IActionResult Card(string strEventName, string strEventGUID)
        {
            QRCodeGenerator qrGen = new QRCodeGenerator();
            QRCodeData qrData = qrGen.CreateQrCode(strEventGUID, QRCodeGenerator.ECCLevel.Q);
            SvgQRCode qrCodeSVG = new SvgQRCode(qrData);

            HtmlString svg = new HtmlString(qrCodeSVG.GetGraphic(10));

            ViewBag.SVG = svg;
            ViewBag.EventName = strEventName;
            ViewBag.GUID = strEventGUID;

            return View();
        }

    }


 }


