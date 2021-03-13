using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using OdvozOtpada.Models;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.Layout.Borders;
using iText.Kernel.Font;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using System.IO;

namespace OdvozOtpada.Controllers
{
    public class HomeController : Controller
    {
        private ModelsContext db = new ModelsContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> RasporedOdvoza()
        {
            var rasporedodvoza = await db.rasporedodvoza.Include(r => r.otpad).Include(r => r.ulica).ToListAsync();
            FiltrirajPretraživanje filtrirajPretraživanje = new FiltrirajPretraživanje();

            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad");
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad");
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica");

            Tuple<List<rasporedodvoza>, FiltrirajPretraživanje> tuple = Tuple.Create(rasporedodvoza, filtrirajPretraživanje);

            return View("~/Views/Home/RasporedOdvoza.cshtml", tuple);
        }

        [HttpGet]
        public JsonResult GradChanged(int idGrad)
        {
            var data = (from c in db.ulica where c.idGrada == idGrad select c);

            return Json(new SelectList(data.ToArray(), "idUlica", "imeUlica"), JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> FiltriranjeRasporeda([Bind(Include = "tekstPretraživanja,otpad,grad,ulica,dan")] FiltrirajPretraživanje rez)
        {
            if (rez.tekstPretraživanja != null)
            {
                List<rasporedodvoza> rasporedodvoza = new List<rasporedodvoza>();

                rasporedodvoza = await (from c in db.rasporedodvoza
                                        where c.otpad.vrstaOtpad.Contains(rez.tekstPretraživanja) ||
                        c.danTjednaOdvoza.Contains(rez.tekstPretraživanja) || c.ulica.imeUlica.Contains(rez.tekstPretraživanja)
                        || c.grad.imeGrad.Contains(rez.tekstPretraživanja) || c.vrijemeOdvoza.Contains(rez.tekstPretraživanja)
                                        select c).ToListAsync();

                return PartialView("~/Views/Home/RasporedOdvozaList.cshtml", rasporedodvoza);
            }
            else
            {
                List<rasporedodvoza> rasporedodvoza = new List<rasporedodvoza>();

                //svi odabrani
                if (rez.dan != null && rez.grad != null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idUlice.ToString() == (rez.ulica) && c.idGrad.ToString() == (rez.grad) &&
                c.idVrsteOtpada.ToString() == (rez.otpad) && c.danTjednaOdvoza.Equals(rez.dan)
                                            select c).ToListAsync();

                }
                //nijedan odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza select c).ToListAsync();
                }
                //svi odabrani osim prvog
                else if (rez.dan == null && rez.grad != null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idGrad.ToString() == (rez.grad) &&
                c.idVrsteOtpada.ToString() == (rez.otpad) && c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //svi odabrani osim drugog
                else if (rez.dan != null && rez.grad == null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idVrsteOtpada.ToString() == (rez.otpad) && c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //svi odabrani osim trećeg
                else if (rez.dan != null && rez.grad != null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idGrad.ToString() == (rez.grad) && c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //svi odabrani osim četvrtog
                else if (rez.dan != null && rez.grad != null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idVrsteOtpada.ToString() == (rez.otpad) && c.idGrad.ToString() == (rez.grad)
                                            select c).ToListAsync();
                }
                //1 i 2 odabrani
                else if (rez.dan == null && rez.grad == null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idVrsteOtpada.ToString() == (rez.otpad) &&
                c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //1 i 3 odabrani
                else if (rez.dan == null && rez.grad != null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idGrad.ToString() == (rez.grad) &&
                c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //1 i 4 odabrani
                else if (rez.dan == null && rez.grad != null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idGrad.ToString() == (rez.grad) &&
                c.idVrsteOtpada.ToString() == (rez.otpad)
                                            select c).ToListAsync();
                }
                //2 i 3 odabrani
                else if (rez.dan != null && rez.grad == null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                //2 i 4 odabrani
                else if (rez.dan != null && rez.grad == null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idVrsteOtpada.ToString() == (rez.otpad)
                                            select c).ToListAsync();
                }
                //3 i 4 odabrani
                else if (rez.dan != null && rez.grad != null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan) &&
                c.idGrad.ToString() == (rez.grad)
                                            select c).ToListAsync();
                }
                //1 odabran
                else if (rez.dan != null && rez.grad == null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.danTjednaOdvoza.Equals(rez.dan)
                                            select c).ToListAsync();
                }
                //2 odabran
                else if (rez.dan == null && rez.grad != null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idGrad.ToString() == (rez.grad)
                                            select c).ToListAsync();
                }
                // 3 odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idVrsteOtpada.ToString() == (rez.otpad)
                                            select c).ToListAsync();
                }
                //4 odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = await (from c in db.rasporedodvoza
                                            where c.idUlice.ToString() == (rez.ulica)
                                            select c).ToListAsync();
                }
                return PartialView("~/Views/Home/RasporedOdvozaList.cshtml", rasporedodvoza);
            }
        }

        private List<rasporedodvoza> PretragaRasporedaOdvoza(FiltrirajPretraživanje rez)
        {
            if (rez.tekstPretraživanja != null)
            {
                List<rasporedodvoza> rasporedodvoza = new List<rasporedodvoza>();

                rasporedodvoza = (from c in db.rasporedodvoza
                                       where c.otpad.vrstaOtpad.Contains(rez.tekstPretraživanja) ||
                       c.danTjednaOdvoza.Contains(rez.tekstPretraživanja) || c.ulica.imeUlica.Contains(rez.tekstPretraživanja)
                       || c.grad.imeGrad.Contains(rez.tekstPretraživanja) || c.vrijemeOdvoza.Contains(rez.tekstPretraživanja)
                                       select c).ToList();

                return rasporedodvoza;
            }
            else
            {
                List<rasporedodvoza> rasporedodvoza = new List<rasporedodvoza>();

                //svi odabrani
                if (rez.dan != null && rez.grad != null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idUlice.ToString() == (rez.ulica) && c.idGrad.ToString() == (rez.grad) &&
               c.idVrsteOtpada.ToString() == (rez.otpad) && c.danTjednaOdvoza.Equals(rez.dan)
                                           select c).ToList();

                }
                //nijedan odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza select c).ToList();
                }
                //svi odabrani osim prvog
                else if (rez.dan == null && rez.grad != null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idGrad.ToString() == (rez.grad) &&
               c.idVrsteOtpada.ToString() == (rez.otpad) && c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //svi odabrani osim drugog
                else if (rez.dan != null && rez.grad == null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idVrsteOtpada.ToString() == (rez.otpad) && c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //svi odabrani osim trećeg
                else if (rez.dan != null && rez.grad != null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idGrad.ToString() == (rez.grad) && c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //svi odabrani osim četvrtog
                else if (rez.dan != null && rez.grad != null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idVrsteOtpada.ToString() == (rez.otpad) && c.idGrad.ToString() == (rez.grad)
                                           select c).ToList();
                }
                //1 i 2 odabrani
                else if (rez.dan == null && rez.grad == null && rez.otpad != null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idVrsteOtpada.ToString() == (rez.otpad) &&
               c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //1 i 3 odabrani
                else if (rez.dan == null && rez.grad != null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idGrad.ToString() == (rez.grad) &&
               c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //1 i 4 odabrani
                else if (rez.dan == null && rez.grad != null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idGrad.ToString() == (rez.grad) &&
               c.idVrsteOtpada.ToString() == (rez.otpad)
                                           select c).ToList();
                }
                //2 i 3 odabrani
                else if (rez.dan != null && rez.grad == null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                //2 i 4 odabrani
                else if (rez.dan != null && rez.grad == null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idVrsteOtpada.ToString() == (rez.otpad)
                                           select c).ToList();
                }
                //3 i 4 odabrani
                else if (rez.dan != null && rez.grad != null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan) &&
               c.idGrad.ToString() == (rez.grad)
                                           select c).ToList();
                }
                //1 odabran
                else if (rez.dan != null && rez.grad == null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.danTjednaOdvoza.Equals(rez.dan)
                                           select c).ToList();
                }
                //2 odabran
                else if (rez.dan == null && rez.grad != null && rez.otpad == null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idGrad.ToString() == (rez.grad)
                                           select c).ToList();
                }
                // 3 odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad != null && rez.ulica == null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idVrsteOtpada.ToString() == (rez.otpad)
                                           select c).ToList();
                }
                //4 odabran
                else if (rez.dan == null && rez.grad == null && rez.otpad == null && rez.ulica != null)
                {
                    rasporedodvoza = (from c in db.rasporedodvoza
                                           where c.idUlice.ToString() == (rez.ulica)
                                           select c).ToList();
                }
                return rasporedodvoza;
            }
        }

        private static Table CreateTable(List<rasporedodvoza> rasporedodvozas)
        {
            List<rasporedodvoza> rasporedodvoza = rasporedodvozas;

            PdfFont bold = PdfFontFactory.CreateFont(StandardFonts.TIMES_BOLD, "Cp1250", true);
            PdfFont regular = PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN, "Cp1250", true);

            Table table = new Table(new float[5]).UseAllAvailableWidth();


            Cell cell1 = new Cell().Add(new Paragraph("Vrsta otpada"));
            cell1.SetBorder(new SolidBorder(2));
            cell1.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            cell1.SetFont(bold);
            table.AddCell(cell1);
            Cell cell2 = new Cell().Add(new Paragraph("Grad"));
            cell2.SetBorder(new SolidBorder(2));
            cell2.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            cell2.SetFont(bold);
            table.AddCell(cell2);
            Cell cell3 = new Cell().Add(new Paragraph("Ulica"));
            cell3.SetBorder(new SolidBorder(2));
            cell3.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            cell3.SetFont(bold);
            table.AddCell(cell3);
            //Cell cell4 = new Cell().Add(new Paragraph("Dan odvoza"));
            //cell4.SetBorder(new SolidBorder(2));
            //cell4.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            //cell4.SetFont(bold);
            //table.AddCell(cell4);
            Cell cell11 = new Cell().Add(new Paragraph("Datum odvoza"));
            cell11.SetBorder(new SolidBorder(2));
            cell11.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            cell11.SetFont(bold);
            table.AddCell(cell11);
            Cell cell5 = new Cell().Add(new Paragraph("Vrijeme odvoza"));
            cell5.SetBorder(new SolidBorder(2));
            cell5.SetBackgroundColor(new DeviceRgb(140, 150, 8));
            cell5.SetFont(bold);
            table.AddCell(cell5);
            foreach (rasporedodvoza item in rasporedodvoza)
            {
                Cell cell6 = new Cell().Add(new Paragraph(item.otpad.vrstaOtpad));
                cell6.SetBorder(new SolidBorder(2));
                cell6.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                cell6.SetFont(regular);
                table.AddCell(cell6);
                Cell cell7 = new Cell().Add(new Paragraph(item.grad.imeGrad));
                cell7.SetBorder(new SolidBorder(2));
                cell7.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                cell7.SetFont(regular);
                table.AddCell(cell7);
                Cell cell8 = new Cell().Add(new Paragraph(item.ulica.imeUlica));
                cell8.SetBorder(new SolidBorder(2));
                cell8.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                cell8.SetFont(regular);
                table.AddCell(cell8);
                //Cell cell9 = new Cell().Add(new Paragraph(item.danTjednaOdvoza));
                //cell9.SetBorder(new SolidBorder(2));
                //cell9.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                //cell9.SetFont(regular);
                //table.AddCell(cell9);
                Cell cell12 = new Cell().Add(new Paragraph(item.datumOdvoza));
                cell12.SetBorder(new SolidBorder(2));
                cell12.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                cell12.SetFont(regular);
                table.AddCell(cell12);
                Cell cell10 = new Cell().Add(new Paragraph(item.vrijemeOdvoza));
                cell10.SetBorder(new SolidBorder(2));
                cell10.SetBackgroundColor(new DeviceRgb(140, 100, 8));
                cell10.SetFont(regular);
                table.AddCell(cell10);
            }

            return table;
        }

        [HttpPost]
        public void CreatePDF( FiltrirajPretraživanje rezultat)
        {
            Random r = new Random();
            int i = r.Next(1, 100000000);
            string rnd = i.ToString();

            var exportFolder = Server.MapPath("~/PDF-s");
            var exportFile = Path.Combine(exportFolder, rnd + ".pdf");

            var writer = new PdfWriter(exportFile);
            var pdf = new PdfDocument(writer);
            var doc = new Document(pdf);

            Table table = new Table(new float[10]).UseAllAvailableWidth();
            Cell cell = new Cell(1, 10).Add(new Paragraph("Kreirano: " + DateTime.Now.ToString()));
            cell.SetTextAlignment(TextAlignment.CENTER);
            cell.SetPadding(5);
            cell.SetBackgroundColor(new DeviceRgb(140, 200, 150));
            table.AddCell(cell);

            Table table3 = new Table(new float[10]).UseAllAvailableWidth();
            Cell cell4 = new Cell(1, 10).SetBorder(Border.NO_BORDER).Add(new Paragraph(""));
            cell4.SetPadding(5);
            table3.AddCell(cell4);

            Table table2 = new Table(new float[10]).UseAllAvailableWidth(); 
            Cell cell3 = new Cell(1, 10).Add(new Paragraph("Raspored odvoza otpada za trenutni tjedan"));
            cell3.SetTextAlignment(TextAlignment.CENTER);
            cell3.SetPadding(5);
            cell3.SetBackgroundColor(new DeviceRgb(140, 221, 8));
            table2.AddCell(cell3);

            Table table4 = new Table(new float[10]).UseAllAvailableWidth();
            table4.SetVerticalAlignment(VerticalAlignment.BOTTOM);
            Cell cell5 = new Cell(1, 10).Add(new Paragraph("Odvoz otpada d.d."));
            cell5.SetTextAlignment(TextAlignment.CENTER);
            cell5.SetPadding(5);
            cell5.SetBackgroundColor(new DeviceRgb(140, 221, 8));
            table4.AddCell(cell5);

            doc.Add(table4);
            doc.Add(table);
            doc.Add(table3);
            doc.Add(table2);

            doc.Add(CreateTable(PretragaRasporedaOdvoza(rezultat)));

            doc.Close();

            Response.ContentType = "application/pdf";
            Response.Clear();
            Response.AppendHeader("Content-Disposition", "attachment; filename="+rnd+".pdf");
            Response.AppendHeader("Content-Transfer-Encoding", "binary");
            Response.TransmitFile(Server.MapPath("~/PDF-s/"+rnd+".pdf"));
            Response.End();

            if (System.IO.File.Exists(Server.MapPath("~/PDF-s/" + rnd + ".pdf")))
            {
                try
                {
                    System.IO.File.Delete(Server.MapPath("~/PDF-s/" + rnd + ".pdf"));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}