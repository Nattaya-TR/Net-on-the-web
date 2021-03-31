using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Hellodotnet.Pages
{
    public class HelloDotnetModel : PageModel
    {
        public string Message { get; set; } = "In page model: ";

        public void OnGet()
        {
        }
    }
}
