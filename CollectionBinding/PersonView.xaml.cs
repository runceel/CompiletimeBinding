using Windows.UI.Xaml.Controls;

namespace CollectionBinding
{
    public sealed partial class PersonView : UserControl
    {
        public Person ViewModel => this.DataContext as Person;

        public PersonView()
        {
            this.InitializeComponent();
            this.DataContextChanged += (_, __) => this.Bindings.Update();
        }
    }
}
