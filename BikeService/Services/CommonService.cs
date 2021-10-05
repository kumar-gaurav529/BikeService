using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using BikeService.Interfaces;
//using BikeService.Models;
using BikeService.Utility;
using BikeService.ViewModels;
using BikeService.ViewModels.Common;
//using NIIT.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;

namespace BikeService.Services
{
    public class CommonService : ICommonService
    {
    //    #region variables
    //    private readonly ILogService logService;
    //    private readonly NIITContext context;
    //    public EmailSettings emailSettings { get; }
    //    public SmsSettings smsSettings { get; }
    //    private IHostingEnvironment hostingEnvironment;
    //    private IHttpContextAccessor httpContextAccessor;
    //    #endregion

    //    #region constructor

    //    public CommonService(ILogService _logService,
    //        NIITContext _context,
    //        IOptions<EmailSettings> _emailSettings,
    //        IOptions<SmsSettings> _smsSettings,
    //        IHostingEnvironment _hostingEnvironment,
    //        IHttpContextAccessor _httpContextAccessor

    //        )
    //    {
    //        logService = _logService;
    //        context = _context;
    //        emailSettings = _emailSettings.Value;
    //        smsSettings = _smsSettings.Value;
    //        hostingEnvironment = _hostingEnvironment;
    //        httpContextAccessor = _httpContextAccessor;
    //    }
    //    #endregion

    //    #region methods

       

    //    //public (string message, bool succeeded) SendMail(string sendTo, string mailBody, string subject)
    //    //{
    //    //    try
    //    //    {                
    //    //        SmtpClient smtp = new SmtpClient
    //    //        {
    //    //            Host = emailSettings.Host,
    //    //            Port = emailSettings.Port,
    //    //            EnableSsl = true,
    //    //            Credentials = new System.Net.NetworkCredential(emailSettings.SenderEmailId, emailSettings.SenderPassword),
    //    //        };
    //    //        MailMessage message = new MailMessage(emailSettings.FromEmail, sendTo, subject, mailBody);
    //    //        message.From = new MailAddress(emailSettings.FromEmail, emailSettings.SenderName);
    //    //        message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
    //    //        message.IsBodyHtml = true;
    //    //        smtp.Send(message);

    //    //        string status = message.DeliveryNotificationOptions.ToString();
    //    //        if (status == "OnSuccess")
    //    //        {
    //    //            return ("mail sent successfully.", true);
    //    //        }
    //    //        else
    //    //        {
    //    //            return ("error in sending mail.", false);
    //    //        }
    //    //    }
    //    //    catch (Exception ex)
    //    //    {
    //    //        logService.WriteLog(ex);
    //    //        return ("error in sending mail", false);
    //    //    }

    //    //}

    //    public (string filePath, bool succeeded) UploadFile(IFormFile file, string path)
    //    {
    //        try
    //        {
               
    //            string fileExt ="."+file.ContentType.Substring(file.ContentType.IndexOf('/') + 1);
    //            if (!Directory.Exists(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", path)))
    //            {
    //                Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot", path));
    //            }
    //            string fileName = Guid.NewGuid().ToString() + file.FileName + fileExt;
    //            var finalPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", path, fileName);
    //            using (var stream = new FileStream(finalPath, FileMode.Create))
    //            {
    //                 file.CopyTo(stream);
    //            }
    //            return (Path.Combine(path,fileName), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }           
    //    }



    //    public (string result, bool succeeded) GenerateRandomString(int length)
    //    {
    //        Random random = new Random();
    //        const string chars = "0123456789";            
    //        return (new string(Enumerable.Range(1, length).Select(_ => chars[random.Next(chars.Length)]).ToArray()), true);
    //    }

    //    public (string message, bool succeeded) AddUserQuery(UserQuery modal)
    //    {
    //        try
    //        {
    //            var data = new TblUserQuery
    //            {
    //                QueryTitle = modal.QueryTitle,
    //                QueryDescription = modal.QueryDescription,
    //                CreatedDate = DateTime.Now,
    //                UserId = modal.UserId,
    //                UserRoleId = modal.UserRoleId
    //            };
    //            context.Add(data);
    //            context.SaveChanges();

    //            //sending query in mail to admin.
    //            var userRoleDetails = context.TblRole.Where(r => r.Id == modal.UserRoleId).SingleOrDefault();
    //            if (userRoleDetails != null)
    //                modal.UserType = userRoleDetails.RoleName;

