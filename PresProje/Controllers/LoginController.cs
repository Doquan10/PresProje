using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using PresProje.Models;
using System.Security.Claims;
using System.Xml.Linq;

namespace PresProje.Controllers
{
    public class LoginController : Controller
    {
        Context c = new Context();
        public IActionResult SignIn()
        {
            ClaimsPrincipal claimUser = HttpContext.User;

            if (claimUser.Identity.IsAuthenticated)
                return RedirectToAction("Index", "Home");
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> SignIn(Users users)
        {
            var UserInfo = c.Users.FirstOrDefault(x => x.Username ==users.Username &&
            x.Password == users.Password);

            if (UserInfo != null)
            {
                
                List<Claim> claims = new List<Claim>()
                {
                    new Claim(ClaimTypes.Name, users.Username),
                    new Claim(ClaimTypes.Role, UserInfo.Status),
                    new Claim("ID", UserInfo.ID.ToString())
                };
                HttpContext.Session.SetString("username", "alican");
                ClaimsIdentity claimsIdentity = new ClaimsIdentity(claims,
                    CookieAuthenticationDefaults.AuthenticationScheme);

                AuthenticationProperties properties = new AuthenticationProperties()
                {
                    AllowRefresh = true,
                    IsPersistent = users.KeepLoggedIn
                };

                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme,
                    new ClaimsPrincipal(claimsIdentity), properties);

                if (UserInfo.Status == "Admin")
                {
                    return RedirectToAction("Index", "Admin");
                }else {
                    return RedirectToAction("Index", "Home");
                }
               
            }

            ViewData["ValidateMessage"] = "user not found";
            return View();
        }
    }
}
