using Microsoft.AspNetCore.Mvc;
using Quantum.Models;
using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using Humanizer;




namespace Quantum.Controllers

{

    public static class BitMapExtension
    {
        public static byte[] ConvertBitMapToByteArray(this  Bitmap bitmap)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                bitmap.Save(ms, ImageFormat.Png);

                return ms.ToArray();
            }

        }
    }


    public class InvitationCardController : Controller
    {

        //public byte[] ImageToArray(System.Drawing.Image imgIn)
        //{
        //    MemoryStream AryIMG = new MemoryStream();

        //    imgIn.Save(AryIMG, System.Drawing.Imaging.ImageFormat.Jpeg);

        //    return AryIMG.ToArray();
        //}





        [HttpGet]
        public IActionResult Card()
        {
           

                return View();
        }



        [HttpPost]
        public IActionResult Card(QRCodeModel thisQR_MDL)
        {
            using (QRCodeGenerator qrGen = new QRCodeGenerator())
            using (QRCodeData qrData = qrGen.CreateQrCode(thisQR_MDL.QRCodetext, QRCodeGenerator.ECCLevel.Q))
            using (QRCode qrCode = new QRCode(qrData))
            {
               Bitmap qrIMG = qrCode.GetGraphic(20);

                byte[] BitArry = qrIMG.ConvertBitMapToByteArray();

                string url = string.Format("data:image/png;base64,{0}", Convert.ToBase64String(BitArry));

                ViewBag.QRCode = url;
            }




            //using (MemoryStream ms = new MemoryStream())
            //{
            //    QRCodeGenerator qrGen = new QRCodeGenerator();
            //    QRCodeData qrData = qrGen.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
            //    QRCode qrCode = new QRCode(qrData);

            //    using (Bitmap qrBitMap = qrCode.GetGraphic(20) )
            //    {
            //        qrBitMap.Save(ms, ImageFormat.Png);
            //        ViewBag.QRCode = "data:image/png;base64," + Convert.ToBase64String(ms.ToArray());


            //      //  ViewBag.QRCode = "data:image/png;base64,";
            //        //ViewBag.QRCode = "123255";
            //    }
            //}



            return View();
        }
    }
}
