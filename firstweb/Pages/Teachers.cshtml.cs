using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetClasses;

namespace NetOnWebPages
{
    public class TeachersModel : PageModel
    {
        public List<Teacher> Teachers;

        public void OnGet()
        {
            var Koen = new Teacher("Koen", 1 , "Lamaar");
            var Tim = new Teacher("Tim" , 2 , "Teano");
            var Sicco = new Teacher("Sicco" , 3, "Regitz");

            Teachers = new List<Teacher> { Koen, Tim, Sicco} ;
        }
    }
}
