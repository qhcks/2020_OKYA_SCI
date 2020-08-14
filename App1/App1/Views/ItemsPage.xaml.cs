using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using App1.Models;
using App1.Views;
using App1.ViewModels;
using Xamarin.Essentials;

namespace App1.Views
{
    public partial class ItemsPage : ContentPage
    {
        public Command TapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public string text = "hello";

        public ItemsPage()
        {
            InitializeComponent();
        }
    }
}