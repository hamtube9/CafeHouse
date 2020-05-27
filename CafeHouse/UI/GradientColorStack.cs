using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CafeHouse.UI
{
    public class GradientColorStack : StackLayout
    {
        public static readonly BindableProperty StartColorProperty =
                    BindableProperty.Create(nameof(StartColor),returnType:typeof(Color), typeof(GradientColorStack), Color.FromHex("#FFFFFF"), BindingMode.TwoWay);
        public static readonly BindableProperty EndColorProperty =
                  BindableProperty.Create(nameof(EndColor), returnType: typeof(Color), typeof(GradientColorStack), Color.FromHex("#FFFFFF"), BindingMode.TwoWay);
        public Color StartColor
        {
            get { return (Color)GetValue(StartColorProperty); }
            set { SetValue(StartColorProperty, value); }
        }
        public Color EndColor
        {
            get { return (Color)GetValue(EndColorProperty); }
            set { SetValue(EndColorProperty, value); }
        }
        public GradientOrientation GradientColorOrientation
        {
            get; set;
        }
        // gradient orientation enum
        public enum GradientOrientation
        {
            Vertical,
            Horizontal
        }

    }

}
