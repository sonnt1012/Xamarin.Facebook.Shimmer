﻿using System.ComponentModel;
using Xamarin.Forms;
using System;

namespace Sample.Forms
{
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        {
            shimmerView.Play = !shimmerView.Play;
        }


        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}