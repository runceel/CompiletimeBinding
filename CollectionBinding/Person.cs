using System.ComponentModel;

namespace CollectionBinding
{
    public class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly PropertyChangedEventArgs NamePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(Name));

        private string name;

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
