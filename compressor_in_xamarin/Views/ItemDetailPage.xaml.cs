using compressor_in_xamarin.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace compressor_in_xamarin.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}