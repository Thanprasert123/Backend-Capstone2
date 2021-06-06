using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TestBACKEND.DBcontext;

namespace TestBACKEND.Controllers
{
    public class AuthController : ApiController
    {
        /*[HttpGet]
        [ActionName("user")]
        public IHttpActionResult GetUsers()
        {
            using (Capstone2Entities15 _databaseContext = new Capstone2Entities15())
            {
                //var users = _databaseContext.User_.ToList();
                var users = _databaseContext.User_.OrderBy(o => o.Age).ToList();
                
                return Ok(new { result = users, message = "success" });
            }
        }*/

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("user")]
        public IHttpActionResult GetID()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var user = _databaseContext.User_.ToList();

                return Ok(new { result = user, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("manager")]
        public IHttpActionResult GetUser()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var Manager = _databaseContext.Manager_.ToList();

                return Ok(new { result = Manager, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Saleoffice")]
        public IHttpActionResult GetSaleOffice()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sale_Office__s = _databaseContext.C_Sale_Office__.ToList();

                return Ok(new { result = sale_Office__s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("invoice")]
        public IHttpActionResult GetInvoice()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Invoices.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Cash")]
        public IHttpActionResult GetCash()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.C_Cash___.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("AcountPayable")]
        public IHttpActionResult GetAmountPayable()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.C_Account_payable__.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("StockDisel")]
        public IHttpActionResult GetStockdisel()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.C_stock_disel__.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Stock")]
        public IHttpActionResult GetStock()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.C_stock___.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("PO")]
        public IHttpActionResult GetPurchaseOrder()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Purchase_orders.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Truck")]
        public IHttpActionResult GetTruck()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Truck_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Order")]
        public IHttpActionResult GetOder()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Order_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Company")]
        public IHttpActionResult GetCompany()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Company_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Monthly")]
        public IHttpActionResult GetMonthly()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.monthly_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("daily")]
        public IHttpActionResult Getdaily()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.daily_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Saleoffice")]
        public IHttpActionResult Getsaleoffice()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.C_Sale_Office__.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Recon")]
        public IHttpActionResult GetRecon()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Reconciliation_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("STOCK")]
        public IHttpActionResult GetSTOCK()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.STOCK_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }


        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [HttpGet]
        [ActionName("Driver")]
        public IHttpActionResult GetDriver()
        {
            using (Capstone2Entities17 _databaseContext = new Capstone2Entities17())
            {
                //var users = _databaseContext.User_.ToList();
                var sheet1_s = _databaseContext.Driver_.ToList();

                return Ok(new { result = sheet1_s, message = "success" });
            }
        }







        /*[HttpGet]
        [ActionName("user")]
        public IHttpActionResult GetUsers()
        {
            using (Capstone2Entities15 _databaseContext = new Capstone2Entities15())
            {
                //var users = _databaseContext.User_.ToList();
                var users = _databaseContext.User_.SingleOrDefault(o => o.UserID == )

                return Ok(new { result = users, message = "success" });
            }
        }*/

        /*[HttpGet]
        [ActionName("user")]
        public IHttpActionResult GetUsersByid(double id)
        {
            using (Capstone2Entities15 _databaseContext = new Capstone2Entities15())
            {
                var user = _databaseContext.User_.Select(selector: o => o.UserID);

                
                
                return Ok(new { result = user, message = "success" });

                
               

            }
        }*/

    }
}