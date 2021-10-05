using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BikeService.Utility;
using BikeService.ViewModels;
using BikeService.ViewModels.Common;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Interfaces
{
    public interface ICommonService
    {

        ////(string message, bool succeeded) SendMail(string sendTo, string mailBody,string subject);

        //(string message, bool succeeded) SendSms(string phoneNumber, string message);

        //(SmsTemplatesList templates, bool succeeded) GetSmsTemplates();

        //(string filePath, bool succeeded) UploadFile(IFormFile file, string path);

        //(string result, bool succeeded) GenerateRandomString(int length);

        //(string result, bool succeeded) ProcTextForUniqueId(int? role);

        ////(string message, bool succeeded) AddUserQuery(UserQuery modal);
        ////(string message, bool succeeded) AddUserFeedback(UserFeedback modal);

        ////(string message, bool succeeded) SendMail(string sendTo, string mailBody, string subject);

        //////dropdowns
        ////(List<Role> roles, bool succeeded) GetRoles();
        ////(Role role, bool succeeded) GetRoleById(int id);
        ////(JsonResult result, bool succeeded) GetEmployeeDesignationList();
        ////(JsonResult result, bool succeeded) GetStateList();
        ////(JsonResult result, bool succeeded) GetCityList(int stateId);
        ////(JsonResult result, bool succeeded) GetCenterList(string stateId, string cityId);
        ////(JsonResult result, bool succeeded) GetBoardList();
        ////(JsonResult result, bool succeeded) GetUniversityList(string BoardType);
        ////(JsonResult result, bool succeeded) GetCourseList();
    }
}
