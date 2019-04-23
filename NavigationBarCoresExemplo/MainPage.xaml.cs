using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationBarCoresExemplo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();

            //Oculta A barra de navegação
           // Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            //Altera o Texto do Botão voltar
           // Xamarin.Forms.NavigationPage.SetBackButtonTitle(this,"De volta para o futuro");
            //Possui Botão voltar ?
           // Xamarin.Forms.NavigationPage.SetHasBackButton(this, false);
        }

        public async void Handle_Clicked(object sender, EventArgs e)
        {
            await Application.Current.MainPage.Navigation.PushAsync(new SegundaPage());
        }
    }
}
