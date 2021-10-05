using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using BikeService.Interfaces;
using BikeService.Models;
using BikeService.ViewModels;
using NIIT.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BikeService.Services
{
    public class AuthServices : IAuthService
    {
        #region variables
        private readonly ILogService logService;
        private readonly  BikeServiceContext context;
        private readonly ICommonService commonService;
        private IConfiguration config;
        #endregion

        #region constructor
        public AuthServices(ILogService _logService, BikeServiceContext _context, IConfiguration _config, ICommonService _commonService)
        {
            logService = _logService;
            context = _context;
            config = _config;
            commonService = _commonService;
        }
        #endregion

        #region methods


        public (string result, bool succeeded) CheckForgotPassword(ForgotPassword modal)
        {
            try
            {
                if (modal.UserType == "Admin")
                {
                    var student = context.TblAdminLogins.Where(s => s.UserId == modal.Email).SingleOrDefault();
                    if (student == null)
                        return ("No student found with mail " + modal.Email + ". try again with valid id.", false);

                    return ("", true);


                }
                else if (modal.UserType == "User")
                {
                    var student = context.TblUsers.Where(s => s.EmailId == modal.Email).SingleOrDefault();
                    if (student == null)
                        return ("No student found with mail " + modal.Email + ". try again with valid id.", false);

                    return ("", true);


                }
                else if (modal.UserType == "Vendor")
                {
                    var employer = context.TblVendors.Where(e => e.EmailId == modal.Email).SingleOrDefault();
                    if (employer == null)
                        return ("No employer found with mail " + modal.Email + ". try again with valid id.", false);
                    return ("", true);

                }
                else { return ("Invalid user type", false); }
            }
            catch (Exception ex)
            {
                logService.WriteLog(ex);
                return ("something went wrong", false);
            }
        }

        public (AuthUser user, bool succeeded, string message) DecodeToken(string token)
        {
            try
            {
                var handler = new JwtSecurityTokenHandler();
                var tokenS = handler.ReadToken(token) as JwtSecurityToken;
                string Userid = tokenS.Claims.First(claim => claim.Type == "sid").Value;
                var user = new AuthUser
                {
                    UserId = Userid,
                    RoleId = context.TblAdminLogins.Where(r => r.UserId == "Student").SingleOrDefault().Id.ToString()
                };
                //string Role = tokenS.Claims.First(claim => claim.Type == ClaimTypes.Role).Value;
                // user = new Login(user).UserDetailByRoleandId(int.Parse(Userid), Role);
                return (user, true, "");
            }
            catch (Exception ex)
            {
                logService.WriteLog(ex);
                return (null, false, "something went wrong.");
            }
        }

        public (Token token, bool succeeded, string message) GetToken(LoginViewModal modal)
        {
            AuthUser user = new AuthUser();
            Token token = new Token();
            try
            {
                var student = context.TblAdminLogins.Where(s => (s.UserId == modal.Id  && s.Password == modal.Password)).FirstOrDefault();

                if (student != null)
                {

                   


                  

                    //checking if student is active
                    if (student.IsActive != true)
                    {
                        return (null, false, "Your account is not active, please activate your account from email or contact to administrator.");
                    }
                    user.UserId = student.UserId.ToString();
                    user.UserName = student.Name;
                    token.TokenString = this.BuildToken(user);
                    token.ExpireOn = DateTime.Now.AddDays(7);
                    return (token, true, "");
                }
                else { return (token, false, "Invalid user id or password."); }
            }
            catch (Exception ex)
            {
                logService.WriteLog(ex);
                return (null, false, "Something went wrong.");
            }

        }


        private string BuildToken(AuthUser user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
            var claims = new List<Claim>(new[]
            {
                new Claim(JwtRegisteredClaimNames.Sid,user.UserId),
                new Claim(JwtRegisteredClaimNames.UniqueName,user.UserName)
            });
            var token = new JwtSecurityToken(config["Jwt:Issuer"],
              config["Jwt:Issuer"],
              expires: DateTime.Now.AddDays(7),
              claims: claims,
              signingCredentials: creds);
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        #endregion


    }
}
