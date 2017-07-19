using ExpandableView.Model;
using ExpandableView.ViewModel;
using Xamarin.Forms;

namespace ExpandableView
{
    public partial class ExpandableViewPage : ContentPage
    {
        public ExpandableViewPage()
        {
            InitializeComponent();
        }
        public void OnItemTapped(object sender, ItemTappedEventArgs args)
        {
            var product = args.Item as Product;
            var viewModel = BindingContext as ProductViewModel;

        }
    }
}
