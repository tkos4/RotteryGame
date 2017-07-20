using System.ComponentModel;

namespace WheelOfLuck.Model
{
    public class NotificationObject : INotifyPropertyChanged

    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}