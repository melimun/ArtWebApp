using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ArtWebApp.Views.Home
{
    public class Marketplace : PageModel
    {
        private readonly ILogger<Marketplace> _logger;

        public Marketplace(ILogger<Marketplace> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}