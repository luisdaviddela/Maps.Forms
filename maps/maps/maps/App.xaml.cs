﻿using Plugin.Permissions.Abstractions;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace maps
{
    public partial class App : Application
    {
        //AIzaSyBWI942MSHzE_RoTg6SnrQEOPv3kzeS-hY
        public App()
        {
            InitializeComponent();

            MainPage = new TabbedPage()
            {
                Children =
                {
                    new MapsPage(),
                    new PinsPage(),
                    new MapsApi()

                }
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
