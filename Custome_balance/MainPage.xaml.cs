using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Custome_balance
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        bool flag = false;
        public MainPage()
        {
            BindingContext = new Custome_property(flag, Color.FromHex("#e73895"));
            InitializeComponent();
        }

        private void TapFrame(object sender, EventArgs e)
        {
            
            BindingContext = new Custome_property(!flag, Color.FromHex("#e73895"));
            flag = !flag;

        }
    }
}
