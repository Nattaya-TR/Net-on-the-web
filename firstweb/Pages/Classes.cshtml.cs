using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetClasses;

namespace NetOnWebPages
{
    public class ClassesModel : PageModel
    {
        public Classes Classes { get; set; }

        public void OnGet()
        {
            var Alan = new Student (101, "Alan" , 1);
            var Alice = new Student (102, "Alice", 1);
            var Anita = new Student (103, "Anita", 1);

            var Students = new List<Student> { Alan , Alice , Anita};

            //var Anakin = new Teacher ("Anakin", 1 , "Apollo");

            var Classes = new Classes (1, "Apollo", Students , "Anakin");
        }
    }
}