    //            var (mailResult, isMailSucceeded) = this.SendMail(emailSettings.SenderEmailId, this.CreateMailBodyForUserQuery(modal), "New User Query From"+ modal.UserName);
    //            return ("user query added successfully.", true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return ("something went wrong.", false);
    //        }
    //    }

    //    public (string message, bool succeeded) AddUserFeedback(UserFeedback modal)
    //    {
    //        try
    //        {
    //            var data = new TblUserFeedback
    //            {
    //                UserFeedback = modal.UserFeedbackText,
    //                CreatedDate = DateTime.Now,
    //                UserId = modal.UserId,
    //                UserRoleId = modal.UserRoleId
    //            };
    //            context.Add(data);
    //            context.SaveChanges();
    //            return ("user feedback added successfully.", true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return ("something went wrong.", false);
    //        }
    //    }

    //    //dropdowns
    //    public (List<Role> roles, bool succeeded) GetRoles()
    //    {
    //        try
    //        {
    //            string[] arr = new string[3];
    //            var roles = (from r in context.TblRole
    //                         select new Role
    //                         {
    //                             RoleId = r.Id,
    //                             RoleName = r.RoleName,
    //                             IsDropdown=r.IsDropdown
    //                         }).ToList();

    //            return (roles, true);

    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (JsonResult result, bool succeeded) GetEmployeeDesignationList()
    //    {
    //        try
    //        {
    //            var data = context.TblEmployeeDesignation.Where(e => e.DesignationName != null).ToList();
    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (JsonResult result, bool succeeded) GetStateList()
    //    {
    //        try
    //        {
    //            //var data = context.TblState.ToList().OrderBy(s => s.Name);

    //            var data = (from state in context.TblState
    //                        select new
    //                        {
    //                            state.Id,
    //                            state.Name
    //                        }).OrderByDescending(s => s.Name).ToList();

    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }


    //    }

    //    public (JsonResult result, bool succeeded) GetCityList(int stateId)
    //    {
    //        try
    //        {
    //            var data = (from city in context.TblCity
    //                        where
    //                     //city.StateId.ToString().Contains(string.IsNullOrEmpty(stateId)?city.StateId.ToString():stateId)
    //                        city.StateId==(stateId>0 ? stateId : city.StateId)
    //                        select new {
    //                            city.Id,
    //                            city.Name
    //                        } 
    //                        ).ToList().OrderBy(c=>c.Name);

