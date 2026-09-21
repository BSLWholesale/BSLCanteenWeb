using BSLCanteenWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using OfficeOpenXml;
using System.IO;
using System.Globalization;

namespace BSLCanteenWeb.Controllers
{
    public class StaffController : Controller
    {
        // GET: Staff
        public ActionResult StaffDashboard()
        {
            return View();
        }
        public ActionResult StaffTodayHistory()
        {
            return View();
        }
        public ActionResult ManualCouponEntry()
        {
            return View();
        }

        public ActionResult SuperadminReports()
        {
            return View();
        }

        public ActionResult DailyReport()
        {
            return View();
        }

        public ActionResult DailyEmployeeReport()
        {
            return View();
        }

        public ActionResult AllEmployeeMonthlyReport()
        {
            return View();
        }

        public ActionResult UPIDataUpload()
        {
            return View();
        }

        public ActionResult UPIMonthlyDataReport()
        {
            return View();
        }


        public ActionResult CanteenWiseReport()
        {
            return View();
        }

        [HttpPost]
        public JsonResult Fn_ProcessCouponTransaction(clsCouponReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_ProcessCouponTransaction", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "CouponTransaction failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Get_Coupon_Order(clsCouponReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Get_Coupon_Order", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Scanned Coupons List fetching failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Cancel_CouponId(clsCouponReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Cancel_CouponId", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Cancel_CouponId failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyReport_Shiftwise(clsShiftReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_Shiftwise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Shift wise records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyReport_ItemCategorywise(clsCategoryReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_ItemCategorywise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily category wise report records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyReport_Canteenwise(clsCategoryReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_Canteenwise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Canteen wise records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_CanteenWise_Report(clsMonthlyReportReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_CanteenWise_Report", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Canteen wise report records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_CanteenWise_Summery(clsMonthlyReportReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_CanteenWise_Summery", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Canteen wise summary records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_EmployeeWise_Report(clsMonthlyReportReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_EmployeeWise_Report", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Employee wise report records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_EmployeeWise_Summery(clsMonthlyReportReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_EmployeeWise_Summery", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Employee wise summary records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyMonthlyReport_EmpDetail(clsDailyMonthlyAllEmpDetailReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyMonthlyReport_EmpDetail", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Monthly records of all Employee detail report are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyMonthlyReport_EmpSummary(clsDailyMonthlyAllEmpSummaryReq objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyMonthlyReport_EmpSummary", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Monthly records of all Employee detail report are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyReport_ItemWise(clsItemWiseReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_ItemWise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Item wise records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_DailyReport_CouponTypeWise(clsCouponTypeReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_CouponTypeWise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily Coupon Type wise records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }



        [HttpPost]
        public JsonResult Fn_Upload_UPIDataFile(clsUPIDataUpload objReq)
        {
            try
            {
                objReq.vErrorMsg = "";

                if (Request.Files.Count == 0)
                {
                    return Json(new { success = false, message = "Please Select Excel file"}, JsonRequestBehavior.AllowGet);
                }

                HttpPostedFileBase file = Request.Files[0];

                if (file == null || file.ContentLength == 0)
                {
                    return Json(new { success = false, message = "Please Select Excel file"}, JsonRequestBehavior.AllowGet);
                }

                string fileExtension = Path.GetExtension(file.FileName).ToLower();

                if (fileExtension != ".xls" && fileExtension != ".xlsx")
                {
                    return Json(new { success = false, message = "Invalid file format. Only .xls or .xlsx are allowed." }, JsonRequestBehavior.AllowGet);
                }

                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                List<clsUPIDataUpload> UPIDataList = new List<clsUPIDataUpload>();

                using (ExcelPackage package = new ExcelPackage(file.InputStream))
                {
                    ExcelWorksheet sheet = package.Workbook.Worksheets[0];

                    if (sheet == null || sheet.Dimension == null)
                    {
                        return Json(new { success = false, message = "Excel file is empty."}, JsonRequestBehavior.AllowGet);
                    }

                    int rowCount = sheet.Dimension.End.Row;

                    for (int row = 2; row <= rowCount; row++)
                    {
                        try
                        {
                            // Transaction Date
                            string transDate = sheet.Cells[row, 1].Text.Trim();

                            DateTime transactionDate;

                            if (sheet.Cells[row, 1].Value is DateTime)
                            {
                                transactionDate = (DateTime)sheet.Cells[row, 1].Value;
                            }
                            else
                            {
                                string[] dateFormats =
                                {
                                    "M-d-yy H:mm:ss",
                                    "MM-dd-yy H:mm:ss",
                                    "M-d-yyyy H:mm:ss",
                                    "MM-dd-yyyy H:mm:ss",
                                    "M/d/yy H:mm:ss",
                                    "MM/dd/yy H:mm:ss",
                                    "M/d/yyyy H:mm:ss",
                                    "MM/dd/yyyy H:mm:ss",
                                    "yyyy-MM-dd HH:mm:ss",
                                    "yyyy-MM-dd H:mm:ss",
                                    "dd-MM-yyyy HH:mm:ss",
                                    "dd-MMM-yyyy HH:mm:ss",
                                    "dd/MM/yyyy HH:mm:ss"
                                };

                                if (!DateTime.TryParseExact(transDate, "dd-MM-yyyy HH:mm:ss", CultureInfo.InvariantCulture, DateTimeStyles.None, out transactionDate))
                                {
                                    return Json(new { success = false, message = $"Invalid date '{transDate}' at Excel row {row}" }, JsonRequestBehavior.AllowGet);
                                }
                            }

                            // Rate
                            decimal rate = 0;

                            if (!string.IsNullOrWhiteSpace(sheet.Cells[row, 4].Text))
                            {
                                if (!decimal.TryParse(sheet.Cells[row, 4].Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out rate))
                                {
                                    return Json(new { success = false, message = $"Invalid Rate at Excel row {row}" }, JsonRequestBehavior.AllowGet);
                                }
                            }

                            // Create object
                            clsUPIDataUpload UPIData = new clsUPIDataUpload
                            {
                                TransactionDate = transactionDate.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
                                TransactionID = Convert.ToString(sheet.Cells[row, 2].Value),
                                Amount = Convert.ToDecimal(sheet.Cells[row, 3].Value),
                                Rate = rate,
                                Qty = Convert.ToInt32(sheet.Cells[row, 5].Value),
                                LocationID = Convert.ToString(sheet.Cells[row, 6].Value)
                            };

                            UPIDataList.Add(UPIData);
                        }
                        catch (Exception ex)
                        {
                            return Json(new { success = false, message = $"Error processing Excel row {row}: {ex.Message}" }, JsonRequestBehavior.AllowGet);
                        }
                    }
                }

                // Validate list
                if (UPIDataList.Count == 0)
                {
                    return Json(new { success = false, message = "No records found in Excel file." }, JsonRequestBehavior.AllowGet);
                }

                // Send to API in batches
                int batchSize = 1000;
                int totalRecords = UPIDataList.Count;
                int totalSuccess = 0;

                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    for (int start = 0; start < totalRecords; start += batchSize)
                    {
                        List<clsUPIDataUpload> batch = UPIDataList.Skip(start).Take(batchSize).ToList();

                        string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(batch);

                        HttpContent content = new StringContent(DATA, Encoding.UTF8, "application/json");
                        HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Upload_UPIDataFile", content).Result;
                        string responseMessage = responsePost.Content.ReadAsStringAsync().Result;

                        if (!responsePost.IsSuccessStatusCode)
                        {
                            return Json(new { success = false, message = $"API failed at batch {(start / batchSize) + 1}. " + responseMessage }, JsonRequestBehavior.AllowGet);
                        }

                        // API currently returns List<clsUPIDataUpload>
                        List<clsUPIDataUpload> result = Newtonsoft.Json.JsonConvert.DeserializeObject<List<clsUPIDataUpload>>(responseMessage);

                        if (result != null)
                        {
                            totalSuccess += result.Count;
                        }
                    }
                }

                // Final return
                return Json(new { success = true, totalRecords = totalRecords, successCount = totalSuccess, message = "UPI data uploaded successfully." }, JsonRequestBehavior.AllowGet);
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message }, JsonRequestBehavior.AllowGet);
            }
        }

        [HttpPost]
        public JsonResult Fn_DailyReport_UPIDataCanteenWise(clsUPIDataReport objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_DailyReport_UPIDataCanteenWise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Daily UPI data report records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_MonthlyReport_UPIDataCanteenWise(clsUPIMonthlyReportRequest objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_MonthlyReport_UPIDataCanteenWise", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "UPI Monthly Data records are not found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


    }
}