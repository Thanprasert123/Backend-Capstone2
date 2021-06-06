using count_date;
using OSIsoft.AF.PI;
using OSIsoft.AF.Time;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestBACKEND.Controllers
{
    public class PIController : ApiController
    {
        private PIServer _piserver;
        private string _piserverIP = "202.44.12.146";
       
        private readonly NetworkCredential cred = new NetworkCredential("Group1", "inc.382");
        // GET api/values

        // GET api/values/5
        [HttpGet]
        [ActionName("Truckindaily")]
        public IHttpActionResult Gettiweek()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA7");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("conjaa")]
        private PIServer piConnect()
        {
            _piserver = new PIServers()[_piserverIP];
            _piserver.Connect(cred);
            return _piserver;
        }


        [HttpGet]
        [ActionName("TruckinMonthly")]
        public IHttpActionResult GetTImonth()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA12");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Truckinweekly")]
        public IHttpActionResult GetTIdaily()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA9");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }





        [HttpGet]
        [ActionName("Daily95")]
        public IHttpActionResult Getdaily95()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA2");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("WeeklyGas95")]
        public IHttpActionResult GetWeek95()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA4");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("MonthlyGas95")]
        public IHttpActionResult Getmonth95()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA6");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("dailyDisel")]
        public IHttpActionResult GetdailyDisel()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA1");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("WeeklyDisel")]
        public IHttpActionResult GetWeekDisel()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA3");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Monthlydisel")]
        public IHttpActionResult Getmonthdisel()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A00-0100-S3-DATA5");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Truckoutdaily")]
        public IHttpActionResult GetTOdaily()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA8");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Truckoutweekly")]
        public IHttpActionResult GetTOWeekly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA10");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("TruckoutMonthly")]
        public IHttpActionResult GetTOMonthly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0000-S3-DATA12");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Cycletime")]
        public IHttpActionResult GetCYC()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0700-O1-DATA050");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("Diseldailybusy")]
        public IHttpActionResult Getdiseldailybusy()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA66");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("Diselweeklybusy")]
        public IHttpActionResult Getdiselweeklybusy()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA68");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        [HttpGet]
        [ActionName("95dailybusy")]
        public IHttpActionResult Get95dailybusy()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA67");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("95weeklybusy")]
        public IHttpActionResult Get95weeklybusy()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA69");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("Wip")]
        public IHttpActionResult Getwip()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0300-S3-DATA49");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("DailyDiselFail")]
        public IHttpActionResult Getdiselfaildaily()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA72");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("DiselweeklyFail")]
        public IHttpActionResult Getdiselfailweekly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA74");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("DiselmonthlyFail")]
        public IHttpActionResult Getdiselfailmothly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA76");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("Daily95Fail")]
        public IHttpActionResult Get95faildaily()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA73");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }



        [HttpGet]
        [ActionName("95weeklyFail")]
        public IHttpActionResult Get95failweekly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA75");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }


        [HttpGet]
        [ActionName("95monthlyFail")]
        public IHttpActionResult Get95failmothly()
        {

            var start_date = "2018-03-02";

            var rangedate = cal_date.count_start(start_date);
            var searchdate = "*-" + rangedate + "d";

            var cn = piConnect();
            if (cn.ConnectionInfo.IsConnected)
            {
                var point = PIPoint.FindPIPoint(cn, "A001-0100-S3-DATA77");
                var timeRange = new AFTimeRange(searchdate, "*");
                var value = point.RecordedValues(timeRange, 0, "", true, 0);
                List<(double, string)> valueAll = new List<(double, string)>();
                foreach (var item in value)
                {
                    valueAll.Add((Convert.ToDouble(item.Value), Convert.ToString(item.Timestamp)));
                }
                return Ok(new { result = valueAll, message = "success" });
            }
            else
            {
                return Ok(new { message = "can not connect to pi server" });
            }
        }

        // POST api/values
        /* public void Post([FromBody] string value)
         {
         }

         // PUT api/values/5
         public void Put(int id, [FromBody] string value)
         {
         }

         // DELETE api/values/5
         public void Delete(int id)
         {
         }
        */
    }
}
