using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CustomKerningSample.Controls
{
    public class CustomLabel : Label
    {

        public static readonly BindableProperty KerningProperty = BindableProperty.Create(
           propertyName: nameof(Kerning),
           returnType: typeof(float),
           declaringType: typeof(CustomLabel),
           defaultValue: 0.0f,
           defaultBindingMode: BindingMode.TwoWay);

        public float Kerning
        {
            get { return (float)GetValue(KerningProperty); }
            set { SetValue(KerningProperty, value); }
        }
    }
}
