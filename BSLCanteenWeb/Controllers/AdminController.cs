using BSLCanteenWeb.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Mvc;
using OfficeOpenXml;
using System.Globalization;
using System.Text.RegularExpressions;

namespace BSLCanteenWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult AdminDashboard()
        {
            return View();
        }

        public ActionResult IssueCoupon()
        {
            return View();
        }

        public ActionResult DisplayEmployee()
        {
            return View();
        }

        public ActionResult Reports()
        {
            return View();
        }

        public ActionResult BulkUploadEmpData()
        {
            return View();
        }

        public ActionResult AddEmployee()
        {
            return View();
        }

        public ActionResult ViewEmployeeList()
        {
            return View();
        }

        public ActionResult EditEmployeeDetails()
        {
            return View();
        }

        public ActionResult PrintCoupon()
        {
            return View();
        }

        public ActionResult ResetPassword()
        {
            return View();
        }

        public ActionResult IssueItemCoupon()
        {
            return View();
        }

        public ActionResult AddMenuItem()
        {
            return View();
        }


        [HttpPost]
        public JsonResult Fn_Fetch_EmployeeDetails(clsEmployee objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Fetch_EmployeeDetails", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Fetching Employee details failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Emp_CouponGeneration(clsCouponOrder objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Emp_CouponGeneration", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Fabric Roll Updating failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Get_Coupon_Order(clsCouponOrder objReq)
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
                    return Json(new { success = false, message = "Fabric Roll Updating failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Get_Count_ItemMenu(clsCountMenuItem cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Get_Count_ItemMenu", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Get_All_Category(clsCouponItem cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Get_All_Category", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Get_All_MenuItems(clMenuItems cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Get_All_MenuItems", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Upload_BulkEmployeeData(clsEmployee objReq)
        {
            HttpPostedFileBase file = Request.Files[0];

            if (file == null || file.ContentLength == 0)
            {
                return Json(new { status = "error", message = "Please Upload Excel File" });
            }

            string fileExtension = Path.GetExtension(file.FileName).ToLower();

            if (fileExtension != ".xls" && fileExtension != ".xlsx")
            {
                return Json(new { success = false, message = "Invalid file format. Only .xls or .xlsx are allowed." }, JsonRequestBehavior.AllowGet);
            }

            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            List<clsEmployee> empList = new List<clsEmployee>();

            using (ExcelPackage package = new ExcelPackage(file.InputStream))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];
                int rowCount = sheet.Dimension.End.Row;
                int colCount = sheet.Dimension.End.Column;

                Dictionary<string, int> columnMap = new Dictionary<string, int>();
                // Read header row (Row 1 ONLY)
                for (int col = 1; col <= colCount; col++)
                {
                    string header = sheet.Cells[1, col].Text.Trim();

                    if (!string.IsNullOrEmpty(header) && !columnMap.ContainsKey(header))
                    {
                        columnMap.Add(header, col);
                    }
                }

                // Required columns list
                string[] requiredColumns = {
                 "EmployeeId", "EmpName", "EmpLocation", "Department",
                 "EmpRole", "CanteenName", "EmpMobile", "EmpStatus"
                  };

                // Validate required columns
                foreach (var colName in requiredColumns)
                {
                    if (!columnMap.ContainsKey(colName))
                    {
                        objReq.vErrorMsg = $"{colName} column not mapped in excel file.";
                        objReq.vErrorCode = 400;

                        var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                        return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                    }
                    else
                    {
                        objReq.vErrorMsg = "";
                        objReq.vErrorCode = 200;
                    }
                }

                if (objReq.vErrorMsg == "")
                {
                    for (int row = 2; row <= rowCount; row++)
                    {

                        int exEmpId = 0;
                        string empValue = sheet.Cells[row, 1].Text.Trim();
                        if (!int.TryParse(empValue, out exEmpId))
                        {                           
                            objReq.vErrorMsg = $"Invalid Employee ID '{empValue}' at Row {row}. Please enter a valid numeric Employee ID.";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }

                        // Continue processing if valid

                        string eName = sheet.Cells[row, 2].Text.Trim();
                        if (string.IsNullOrWhiteSpace(eName))
                        {
                            objReq.vErrorMsg = $"Please Enter Employee Name at Row {row}. It's required";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }

                        string strLocation = sheet.Cells[row, 3].Text.Trim();
                        List<string> arrLocation = new List<string>
                        {
                            "BSL", "TPP", "BFL", "WORSTED1",
                            "WEAVING-4", "BTM", "BJF", "MILL7"
                        };

                        // Validate Location
                        if (!arrLocation.Contains(strLocation, StringComparer.Ordinal))
                        {
                            objReq.vErrorMsg = $"Invalid Employee Location '{strLocation}' at Row {row}. Please enter the exact location name.";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }

                        string eDepartment = sheet.Cells[row, 4].Text.Trim();
                        if (string.IsNullOrWhiteSpace(eDepartment))
                        {
                            objReq.vErrorMsg = $"Please Enter Department at Row {row}. It's required";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }


                        string eRole = sheet.Cells[row, 5].Text.Trim();
                        if (string.IsNullOrWhiteSpace(eRole))
                        {
                            objReq.vErrorMsg = $"Please Enter Employee Role at Row {row}. It's required";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }

                        string CanteenName = "";
                        int CanteenNo = 0;

                        if (sheet.Cells[row, 6].Value != null)
                        {
                            CanteenName = sheet.Cells[row, 6].Value.ToString().Trim();

                            switch (CanteenName)
                            {
                                case "BSL WORKER":
                                    CanteenNo = 1;
                                    break;
                                case "TPP WORKER":
                                    CanteenNo = 2;
                                    break;
                                case "BFL WORKER":
                                    CanteenNo = 3;
                                    break;
                                case "WORSTED1 WORKER":
                                    CanteenNo = 4;
                                    break;
                                case "WEAVING-4 WORKER":
                                    CanteenNo = 5;
                                    break;
                                case "BTM WORKER":
                                    CanteenNo = 6;
                                    break;
                                case "BJF WORKER":
                                    CanteenNo = 7;
                                    break;
                                case "MILL7 WORKER":
                                    CanteenNo = 8;
                                    break;
                                default:
                                    objReq.vErrorMsg = $"Invalid Canteen Name '{CanteenName}' at Row {row}. Please enter a valid Canteen Name.";
                                    var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                                    return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                            }
                        }
                        else
                        {
                            objReq.vErrorMsg = $"Canteen Name is empty at Row {row}. Please enter a valid Canteen Name.";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }


                        string mobile = sheet.Cells[row, 7].Text.Trim();
                        string EmpMobile = "";
                        if (string.IsNullOrEmpty(mobile))
                        {
                            EmpMobile = "";
                        }
                        else if (Regex.IsMatch(mobile, @"^[6-9]\d{9}$"))
                        {
                            EmpMobile = mobile;
                        }
                        else
                        {
                            objReq.vErrorMsg = $"Invalid Employee Mobile '{mobile}' at Row {row}. Please enter a valid 10-digit mobile number or leave it blank.";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }

                        bool EmpWorkerStatus = true;
                        string SheetStatus = sheet.Cells[row, 8].Text.Trim();

                        if (SheetStatus.Equals("Active", StringComparison.OrdinalIgnoreCase))
                        {
                            EmpWorkerStatus = true;
                        }
                        else if (SheetStatus.Equals("Inactive", StringComparison.OrdinalIgnoreCase))
                        {
                            EmpWorkerStatus = false;
                        }
                        else
                        {
                            // Invalid value found in Excel
                            objReq.vErrorMsg = $"Invalid Employee Status '{SheetStatus}' at Row {row}. Allowed values are Active or Inactive";
                            var errorObj = new { vErrorMsg = objReq.vErrorMsg, vErrorCode = 400 };
                            return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                        }
                       

                        clsEmployee emp = new clsEmployee
                        {
                            //EmpId = Convert.ToInt64(sheet.Cells[row, 1].Value),
                            EmpId = Convert.ToInt64(exEmpId),
                            EmpName = sheet.Cells[row, 2].Text,
                            EmpLocation = sheet.Cells[row, 3].Text,
                            Department = sheet.Cells[row, 4].Text,
                            EmpRole = sheet.Cells[row, 5].Text,
                            CanteenId = CanteenNo,
                            //EmpMobile = sheet.Cells[row, 7].Text,
                            EmpMobile = EmpMobile,
                            EmpStatus = EmpWorkerStatus,
                            CreatedBy = objReq.CreatedBy
                        };

                        empList.Add(emp);
                    }
                }
            }

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(empList);
                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");

                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Upload_BulkEmployeeExcel", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    // return Json(new { success = false, message = "Data Import Failed" }, JsonRequestBehavior.AllowGet);
                    var errorObj = new
                    {
                        vErrorMsg = "API Not Responding",
                        vErrorCode = 500
                    };

                    return Json(new { success = false, message = Newtonsoft.Json.JsonConvert.SerializeObject(errorObj) }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_CanteenWise_Report(clsMonthlyReportReq cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_CanteenWise_Report", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_EmployeeWise_Report(clsMonthlyReportReq cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_EmployeeWise_Report", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_CanteenWise_Summery(clsMonthlyReportReq cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_CanteenWise_Summery", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_EmployeeWise_Summery(clsMonthlyReportReq cs)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(cs);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_EmployeeWise_Summery", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "No data found." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Insert_Employee(clsEmployee objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Insert_Employee", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Record Insertion Failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Fetch_All_Employee(clsEmployee objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Fetch_All_Employee", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Emp/Worker records fetch Failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Update_EmployeeDetails(clsEmployee objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Update_EmployeeDetails", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Employee/Worker updation failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }


        [HttpPost]
        public JsonResult Fn_Reset_Password(clsEmployee objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Employee/Fn_Reset_Password", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Employee Password reset failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Add_New_ItemCategory(clsAddMenu objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Add_New_ItemCategory", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Add New Item Category failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }

        [HttpPost]
        public JsonResult Fn_Delete_ItemMenu(clsAddMenu objReq)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Convert.ToString(ConfigurationManager.AppSettings["BSLCANTEENAPIURL"]));
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                string DATA = Newtonsoft.Json.JsonConvert.SerializeObject(objReq);

                HttpContent content = new StringContent(DATA, UTF8Encoding.UTF8, "application/json");
                HttpResponseMessage responsePost = client.PostAsync("api/Canteen/Fn_Delete_ItemMenu", content).Result;
                if (responsePost.IsSuccessStatusCode)
                {
                    return Json(new { success = true, message = responsePost.Content.ReadAsStringAsync().Result }, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(new { success = false, message = "Add New Item Category failed." }, JsonRequestBehavior.AllowGet);
                }
            }
        }
    }
}