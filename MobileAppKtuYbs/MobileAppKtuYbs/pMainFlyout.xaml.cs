using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppKtuYbs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pMainFlyout : ContentPage
    {
        public ListView ListView;

        public pMainFlyout()
        {
            InitializeComponent();

            BindingContext = new pMainFlyoutViewModel();
            ListView = MenuItemsListView;
            
        }

        class pMainFlyoutViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<pMainFlyoutMenuItem> MenuItems { get; set; }

            public pMainFlyoutViewModel()
            {
                MenuItems = new ObservableCollection<pMainFlyoutMenuItem>(new[]
                {
                    new pMainFlyoutMenuItem { Id = 0, Title = "Bilgilerim", TargetType=typeof(Views.pBilgilerim) },
                    new pMainFlyoutMenuItem { Id = 1, Title = "Dönem Dersleri" },
                    new pMainFlyoutMenuItem { Id = 2, Title = "Vize Notları" },
                    new pMainFlyoutMenuItem { Id = 3, Title = "Transkript" },
                    new pMainFlyoutMenuItem { Id = 4, Title = "Akademik Durum Analizi" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}