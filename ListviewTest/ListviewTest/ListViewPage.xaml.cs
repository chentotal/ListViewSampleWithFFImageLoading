using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListviewTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListViewPage : ContentPage
    {
        public ObservableCollection<MyCustomViewModel> Items { get; set; }

        public ListViewPage()
        {
            InitializeComponent();

			Items = new ObservableCollection<MyCustomViewModel>();

			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/rwa4t41uv6rkbyqwn6dy"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/gv5kzeqvwq5jtkvixghl"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/nxifde1fzqmtj551yhft"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/nyjzm1kzrkarq9zc0fss"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/eqej5ebaotx80p1bxjnv"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/igbsx27afmbskirpzsxa"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/wu3247wsarzekthwsayu"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/ehsthokphto8umyuxjin"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/a5ynlvnxjlbvrmhfhpxu"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/e3krrwv8x4wgknhtz8vl"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/ceubjjcqi6d588gyuizm"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/htzhkdjdxjzk7qrginjz"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/sggcsg8dvbn9tbthjoko"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/pszfg7al8ldv36eniicb"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/adhi1mjs2ukvqhyvi6p3"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/tyif6cpu52nhhg0m802h"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/d4kuw5sbjdf3rawruayj"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/qebwhng0cqwox4m4jmk0"));

			
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/p7abndwb3jbmab0d7ya6"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/gj7xxwxwzt5twy5spwdz"));
			Items.Add(new MyCustomViewModel("http://res.cloudinary.com/mitfun/image/upload/axnxwzsrpwkgez3g8ybj"));

			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
