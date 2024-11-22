namespace CustomFeature
{
    public static class TimeZoneHttpContextExtention
    {
        public static TimeZoneInfo TimeZone(this HttpContext context)
        {
            var timeZoneFeature = context.Features.Get<TimeZoneFeature>();
            return timeZoneFeature.TimeZone;
        }
    }
}
