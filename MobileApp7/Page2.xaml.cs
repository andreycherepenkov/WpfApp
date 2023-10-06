using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileApp7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2 : ContentPage
    {
        public ObservableCollection<Animal> Animals { get; set; }

        public Page2()
        {
            InitializeComponent();
            Animals = new ObservableCollection<Animal>
            {
                new Animal {Title="Волк", Description="Хищник: ", ImgPath="volk.jpg" },
                new Animal {Title="Лиса", Description="Хищник: ", ImgPath="lisa.jpg" },
                new Animal {Title="Медведь", Description="Хищник: ", ImgPath="medved.jpg" },
                new Animal {Title="Олень", Description="Травоядный: ", ImgPath="olen.jpg" },
                new Animal {Title="Заяц", Description="Травоядный: ", ImgPath="zayec.jpg" },
                new Animal {Title="Лось", Description="Травоядный: ", ImgPath="los.jpg" }
            };
            this.BindingContext = this;
        }

        private void AddItem(object sender, EventArgs e)
        {
            Animals.Add(new Animal { Title = "Ежик", Description = "", ImgPath = "no.jpg" });
        }

        private void RemoveItem(object sender, EventArgs e)
        {
            Animal obj = ListAnimals.SelectedItem as Animal;
            if (obj != null)
            {
                Animals.Remove(obj);
                ListAnimals.SelectedItem = null;
            }
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page3());
        }
    }
}