using compressor_in_xamarin.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace compressor_in_xamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FilePicker : ContentPage
    {
        filepicker1 fileVM;
        public FilePicker()
        {
            InitializeComponent();
            fileVM = new filepicker1();
            BindingContext = fileVM;
        }
    }
}