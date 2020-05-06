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
    public partial class LargeBranch : ContentPage
    {
        public event EventHandler BranchSnapped;

        public LargeBranch()
        {
            InitializeComponent();
        }

        private void SnapBranch(object sender, EventArgs e)
        {
            BranchSnapped(this, EventArgs.Empty);
        }
    }
}