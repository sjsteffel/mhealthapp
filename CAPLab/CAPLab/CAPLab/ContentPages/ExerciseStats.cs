﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//This page is to contain the specific exercise stats generated by the app. 

namespace CAPLab
{
    class ExerciseStats : ContentPage
    {
        public ExerciseStats()
        {
            Icon = "exercise.png";
            var placeholderText = new Label
            {
                Text = "This page is to contain the specific exercise stats generated by the app."
            };

            //placeholder boxes
            Label box1Label = new Label {Text = "Exercise Graph 1" };
            BoxView box1 = new BoxView
            {
                Color = Color.Red
            };

            Label box2Label = new Label { Text = "Exercise Graph 2" };
            BoxView box2 = new BoxView
            {
                Color = Color.Gray
            };
            Label box3Label = new Label { Text = "Exercise Graph 3" };
            BoxView box3 = new BoxView
            {
                Color = Color.Red
            };

            Content = new StackLayout
            {
                Children =
                {
                    placeholderText,
                    box1Label,
                    box1,
                    box2Label,
                    box2,
                    box3Label,
                    box3
                }
            };
        }
    }
}
