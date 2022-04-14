using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Diploma.Pages
{
    public class Log_inModel : PageModel
    {
        private readonly ILogger<Log_inModel> _logger;

        public Log_inModel(ILogger<Log_inModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}