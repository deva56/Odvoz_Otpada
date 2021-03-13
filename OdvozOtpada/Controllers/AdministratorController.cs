using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OdvozOtpada.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System.Data.Entity.Infrastructure;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Activities.Debugger;
using System.Activities.Statements;

namespace OdvozOtpada.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class AdministratorController : Controller
    {
        private ModelsContext db = new ModelsContext();
        private ApplicationUserManager _userManager;

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }

        #region Admin paneli
        public ActionResult AdminManagePanel()
        {
            return View("~/Views/Administrator/AdminPaneli/AdminManagePanel.cshtml");
        }
        #endregion

        #region Admin CRUD
        // GET: Administrator
        public async Task<ActionResult> IndexAdmin()
        {
            if (TempData["status"] != null)
            {
                ViewBag.Message = TempData["status"].ToString();
                TempData.Remove("status");
            }

            return View("~/Views/Administrator/Admin/IndexAdmin.cshtml", await db.aspnetusers.ToListAsync());
        }

      
        // GET: Administrator/Create
        public ActionResult CreateAdmin()
        {
            return View("~/Views/Administrator/Admin/CreateAdmin.cshtml");
        }

        // POST: Administrator/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAdmin([Bind(Include = "Username,Password,ConfirmPassword")] RegisterViewModel registerViewModel)
        {
            RegisterViewModel _registerViewModel = new RegisterViewModel { };

            if (ModelState.IsValid)
            {
                var adminMatch = from c in db.aspnetusers where c.UserName.Equals(registerViewModel.Username) select c;

                if (adminMatch.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji admin sa istim imenom.");
                    return View("~/Views/Administrator/Admin/CreateAdmin.cshtml", _registerViewModel);

                }

                var user = new ApplicationUser { UserName = registerViewModel.Username, Email = registerViewModel.Username + "@mail.com" };
                var result = await UserManager.CreateAsync(user, registerViewModel.Password);

                if (result.Succeeded)
                {
                    var roleStore = new RoleStore<IdentityRole>(new ApplicationDbContext());
                    var roleManager = new RoleManager<IdentityRole>(roleStore);
                    await roleManager.CreateAsync(new IdentityRole("Administrator"));
                    await UserManager.AddToRoleAsync(user.Id, "Administrator");

                    await db.SaveChangesAsync();

                    return RedirectToAction("IndexAdmin");

                }
                else
                {
                    List<string> errori = new List<string>();
                    foreach(string errors in result.Errors)
                    {
                        errori.Add(errors);
                    }

                    foreach(string regerror in errori)
                    {
                        ModelState.AddModelError(string.Empty, regerror);
                    }
                }
                return View("~/Views/Administrator/Admin/CreateAdmin.cshtml", _registerViewModel);
            }

            return View("~/Views/Administrator/Admin/CreateAdmin.cshtml", _registerViewModel);
        }

        // GET: Administrator/Edit/5
        public async Task<ActionResult> EditAdmin(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aspnetusers aspnetusers = await db.aspnetusers.FindAsync(id);
            if (aspnetusers == null)
            {
                return HttpNotFound();
            }
            PromijeniLozinku promijeniLozinku = new PromijeniLozinku { adminID = id };
            return View("~/Views/Administrator/Admin/EditAdmin.cshtml", promijeniLozinku);
        }

        // POST: Administrator/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAdmin([Bind(Include = "adminID,StaraLozinka,NovaLozinka,PotvrdiNovuLozinku")] PromijeniLozinku promijeniLozinku)
        {
            if (ModelState.IsValid)
            {
                var user = await db.aspnetusers.FindAsync(promijeniLozinku.adminID);

                if (!string.IsNullOrWhiteSpace(promijeniLozinku.StaraLozinka) && !string.IsNullOrWhiteSpace(promijeniLozinku.NovaLozinka))
                {
                    if (UserManager.PasswordHasher.VerifyHashedPassword(user.PasswordHash, promijeniLozinku.StaraLozinka) == PasswordVerificationResult.Success)
                    {
                        if (UserManager.PasswordHasher.VerifyHashedPassword(user.PasswordHash, promijeniLozinku.NovaLozinka) == PasswordVerificationResult.Success)
                        {
                            ModelState.AddModelError(string.Empty, "Nova i stara lozinka moraju biti različite!");
                            PromijeniLozinku _promijeniLozinku = new PromijeniLozinku();
                            return View("~/Views/Administrator/Admin/EditAdmin.cshtml", _promijeniLozinku);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Stara lozinka nije ispravna!");
                        PromijeniLozinku _promijeniLozinku = new PromijeniLozinku();
                        return View("~/Views/Administrator/Admin/EditAdmin.cshtml", _promijeniLozinku);
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Lozinka ne može sadržavati samo razmak u sebi ili biti prazna!");
                    PromijeniLozinku _promijeniLozinku = new PromijeniLozinku();
                    return View("~/Views/Administrator/Admin/EditAdmin.cshtml", _promijeniLozinku);
                }

                try
                {
                    user.PasswordHash = UserManager.PasswordHasher.HashPassword(promijeniLozinku.NovaLozinka);
                    await db.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (db.aspnetusers.Any(e => e.Id == promijeniLozinku.adminID))
                    {
                        return HttpNotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                //db.Entry(aspnetusers).State = EntityState.Modified;
                //await db.SaveChangesAsync();
                return RedirectToAction("IndexAdmin");
            }
            PromijeniLozinku promijeniLozinku_ = new PromijeniLozinku();
            return View("~/Views/Administrator/Admin/EditAdmin.cshtml", promijeniLozinku_);
        }

        // GET: Administrator/Delete/5
        public async Task<ActionResult> DeleteAdmin(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            aspnetusers aspnetusers = await db.aspnetusers.FindAsync(id);
            if (aspnetusers == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/Admin/DeleteAdmin.cshtml", aspnetusers);
        }

        // POST: Administrator/Delete/5
        [HttpPost, ActionName("DeleteAdmin")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedAdmin(string id)
        {
            aspnetusers aspnetusers = await db.aspnetusers.FindAsync(id);
            
            if(User.Identity.GetUserId() == id)
            {
                TempData["status"] = "Match";
                return RedirectToAction("IndexAdmin");
            }

            db.aspnetusers.Remove(aspnetusers);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexAdmin");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        #endregion

        #region Otpad CRUD
        // GET: otpads
        public async Task<ActionResult> IndexOtpad()
        {
            return View("~/Views/Administrator/Otpad/IndexOtpad.cshtml", await db.otpad.ToListAsync());
        }

        //// GET: otpads/Details/5
        //public async Task<ActionResult> DetailsOtpad(string id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    otpad otpad = await db.otpad.FindAsync(id);
        //    if (otpad == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(otpad);
        //}

        // GET: otpads/Create
        public ActionResult CreateOtpad()
        {
            return View("~/Views/Administrator/Otpad/CreateOtpad.cshtml");
        }

        // POST: otpads/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateOtpad([Bind(Include = "idOtpad,vrstaOtpad")] otpad otpad)
        {
            var rezOtpad = db.otpad.OrderBy(x => x.idOtpad).AsEnumerable().Select(x => x.idOtpad);
            int rezIDInt;

            if (ModelState.IsValid)
            {
                if (rezOtpad.Count() != 0)
                {
                    var otpadMatch = from c in db.otpad where c.vrstaOtpad.Equals(otpad.vrstaOtpad) select c;

                    if (otpadMatch.Count() != 0)
                    {
                        ModelState.AddModelError(string.Empty, "Već postoji otpad sa istim imenom.");
                        return View("~/Views/Administrator/Otpad/CreateOtpad.cshtml", otpad);
                        
                    }

                    var rezID = rezOtpad.Last();

                    rezIDInt = (rezID);
                    rezIDInt++;
                }
                else
                {
                    rezIDInt = 1;
                }

                otpad otpadFinal = new otpad { idOtpad = rezIDInt, vrstaOtpad = otpad.vrstaOtpad };
                db.otpad.Add(otpadFinal);
                await db.SaveChangesAsync();
                return RedirectToAction("IndexOtpad");
            }

            return View("~/Views/Administrator/Otpad/CreateOtpad.cshtml", otpad);
        }

        // GET: otpads/Edit/5
        public async Task<ActionResult> EditOtpad(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            otpad otpad = await db.otpad.FindAsync(int.Parse(id));
            if (otpad == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/Otpad/EditOtpad.cshtml", otpad);
        }

        // POST: otpads/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditOtpad([Bind(Include = "idOtpad,vrstaOtpad")] otpad otpad)
        {
            if (ModelState.IsValid)
            {
                var otpadMatch = from c in db.otpad where c.vrstaOtpad.Equals(otpad.vrstaOtpad) select c;

                if (otpadMatch.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji otpad sa istim imenom.");
                    return View("~/Views/Administrator/Otpad/EditOtpad.cshtml", otpad);

                }

                db.Entry(otpad).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("IndexOtpad");
            }
            return View("~/Views/Administrator/Otpad/EditOtpad.cshtml", otpad);
        }

        // GET: otpads/Delete/5
        public async Task<ActionResult> DeleteOtpad(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            otpad otpad = await db.otpad.FindAsync(int.Parse(id));
            if (otpad == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/Otpad/DeleteOtpad.cshtml", otpad);
        }

        // POST: otpads/Delete/5
        [HttpPost, ActionName("DeleteOtpad")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedOtpad(string id)
        {
            otpad otpad = await db.otpad.FindAsync(int.Parse(id));
            db.otpad.Remove(otpad);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexOtpad");
        }
        #endregion

        #region Adrese CRUD

        // GET: otpads
        public ActionResult IndexAdreseOdvoza()
        {
            return View("~/Views/Administrator/AdreseOdvoza/IndexAdreseOdvoza.cshtml");
        }

        [HttpGet]
        public JsonResult GradChanged(int idGrad)
        {
            var data = (from c in db.ulica where c.idGrada == idGrad select c);

            return Json(new SelectList(data.ToArray(), "idUlica", "imeUlica"), JsonRequestBehavior.AllowGet);
        }

        #region Grad
        // GET: grad
        public async Task<ActionResult> IndexGrad()
        {
            return View("~/Views/Administrator/AdreseOdvoza/Grad/IndexGrad.cshtml", await db.grad.ToListAsync());
        }

        // GET: grad/Create
        public ActionResult CreateGrad()
        {
            return View("~/Views/Administrator/AdreseOdvoza/Grad/CreateGrad.cshtml");
        }

        // POST: grad/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateGrad([Bind(Include = "idGrad,imeGrad")] grad grad)
        {
            var rezGrad = db.grad.OrderBy(x => x.idGrad).AsEnumerable().Select(x => x.idGrad);
            int rezIDInt;

            if (ModelState.IsValid)
            {
                if (rezGrad.Count() != 0)
                {
                    var gradMatch = from c in db.grad where c.imeGrad.Equals(grad.imeGrad) select c;

                    if (gradMatch.Count() != 0)
                    {
                        ModelState.AddModelError(string.Empty, "Već postoji grad sa istim imenom.");
                        return View("~/Views/Administrator/AdreseOdvoza/Grad/CreateGrad.cshtml", grad);

                    }

                    var rezID = rezGrad.Last();

                    rezIDInt = (rezID);
                    rezIDInt++;
                }
                else
                {
                    rezIDInt = 1;
                }

                grad gradFinal = new grad { idGrad = rezIDInt, imeGrad = grad.imeGrad };
                db.grad.Add(gradFinal);
                await db.SaveChangesAsync();
                return RedirectToAction("IndexGrad");
            }

            return View("~/Views/Administrator/AdreseOdvoza/Grad/CreateGrad.cshtml", grad);
        }

        // GET: grad/Edit/5
        public async Task<ActionResult> EditGrad(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            grad grad = await db.grad.FindAsync(int.Parse(id));
            if (grad == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/AdreseOdvoza/Grad/EditGrad.cshtml", grad);
        }

        // POST: grad/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditGrad([Bind(Include = "idGrad,imeGrad")] grad grad)
        {
            if (ModelState.IsValid)
            {
                var gradMatch = from c in db.grad where c.imeGrad.Equals(grad.imeGrad) select c;

                if (gradMatch.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji grad sa istim imenom.");
                    return View("~/Views/Administrator/AdreseOdvoza/Grad/EditGrad.cshtml", grad);

                }

                db.Entry(grad).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("IndexGrad");
            }
            return View("~/Views/Administrator/AdreseOdvoza/Grad/EditGrad.cshtml", grad);
        }

        // GET: grad/Delete/5
        public async Task<ActionResult> DeleteGrad(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            grad grad = await db.grad.FindAsync(int.Parse(id));
            if (grad == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/AdreseOdvoza/Grad/DeleteGrad.cshtml", grad);
        }

        // POST: grad/Delete/5
        [HttpPost, ActionName("DeleteGrad")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedGrad(string id)
        {
            grad grad = await db.grad.FindAsync(int.Parse(id));
            db.grad.Remove(grad);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexGrad");
        }
        #endregion

        #region Ulica
        //Dohvaća sve gradove iz baze te stavlja u listu
        private IEnumerable<string> GetAllTowns()
        {
            List<grad> listaGradova = new List<grad>();
            List<string> listaGradovaString = new List<string>();

            var rez = from c in db.grad select c;
            listaGradova = rez.ToList();

            foreach (grad element in listaGradova)
            {
                listaGradovaString.Add(element.imeGrad.ToString());
            }

            return listaGradovaString;
        }

        // Metoda koja svaki item iz IEnumerable liste pretvara u List item
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            List<SelectListItem> selectList = new List<SelectListItem>();

            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }

        // GET: ulica
        public async Task<ActionResult> IndexUlica()
        {
            //var ulica = db.ulica.Include(u => u.grad);
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/IndexUlica.cshtml", await db.ulica.ToListAsync());
        }

        // GET: ulica/Create
        public ActionResult CreateUlica()
        {
            ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/CreateUlica.cshtml");
        }

        // POST: ulica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateUlica([Bind(Include = "idUlica,imeUlica,idGrada")] ulica ulica)
        {
            var rezUlica = db.ulica.OrderBy(x => x.idUlica).AsEnumerable().Select(x => x.idUlica);
            int rezIDInt;

            if (ModelState.IsValid)
            {
                if (rezUlica.Count() != 0)
                {
                    var ulicaMatch = from c in db.ulica where c.imeUlica.Equals(ulica.imeUlica) && c.idGrada == ulica.idGrada select c;

                    if (ulicaMatch.Count() != 0)
                    {
                        ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
                        ModelState.AddModelError(string.Empty, "Već postoji ulica sa istim imenom za taj grad u bazi.");
                        return View("~/Views/Administrator/AdreseOdvoza/Ulica/CreateUlica.cshtml", ulica);

                    }

                    var rezID = rezUlica.Last();

                    rezIDInt = (rezID);
                    rezIDInt++;
                }
                else
                {
                    rezIDInt = 1;
                }

                ulica ulicaFinal = new ulica { idUlica = rezIDInt, imeUlica = ulica.imeUlica, idGrada = ulica.idGrada };
                db.ulica.Add(ulicaFinal);
                await db.SaveChangesAsync();
                return RedirectToAction("IndexUlica");
            }

            ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/CreateUlica.cshtml", ulica);
        }

        // GET: ulica/Edit/5
        public async Task<ActionResult> EditUlica(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ulica ulica = await db.ulica.FindAsync(int.Parse(id));
            if (ulica == null)
            {
                return HttpNotFound();
            }
            ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/EditUlica.cshtml", ulica);
        }

        // POST: ulica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditUlica([Bind(Include = "idUlica,imeUlica,idGrada")] ulica ulica)
        {
            if (ModelState.IsValid)
            {
                var ulicaMatch = from c in db.ulica where c.imeUlica.Equals(ulica.imeUlica) && c.idGrada == ulica.idGrada select c;

                if (ulicaMatch.Count() != 0)
                {
                    ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
                    ModelState.AddModelError(string.Empty, "Već postoji ulica sa istim imenom za taj grad u bazi.");
                    return View("~/Views/Administrator/AdreseOdvoza/Ulica/EditUlica.cshtml", ulica);
                }

                db.Entry(ulica).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("IndexUlica");
            }
            ViewBag.idGrada = new SelectList(db.grad, "idGrad", "imeGrad");
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/EditUlica.cshtml", ulica);
        }

        // GET: ulica/Delete/5
        public async Task<ActionResult> DeleteUlica(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ulica ulica = await db.ulica.FindAsync(int.Parse(id));
            if (ulica == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/AdreseOdvoza/Ulica/DeleteUlica.cshtml", ulica);
        }

        // POST: ulica/Delete/5
        [HttpPost, ActionName("DeleteUlica")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedUlica(string id)
        {
            ulica ulica = await db.ulica.FindAsync(int.Parse(id));
            db.ulica.Remove(ulica);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexUlica");
        }
        #endregion
        #endregion

        #region Raspored odvoza CRUD
        [HttpPost]
        public async Task<ActionResult> FiltriranjeRasporedaOdvoza([Bind(Include = "tekstPretraživanja,otpad,grad,ulica,dan")] FiltrirajPretraživanje rez)
        {
            if (rez.tekstPretraživanja != null)
            {
                List<rasporedodvoza> rasporedodvoza = new List<rasporedodvoza>();

                rasporedodvoza = await (from c in db.rasporedodvoza
                                        where c.otpad.vrstaOtpad.Contains(rez.tekstPretraživanja) ||
                        c.danTjednaOdvoza.Contains(rez.tekstPretraživanja) || c.ulica.imeUlica.Contains(rez.tekstPretraživanja)
                        || c.grad.imeGrad.Contains(rez.tekstPretraživanja) || c.vrijemeOdvoza.Contains(rez.tekstPretraživanja)
                                        select c).ToListAsync();

                return PartialView("~/Views/Administrator/RasporedOdvoza/RasporedOdvozaListPartial.cshtml", rasporedodvoza);
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
                return PartialView("~/Views/Administrator/RasporedOdvoza/RasporedOdvozaListPartial.cshtml", rasporedodvoza);
            }
        }

        // GET: rasporedodvozas
        public async Task<ActionResult> IndexRasporedOdvoza()
        {
            //todo -> ovdje je drkano
            var rasporedodvoza = await db.rasporedodvoza.Include(r => r.otpad).Include(r => r.ulica).ToListAsync();
            FiltrirajPretraživanje filtrirajPretraživanje = new FiltrirajPretraživanje();

            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad");
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad");
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica");

            Tuple<List<rasporedodvoza>, FiltrirajPretraživanje> tuple = Tuple.Create(rasporedodvoza, filtrirajPretraživanje);

            return View("~/Views/Administrator/RasporedOdvoza/IndexRasporedOdvoza.cshtml", tuple);
        }

        // GET: rasporedodvozas/Create
        public ActionResult CreateRasporedOdvoza()
        {
            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad");
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad");
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica");
            return View("~/Views/Administrator/RasporedOdvoza/CreateRasporedOdvoza.cshtml");
        }

        // POST: rasporedodvozas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateRasporedOdvoza([Bind(Include = "idRasporedaOdvoza,idVrsteOtpada,idUlice,idGrad,danTjednaOdvoza,datumOdvoza,vrijemeOdvoza")] rasporedodvoza rasporedodvoza)
        {
            var rezRasporedOdvoza = db.rasporedodvoza.OrderBy(x => x.idRasporedaOdvoza).AsEnumerable().Select(x => x.idRasporedaOdvoza);
            int rezIDInt;

            if (ModelState.IsValid)
            {
                var rasporedOdvozaMatch1 = from c in db.rasporedodvoza where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
                                          && c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad) select c;

                var rasporedOdvozaMatch2 = from c in db.rasporedodvoza
                                          where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
              && c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad) && c.danTjednaOdvoza.Equals(rasporedodvoza.danTjednaOdvoza)
                                          select c;

                var rasporedOdvozaMatch3 = from c in db.rasporedodvoza
                                           where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
               && c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad) && c.danTjednaOdvoza.Equals(rasporedodvoza.danTjednaOdvoza)
                                            && c.vrijemeOdvoza.Equals(rasporedodvoza.vrijemeOdvoza) select c;

                if (rasporedOdvozaMatch3.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu taj dan u tjednu u to vrijeme.");
                    ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
                    ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
                    ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
                    return View("~/Views/Administrator/RasporedOdvoza/CreateRasporedOdvoza.cshtml", rasporedodvoza);
                }
                else if (rasporedOdvozaMatch2.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu taj dan u tjednu.");
                    ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
                    ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
                    ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
                    return View("~/Views/Administrator/RasporedOdvoza/CreateRasporedOdvoza.cshtml", rasporedodvoza);
                }
                else if (rasporedOdvozaMatch1.Count() != 0)
                {
                    ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu.");
                    ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
                    ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
                    ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
                    return View("~/Views/Administrator/RasporedOdvoza/CreateRasporedOdvoza.cshtml", rasporedodvoza);
                }

                if (rezRasporedOdvoza.Count() != 0)
                {
                    var rezID = rezRasporedOdvoza.Last();

                    rezIDInt = (rezID);
                    rezIDInt++;
                }
                else
                {
                    rezIDInt = 1;
                }

                string dateTime = DateTime.Now.ToShortDateString();

                rasporedodvoza rasporedOdvozaFinal = new rasporedodvoza
                {
                    idRasporedaOdvoza = rezIDInt,
                    danTjednaOdvoza = rasporedodvoza.danTjednaOdvoza,
                    idGrad = rasporedodvoza.idGrad,
                    idUlice = rasporedodvoza.idUlice,
                    idVrsteOtpada = rasporedodvoza.idVrsteOtpada,
                    vrijemeOdvoza = rasporedodvoza.vrijemeOdvoza,
                    datumOdvoza = rasporedodvoza.datumOdvoza,
                    datumKreiranja = dateTime
                };

                db.rasporedodvoza.Add(rasporedOdvozaFinal);
                await db.SaveChangesAsync();
                return RedirectToAction("IndexRasporedOdvoza");
            }

            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
            return View("~/Views/Administrator/RasporedOdvoza/CreateRasporedOdvoza.cshtml", rasporedodvoza);
        }

        // GET: rasporedodvozas/Edit/5
        public async Task<ActionResult> EditRasporedOdvoza(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rasporedodvoza rasporedodvoza = await db.rasporedodvoza.FindAsync(int.Parse(id));
            if (rasporedodvoza == null)
            {
                return HttpNotFound();
            }
            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
            return View("~/Views/Administrator/RasporedOdvoza/EditRasporedOdvoza.cshtml", rasporedodvoza);
        }

        // POST: rasporedodvozas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditRasporedOdvoza([Bind(Include = "idRasporedaOdvoza,datumKreiranja,idVrsteOtpada,idGrad,idUlice,danTjednaOdvoza,datumOdvoza,vrijemeOdvoza")] rasporedodvoza rasporedodvoza)
        {
            if (ModelState.IsValid)
            {
              //  var rasporedOdvozaMatch1 = from c in db.rasporedodvoza
              //                             where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
              //&& c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad)
              //                             select c;

              //  var rasporedOdvozaMatch2 = from c in db.rasporedodvoza
              //                             where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
              // && c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad) && c.danTjednaOdvoza.Equals(rasporedodvoza.danTjednaOdvoza)
              //                             select c;

              //  var rasporedOdvozaMatch3 = from c in db.rasporedodvoza
              //                             where c.idVrsteOtpada.Equals(rasporedodvoza.idVrsteOtpada)
              // && c.idUlice.Equals(rasporedodvoza.idUlice) && c.idGrad.Equals(rasporedodvoza.idGrad) && c.danTjednaOdvoza.Equals(rasporedodvoza.danTjednaOdvoza)
              //                              && c.vrijemeOdvoza.Equals(rasporedodvoza.vrijemeOdvoza)
              //                             select c;

              //  if (rasporedOdvozaMatch3.Count() != 0)
              //  {
              //      ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu taj dan u tjednu u to vrijeme.");
              //      ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
              //      ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
              //      ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
              //      return View("~/Views/Administrator/RasporedOdvoza/EditRasporedOdvoza.cshtml", rasporedodvoza);
              //  }
              //  else if (rasporedOdvozaMatch2.Count() != 0)
              //  {
              //      ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu taj dan u tjednu.");
              //      ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
              //      ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
              //      ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
              //      return View("~/Views/Administrator/RasporedOdvoza/EditRasporedOdvoza.cshtml", rasporedodvoza);
              //  }
              //  else if (rasporedOdvozaMatch1.Count() != 0)
              //  {
              //      ModelState.AddModelError(string.Empty, "Već postoji zapis sa tom vrstom otpada u toj ulici u gradu.");
              //      ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
              //      ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
              //      ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
              //      return View("~/Views/Administrator/RasporedOdvoza/EditRasporedOdvoza.cshtml", rasporedodvoza);
              //  }

                db.Entry(rasporedodvoza).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("IndexRasporedOdvoza");
            }

            ViewBag.idGrad = new SelectList(db.grad, "idGrad", "imeGrad", rasporedodvoza.idGrad);
            ViewBag.idVrsteOtpada = new SelectList(db.otpad, "idOtpad", "vrstaOtpad", rasporedodvoza.idVrsteOtpada);
            ViewBag.idUlice = new SelectList(db.ulica, "idUlica", "imeUlica", rasporedodvoza.idUlice);
            return View("~/Views/Administrator/RasporedOdvoza/EditRasporedOdvoza.cshtml", rasporedodvoza);
        }

        // GET: rasporedodvozas/Delete/5
        public async Task<ActionResult> DeleteRasporedOdvoza(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            rasporedodvoza rasporedodvoza = await db.rasporedodvoza.FindAsync(int.Parse(id));
            if (rasporedodvoza == null)
            {
                return HttpNotFound();
            }
            return View("~/Views/Administrator/RasporedOdvoza/DeleteRasporedOdvoza.cshtml", rasporedodvoza);
        }

        // POST: rasporedodvozas/Delete/5
        [HttpPost, ActionName("DeleteRasporedOdvoza")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmedRasporedOdvoza(string id)
        {
            rasporedodvoza rasporedodvoza = await db.rasporedodvoza.FindAsync(int.Parse(id));
            db.rasporedodvoza.Remove(rasporedodvoza);
            await db.SaveChangesAsync();
            return RedirectToAction("IndexRasporedOdvoza");
        }
        #endregion
    }
}
