using System.ComponentModel;

namespace DrawGame.Domain.Model.Core
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