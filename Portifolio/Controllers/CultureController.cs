using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;

namespace Portifolio.Controllers;

[Route(template: "[controller]/[action]")]
public class CultureController : Controller
{
    public IActionResult Set(string culture, string redirectUri)
    {
        if (culture != null)
        {
            RequestCulture requestCulture = new(culture: culture, uiCulture: culture);
            string cookieName = CookieRequestCultureProvider.DefaultCookieName;
            string cookieValue = CookieRequestCultureProvider.MakeCookieValue(requestCulture: requestCulture);
            HttpContext.Response.Cookies.Append(key: cookieName, value: cookieValue);
        }
        
        return LocalRedirect(localUrl: redirectUri);
    }
}