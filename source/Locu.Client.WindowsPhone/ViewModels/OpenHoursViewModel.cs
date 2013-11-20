using System;
using System.Collections.ObjectModel;

namespace Locu.Client.WindowsPhone.ViewModels
{
    public class OpenHoursViewModel : ViewModelBase
    {
        public OpenHoursViewModel()
        {
            _hours = new ObservableCollection<string>();
        }

        private string _day;
        public string Day
        {
            get { return _day; }
            set
            {
                if (_day != value)
                {
                    _day = value;
                    OnPropertyChanged("Day");
                }
            }
        }

        private ObservableCollection<string> _hours;
        public ObservableCollection<string> Hours
        {
            get { return _hours; }
            set
            {
                if (_hours != value)
                {
                    _hours = value;
                    OnPropertyChanged("Hours");
                }
            }
        }
    }
}
