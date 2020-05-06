using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SOFT262Task2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Branch : ContentPage
    {
        public Branch(string name)
        {
            Title = "Branch" + name;
            InitializeComponent();

            label.Text = "This is branch " + name;
        }
    }
}