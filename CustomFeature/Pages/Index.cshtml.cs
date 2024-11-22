using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CustomFeature.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public TimeZoneInfo? CurrentTimeZone { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            //var timeZoneFeature = HttpContext.Features.Get<TimeZoneFeature>();
            //CurrentTimeZone = timeZoneFeature.TimeZone;

            CurrentTimeZone = HttpContext.TimeZone();
        }
    }
}
