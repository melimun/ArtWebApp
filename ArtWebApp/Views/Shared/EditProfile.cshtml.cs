using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ArtWebApp.Views.Shared
{
    public class EditProfile : PageModel
    {
        private readonly ILogger<EditProfile> _logger;

        public EditProfile(ILogger<EditProfile> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}