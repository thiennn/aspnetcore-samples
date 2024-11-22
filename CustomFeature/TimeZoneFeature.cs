namespace CustomFeature
{
    public class TimeZoneFeature
    {
        public DateTimeOffset DateTime { get; set; } = DateTimeOffset.UtcNow;

        public TimeZoneInfo TimeZone { get; set; }
            = TimeZoneInfo.Utc;

        public DateTimeOffset Local =>
            TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime, TimeZone?.Id ?? TimeZoneInfo.Utc.Id);
    }
}
