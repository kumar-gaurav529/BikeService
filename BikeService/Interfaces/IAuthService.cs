using BikeService.ViewModels;
using NIIT.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BikeService.Interfaces
{
    public interface IAuthService
    {
        (Token token, bool succeeded, string message) GetToken(LoginViewModal modal);
        (string result, bool succeeded) CheckForgotPassword(ForgotPassword modal);
        (AuthUser user, bool succeeded, string message) DecodeToken(string token);
    }
}
