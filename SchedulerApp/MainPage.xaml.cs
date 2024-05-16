using System.Collections.ObjectModel;
using GrawGoMaui.Helpers;
using Syncfusion.Maui.Scheduler;

namespace SchedulerApp
{
    public partial class MainPage
    {
        private readonly ObservableRangeCollection<Meeting>? _selectedMeetings = [];

        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
        }


        private void Scheduler_OnSelectionChanged(object? sender, SchedulerSelectionChangedEventArgs e)
        {
            if (!e.NewValue.HasValue) return;
            SetCollectionView(e.NewValue.Value);
        }

        private void SetCollectionView(DateTime selectedDate)
        {
            var meetings = (ObservableCollection<Meeting>?)Scheduler.AppointmentsSource;
            _selectedMeetings?.Clear();
            if (meetings == null) return;
            _selectedMeetings?.AddRange(meetings.Where(x => x.From >= selectedDate && x.To <= selectedDate.AddDays(1)));
            ColView.ItemsSource = _selectedMeetings;
            ColView.ScrollTo(0);
        }
    }
}