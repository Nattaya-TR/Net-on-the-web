using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using dotnetClasses;


namespace NetOnWebPages
{
    public class StudentModel : PageModel
    {
        public List<Student> Students;

        public void OnGet()
        {
            var Id = 1; 

            var Nattaya = new Student(Id++, "Nattaya" , 1);
            var Jenifer = new Student(Id++, "Jenifer", 1);
            var Oscar = new Student(Id++, "Oscar", 1);
            var Laila = new Student(Id++, "Laila", 1);
            var Thomas = new Student(Id++, "Thomas", 1);

            Students = new List<Student> { Nattaya, Jenifer, Oscar, Laila, Thomas };
        }
    }
}
