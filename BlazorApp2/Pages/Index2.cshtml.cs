using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlazorApp2.Pages
{
    public class Index2Model : PageModel
    {
        public void OnGet()
        {

        }

        [HttpPost]
        public void OnPost()
        {
            var a = "";
        }
    }
}