    //            return (new JsonResult(data), true);

    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (JsonResult result, bool succeeded) GetCenterList(string stateId, string cityId)
    //    {
    //        try
    //        {
    //            var data = (from center in context.TblCenterMaster
    //                        where
    //                        center.CenterState.ToString().Contains(string.IsNullOrEmpty(stateId) ? center.CenterState.ToString() : stateId) &&
    //                        center.CenterCity.ToString().Contains(string.IsNullOrEmpty(cityId) ? center.CenterCity.ToString() : cityId)
    //                        select center
    //                      ).ToList().OrderBy(c => c.CenterName);

    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }            
    //    }

    //    public (JsonResult result, bool succeeded) GetBoardList()
    //    {
    //        try
    //        {
    //            var data = context.TblBoard.ToList().OrderBy(s => s.Name);
    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (JsonResult result, bool succeeded) GetUniversityList(string BoardType)
    //    {
    //        try
    //        {
    //            //s.StudentName.Contains(string.IsNullOrEmpty(parameters.Name) ? s.StudentName : parameters.Name)

    //            //var data = context.TblUniversity.ToList().OrderBy(s => s.Name);
    //            var data = (from u in context.TblUniversity
    //                           where u.BoardType.Contains(string.IsNullOrEmpty(BoardType) ? u.BoardType : BoardType)
    //                           select u
    //                         ).ToList();

    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (JsonResult result, bool succeeded) GetCourseList()
    //    {
    //        try
    //        {
    //            var data = context.TblCourseMaster.OrderBy(c => c.CourseCode).ToList();
    //            return (new JsonResult(data), true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (Role role, bool succeeded) GetRoleById(int id)
    //    {
    //        try
    //        {
    //            var data = (from role in context.TblRole
    //                        where role.Id == id
    //                        select new Role
    //                        {
    //                            RoleId=role.Id,
    //                            RoleName=role.RoleName

    //                        }).SingleOrDefault();                                                            
    //            return (data,true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //       // throw new NotImplementedException();
    //    }

    //    public (string result, bool succeeded) ProcTextForUniqueId(int? roleId)
    //    {
    //        try
    //        {
    //            string queryType = "";
    //            var data = (from role in context.TblRole where role.Id == roleId
    //                        select new Role
    //                        {
    //                            RoleId = role.Id,
    //                            RoleName = role.RoleName

    //                        }).SingleOrDefault();

    //            if (data != null)
    //            {
    //                if (data.RoleName == "Funder")
    //                {
    //                    queryType = "exec sp_Generate_Unique_Id 'GenerateFunderId'," + roleId + "";
    //                }
    //                //else if (data.RoleName == "Employee")
    //                //{
    //                //    queryType = "exec sp_Generate_Unique_Id 'GenerateEmployeeId'," + roleId + "";
    //                //}
    //                else if (data.RoleName == "Employer")
    //                {
    //                    queryType = "exec sp_Generate_Unique_Id 'GenerateEmployerId'," + roleId + "";
    //                }
    //                else if (data.RoleName == "Student")
    //                {
    //                    queryType = "exec sp_Generate_Unique_Id 'GenerateStudentId'," + roleId + "";
    //                }
    //                else
    //                {
    //                    queryType = "";
    //                }
    //            }
    //            else
    //            {
    //                queryType = "";
    //            }
    //            return (queryType, true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (SmsTemplatesList templates, bool succeeded) GetSmsTemplates()
    //    {
    //        try
    //        {

    //            using (var wb = new WebClient())
    //            {
    //                byte[] response = wb.UploadValues("https://api.textlocal.in/get_templates/", new NameValueCollection()
    //            {
    //            {"apikey" , smsSettings.apiKey}
    //            });
    //                string result = System.Text.Encoding.UTF8.GetString(response);
    //                var templatesList = JsonConvert.DeserializeObject<SmsTemplatesList>(result);
    //                return (templatesList, true);
    //            }                
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return (null, false);
    //        }
    //    }

    //    public (string message, bool succeeded) SendSms(string phoneNumber, string message)
    //    {
    //        try
    //        {
    //            String finalMessage = HttpUtility.UrlEncode(message);
    //            string result = string.Empty;
    //            using (var wb = new WebClient())
    //            {
    //                byte[] response = wb.UploadValues("https://api.textlocal.in/send/", new NameValueCollection()
    //            {
    //            {"apikey" , smsSettings.apiKey},
    //            {"numbers" , phoneNumber},              
    //            {"message" , finalMessage},
    //            {"sender" , smsSettings.sender}
    //            });
    //            result = System.Text.Encoding.UTF8.GetString(response);                    
    //            }
    //            return (result, true);
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return ("something went wrong in sending message", false);
    //        }
    //    }



    //    public  (string message, bool succeeded) SendMail(string sendTo, string mailBody, string subject)
    //    {
    //        try
    //        {
    //            SmtpClient smtp = new SmtpClient
    //            {
    //                Host = emailSettings.Host,
    //                Port = emailSettings.Port,
    //                EnableSsl = true,
    //                Credentials = new NetworkCredential(emailSettings.SenderEmailId, emailSettings.SenderPassword),
    //            };
    //            MailMessage message = new MailMessage(emailSettings.FromEmail, sendTo, subject, mailBody);
    //            message.From = new MailAddress(emailSettings.FromEmail, emailSettings.SenderName);
    //            message.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
    //            message.IsBodyHtml = true;
    //            //await smtp.SendMailAsync(message);
    //            smtp.Send(message);

    //            string status = message.DeliveryNotificationOptions.ToString();
    //            if (status == "OnSuccess")
    //            {
    //                return ("mail sent successfully.", true);
    //            }
    //            else
    //            {
    //                return ("error in sending mail.", false);
    //            }
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return ("error in sending mail", false);
    //        }
    //        // var dd = await ("", true);
    //    }

    //    #endregion


    //    #region mailing methods...
    //    public string CreateMailBodyForUserQuery(UserQuery query)
    //    {
    //        try
    //        {
    //            string body = string.Empty;               
    //            using (StreamReader reader = new StreamReader(Path.Combine(hostingEnvironment.WebRootPath, "html-templates/user-query.html")))
    //            {
    //                body = reader.ReadToEnd();
    //            }
    //            body = body.Replace("{@userName}", query.UserName);
    //            body = body.Replace("{@userType}", query.UserType);
    //            body = body.Replace("{@userTitle}", query.QueryTitle);
    //            body = body.Replace("{@userQuery}", query.QueryDescription);
    //            return body;
    //        }
    //        catch (Exception ex)
    //        {
    //            logService.WriteLog(ex);
    //            return "";
    //        }
    //    }

       
    //    #endregion
    }

   
}
