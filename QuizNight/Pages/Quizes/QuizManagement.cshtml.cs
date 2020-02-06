using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace QuizNight.Pages.Quizes
{
    public class QuizManagementModel : PageModel
    {
        private IConfiguration config;
        public string Message { get; set; }

        public QuizManagementModel(IConfiguration config)
        {
            this.config = config;
        }
        public void OnGet()
        {
            Message = config["QuizMessage"];
        }
    }
}