using CustomKerningSample.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(Label), typeof(CustomLabelRenderer))]
namespace CustomKerningSample.iOS.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            Control.AttributedText = new NSAttributedString(Element.Text, new UIStringAttributes
            {
                
                Font = ((UIFont.FromName(Element.FontFamily, (nfloat)Element.FontSize))),
                KerningAdjustment = characterSpacing
            });
        }

    }
}
