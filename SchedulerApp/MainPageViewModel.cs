using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using GrawGoMaui.Helpers;
using static SchedulerApp.MeetingsResolver;

namespace SchedulerApp;

public partial class MainPageViewModel : ObservableObject
{
    [ObservableProperty] private ObservableRangeCollection<Meeting>? _meetings = [];  
    [ObservableProperty] private DateTime? _selectedDate;

    [RelayCommand]
    private void QueryAppointments(object obj)
    {
        // var visibleDates = ((SchedulerQueryAppointmentsEventArgs)obj).VisibleDates;
        Meetings = new ObservableRangeCollection<Meeting>(); // needed to renew collection here
        Meetings?.AddRange(GetMeetings());
    }
}