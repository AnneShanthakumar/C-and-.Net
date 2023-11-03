using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;



namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private Entities db = new Entities();

        // GET: Insuree
        private readonly string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Anne\\Desktop\\MVC\\CarInsurance\\CarInsurance\\App_Data\\Insurance.mdf;Integrated Security=True";
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Insuree insuree)
        {
            decimal monthlyTotal = 50;

            if (insuree.DateOfBirth >= DateTime.Now.AddYears(-18)) // Checking if age is 18 or under
            {
                monthlyTotal += 100;
            }
            else if (insuree.DateOfBirth >= DateTime.Now.AddYears(-25)) // Checking if age is between 19 and 25
            {
                monthlyTotal += 50;
            }
            else
            {
                monthlyTotal += 25;
            }
            {
                monthlyTotal += 25;
            }

            if (insuree.CarYear.CompareTo("2015") > 0) 
            {
                monthlyTotal += 25;
            }

            if (insuree.CarMake == "Porsche")
            {
                monthlyTotal += 25;
                if (insuree.CarModel == "911 Carrera")
                {
                    monthlyTotal += 25;
                }
            }

            monthlyTotal += 10 * insuree.SpeedingTicket;

            if (insuree.DUI)
            {
                monthlyTotal += monthlyTotal * 0.25m;
            }

            if (insuree.CoverageType)
            {
                monthlyTotal += monthlyTotal * 0.5m;
            }

            insuree.Quote = monthlyTotal;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "INSERT INTO Table (FirstName, LastName, Emailaddress, DateofBirth, CarYear, CarMake, CarModel, DUI, SpeedingTicket, CoverageType, Quote) VALUES (@FirstName, @LastName, @Emailaddress, @DateofBirth, @CarYear, @CarMake, @CarModel, @DUI, @SpeedingTicket, @CoverageType, @Quote)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", insuree.FirstName);
                    command.Parameters.AddWithValue("@LastName", insuree.LastName);
                    command.Parameters.AddWithValue("@Emailaddress", insuree.Emailaddress);
                    command.Parameters.AddWithValue("@DateofBirth", insuree.DateOfBirth);
                    command.Parameters.AddWithValue("@CarYear", insuree.CarYear);
                    command.Parameters.AddWithValue("@CarMake", insuree.CarMake);
                    command.Parameters.AddWithValue("@CarModel", insuree.CarModel);
                    command.Parameters.AddWithValue("@DUI", insuree.DUI);
                    command.Parameters.AddWithValue("@SpeedingTicket", insuree.SpeedingTicket);
                    command.Parameters.AddWithValue("@CoverageType", insuree.CoverageType);
                    command.Parameters.AddWithValue("@Quote", insuree.Quote);

                    command.ExecuteNonQuery();
                }
            }

            return RedirectToAction("Index");
        }

     
        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,Emailaddress,DateofBirth,CarYear,CarMake,CarModel,DUI,SpeedingTicket,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
