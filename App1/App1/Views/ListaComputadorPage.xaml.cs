using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaComputadorPage : ContentPage
    {
        public ListaComputadorPage()
        {
            InitializeComponent();
        }

        protected async override void OnAppearing()
        {
            lstComputador.ItemsSource = await App.Banco.ListarTodos();
            base.OnAppearing();
        }
    }
}