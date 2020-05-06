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
    public partial class Tree : ContentPage
    {
        public Tree()
        {
            

            InitializeComponent();
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Branch("A"));
        }
        private void Button2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Branch("B"));
        }
        private void Button3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Branch("C"));
        }

        private void Button4_Clicked(object sender, EventArgs e)
        {
            LargeBranchData data = new LargeBranchData(10f);
            LargeBranch branch = new LargeBranch();
            branch.BindingContext = data;
            branch.BranchSnapped += HandleLargeBranchSnap;
            Navigation.PushAsync(branch);
        }


        private void HandleLargeBranchSnap(object sender, EventArgs e)
        {
            label.Text += ", Large branch snapped";
        }
    }
}