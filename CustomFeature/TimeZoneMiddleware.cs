namespace CustomFeature
{
    public class TimeZoneMiddleware: IMiddleware
    {
        public const string TimeZoneKey = "timezone";

        // SE%20Asia%20Standard%20Time

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            var timeZoneFeature = new TimeZoneFeature();
            if (context.Request.Cookies.TryGetValue(TimeZoneKey, out var timezone))
            {
                timeZoneFeature.TimeZone = TimeZoneInfo.FindSystemTimeZoneById(timezone)
                    ?? TimeZoneInfo.Utc;
            }

            context.Features.Set(timeZoneFeature);
            await next(context);
        }
}
}
