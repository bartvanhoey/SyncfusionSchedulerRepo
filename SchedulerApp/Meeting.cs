using CommunityToolkit.Mvvm.ComponentModel;

namespace SchedulerApp;

public partial class Meeting : ObservableObject
{
    [ObservableProperty] private string? _subject;
    [ObservableProperty] private DateTime _from;
    [ObservableProperty] private DateTime _to;
    [ObservableProperty] private Color? _textColor;
    [ObservableProperty] private Brush? _background;
    [ObservableProperty] private Color? _backgroundColor;
    [ObservableProperty] private string? _location;
    
}