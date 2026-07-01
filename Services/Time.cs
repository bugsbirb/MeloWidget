namespace Melon.Services;

public class Time
{
    public string Format(TimeSpan totalTime)
    {
        int weeks = totalTime.Days / 7;
        int days = totalTime.Days % 7;
        int hours = totalTime.Hours;
        int minutes = totalTime.Minutes;

        List<string> parts = new();

        if (weeks > 0) parts.Add($"{weeks} week{(weeks > 1 ? "s" : "")}");
        if (days > 0) parts.Add($"{days} day{(days > 1 ? "s" : "")}");
        if (hours > 0) parts.Add($"{hours} hour{(hours != 1 ? "s" : "")}");
        if (minutes > 0) parts.Add($"{minutes} minute{(minutes != 1 ? "s" : "")}");
        
        return string.Join(", ", parts);
    }
}