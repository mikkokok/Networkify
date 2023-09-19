using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Networkify.Models;

namespace Networkify.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public UserNetworkInfo UserNetworkInfo { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            UserNetworkInfo = new UserNetworkInfo
            {
                ip = HttpContext.Connection.RemoteIpAddress?.ToString(),
                port = HttpContext.Connection.RemotePort
            };

        }
    }
}