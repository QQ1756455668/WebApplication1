using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Index1Model : PageModel
    {
        public void OnGet()
        {
            ViewData["test1"] = "test1";
            ViewData["test2"] = "����2";
        }
    }
}
