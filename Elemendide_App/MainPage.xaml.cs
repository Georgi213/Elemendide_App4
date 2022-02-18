using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendide_App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            //InitializeComponent();

            Button Ent_btn = new Button()
            {
                Text = "Entry",
                BackgroundColor = Color.LightBlue,
            };

            Button Timer_btn = new Button()
            {
                Text = "Timer",
                BackgroundColor = Color.LightBlue,
            };
            Button cliker = new Button()
            {
                Text = "Clicker",
                BackgroundColor = Color.LightBlue,
            };
            Button Date_btn = new Button()
            {
                Text = "Date",
                BackgroundColor = Color.LightBlue,
            };
            Button SS_btn = new Button()
            {
                Text = "Slider",
                BackgroundColor = Color.LightBlue,
            };
            Button frame_btn = new Button()
            {
                Text = "Frame page",
                BackgroundColor = Color.LightBlue,
            };
            frame_btn.Clicked += Frame_btn_Clicked;
            Button image_btn = new Button()
            {
                Text = "Picture",
                BackgroundColor = Color.LightBlue,
            };
            image_btn.Clicked += Image_btn_Clicked;
            Button Valgusfoor_btn = new Button()
            {
                Text = "Valgusfoor",
                BackgroundColor = Color.LightBlue,
            };
            Button RGB_Btn = new Button()
            {
                Text = "RGB-slider",
                BackgroundColor = Color.LightBlue,
            };
            RGB_Btn.Clicked += RGB_Btn_Clicked;
            Valgusfoor_btn.Clicked += Valgusfoor_btn_Clicked;
            StackLayout st = new StackLayout()
            {
                Children = { Ent_btn , Timer_btn , cliker , Date_btn , SS_btn , frame_btn , image_btn, Valgusfoor_btn, RGB_Btn }
            };

            st.BackgroundColor = Color.AntiqueWhite;
            Content = st;
            Ent_btn.Clicked += Ent_btn_Clicked;
            Timer_btn.Clicked += Timer_btn_Clicked;
            cliker.Clicked += Cliker_Clicked;
            Date_btn.Clicked += Date_btn_Clicked;
            SS_btn.Clicked += SS_btn_Clicked;
        }

        private async void RGB_Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RGB());
        }

        private async void Valgusfoor_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Valgusfoor());
        }

        private async void Image_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Image_page());
        }

        private async void Frame_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Frame_Page());
        }

        private async void SS_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StepperSlider_page());
        }

        private async void Date_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Date_Time());
        }

        private async void Cliker_Clicked(object sender, EventArgs e)
        {
             await Navigation.PushAsync(new cliker());
        }

        private async void Timer_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TimerPage());
        }

        private async void Ent_btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Ent_page());
        }
    }
    
}
