//using Microsoft.Build.Tasks.Deployment.Bootstrapper;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MobileApp7;
using static Xamarin.Essentials.Permissions;

namespace MobileApp7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public ObservableCollection<Grouping<string, Product>> ProductGroups { get; set; }
        public Page3()
        {
            InitializeComponent();
            var products = new List<Product>
            {
                new Product { Title = "Батон", Company = "Выпечка", Price = 60 },
                new Product { Title = "Хлеб", Company = "Выпечка", Price = 50 },
                new Product { Title = "Масло", Company = "Молочные излелия", Price = 100 },
                new Product { Title = "Сыр", Company = "Молочные излелия", Price = 290 },
                new Product { Title = "Творог", Company = "Молочные излелия", Price = 55 },
                new Product { Title = "Молоко", Company = "Молочные излелия", Price = 65 },
                new Product { Title = "Йогурт", Company = "Молочные излелия", Price = 35 },
                new Product { Title = "Груши", Company = "Фрукты", Price = 50 },
                new Product { Title = "Бананы", Company = "Фрукты", Price = 70 },
                new Product { Title = "Яблоки", Company = "Фрукты", Price = 38 }

            };
            var groups = products.GroupBy(p => p.Company).Select(g => new Grouping<string, Product>(g.Key, g));
            ProductGroups = new ObservableCollection<Grouping<string, Product>>(groups);
            this.BindingContext = this;
        }
    }

    //public class Product
    //{
    //    public string Title { get; set; }
    //    public string Company { get; set; }
    //    public int Price { get; set; }
    //}
}