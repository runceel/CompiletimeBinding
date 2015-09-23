using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace CollectionBinding
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Person> People { get; } = new ObservableCollection<Person>();

        public event PropertyChangedEventHandler PropertyChanged;

        private static readonly PropertyChangedEventArgs SelectedItemPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(SelectedItem));

        private Person selectedItem;

        public Person SelectedItem
        {
            get { return this.selectedItem; }
            set
            {
                if (this.selectedItem == value) { return; }
                this.selectedItem = value;
                this.PropertyChanged?.Invoke(this, SelectedItemPropertyChangedEventArgs);
            }
        }

        public MainPageViewModel()
        {
            var source = Enumerable.Range(1, 100)
                .Select(x => new Person { Name = "okazuki" + x });
            foreach (var p in source) { this.People.Add(p); }
        }
    }
}
