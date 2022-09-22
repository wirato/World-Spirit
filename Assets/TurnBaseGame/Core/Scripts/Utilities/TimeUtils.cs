using System;
using UnityEngine;

public static class TimeUtils
{
    public static string GetPrettyDate(this DateTime d,
        string textNow = "เมื่อครู่นี้",
        string textAMinuteAgo = "1 นาทีที่แล้ว",
        string textAHourAgo = "1 ชั่วโมงที่แล้ว",
        string textYesterday = "เมื่อวาน",
        string formatMinutesAgo = "{0} นาทีที่แล้ว",
        string formatHoursAgo = "{0} ชั่วโมงที่แล้ว",
        string formatDaysAgo = "{0} วันที่แล้ว",
        string formatWeeksAgo = "{0} สัปดาห์ที่แล้ว")
    {
        // 1.
        // Get time span elapsed since the date.
        TimeSpan s = DateTime.Now.Subtract(d);

        // 2.
        // Get total number of days elapsed.
        int dayDiff = (int)s.TotalDays;

        // 3.
        // Get total number of seconds elapsed.
        int secDiff = (int)s.TotalSeconds;

        // 4.
        // Don't allow out of range values.
        if (dayDiff < 0 || dayDiff >= 31)
        {
            return d.ToShortDateString();
        }

        // 5.
        // Handle same-day times.
        if (dayDiff == 0)
        {
            // A.
            // Less than one minute ago.
            if (secDiff < 60)
            {
                return textNow;
            }
            // B.
            // Less than 2 minutes ago.
            if (secDiff < 120)
            {
                return textAMinuteAgo;
            }
            // C.
            // Less than one hour ago.
            if (secDiff < 3600)
            {
                return string.Format(formatMinutesAgo, Mathf.FloorToInt((float)secDiff / 60f));
            }
            // D.
            // Less than 2 hours ago.
            if (secDiff < 7200)
            {
                return textAHourAgo;
            }
            // E.
            // Less than one day ago.
            if (secDiff < 86400)
            {
                return string.Format(formatHoursAgo, Mathf.FloorToInt((float)secDiff / 3600f));
            }
        }
        // 6.
        // Handle previous days.
        if (dayDiff == 1)
        {
            return textYesterday;
        }
        if (dayDiff < 7)
        {
            return string.Format(formatDaysAgo, dayDiff);
        }
        if (dayDiff < 31)
        {
            return string.Format(formatWeeksAgo, Mathf.CeilToInt((float)dayDiff / 7f));
        }
        return "Unknow";
    }
}
