using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SfRating_GettingStarted
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            rating.ValueChanged += Rating_ValueChanged;
        }

        private void Rating_ValueChanged(object sender, Syncfusion.SfRating.XForms.ValueEventArgs e)
        {
            ratingLabel.Text = "Rating :" + " " + e.Value.ToString() + "/5";
        }
    }
}
