using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.AspNetCore.Authentication;

namespace WebApplication1.Controllers
{
	public class GuvenlikController : Controller
	{
		Context db = new Context();

		[HttpGet]
		public IActionResult Login()
		{
			return View();
		}
		public async Task<IActionResult> Login(User us)
		{
			var values = db.Users.FirstOrDefault(x => x.userName == us.userName && x.userPass == us.userPass);
			if (values != null)
			{
				var claims = new List<Claim>
				{
					new Claim(ClaimTypes.Name, us.userName)
				};
				var useridentity=new ClaimsIdentity(claims,"Login");
				ClaimsPrincipal principal=new ClaimsPrincipal(useridentity);
				await HttpContext.SignInAsync(principal);
				
				return RedirectToAction("Index", "Home");
			}
			else
			{
				ModelState.AddModelError("", "Hatalı Giriş Yaptınız. Lütfen Bilgilerinizi Kontrol Ediniz !!");
				return View("Login");
			}
		
		}
	}
}
