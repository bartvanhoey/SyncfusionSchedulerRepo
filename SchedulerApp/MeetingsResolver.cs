using System.Collections.ObjectModel;
using System.Diagnostics;
using static SchedulerApp.RandomColorResolver;

namespace SchedulerApp;

public static class MeetingsResolver
{
    public static List<Meeting> GetMeetings()
    {
        var meetings = new List<Meeting>();
        var random = new Random();
        var number = random.Next(1001);
        for (var i = 0; i < number; i++)
        {
            var dayRandom = random.Next(1461);
            var randomBackgroundColor = GetRandomColor();
            var meeting = new Meeting
            {
                From = DateTime.Today.AddDays(-dayRandom),
                To = DateTime.Today.AddDays(-dayRandom),
                Subject = $"Meeting {random.Next(int.MaxValue)}",
                Location = "Somewhere",
                TextColor = GetRandomColor(),
                Background = new SolidColorBrush(randomBackgroundColor),
                BackgroundColor = randomBackgroundColor
            };
            meetings.Add(meeting);
        }
        return meetings;
    }
}