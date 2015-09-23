using System.ComponentModel;

namespace OneWayBinding
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly PropertyChangedEventArgs NamePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Name));

        private string name = "okazuki";

        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name == value) { return; }
                this.name = value;
                this.PropertyChanged?.Invoke(this, NamePropertyChangedEventArgs);
            }
        }

    }
}
