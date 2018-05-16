using CustomKerningSample.Controls;
using CustomKerningSample.iOS.Renderers;
using Foundation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace CustomKerningSample.iOS.Renderers
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                var cLabel = Element as CustomLabel;
                Control.AttributedText = new NSAttributedString(Element.Text, new UIStringAttributes
                {
                    
                    Font =Control.Font,
                    KerningAdjustment = cLabel.Kerning 
                });
            }
        }
		protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
		{
            base.OnElementPropertyChanged(sender, e);
            var cLabel = Element as CustomLabel;
            if (CustomLabel.KerningProperty.PropertyName == e.PropertyName)
            {
                Control.AttributedText = new NSAttributedString(Element.Text, new UIStringAttributes
                {

                    Font = UIFont.SystemFontOfSize((nfloat)Element.FontSize),
                    KerningAdjustment = cLabel.Kerning
                });
            }
            else if (CustomLabel.TextProperty.PropertyName == e.PropertyName)
            {
                Control.AttributedText = new NSAttributedString(Element.Text, new UIStringAttributes
                {

                    Font = Control.Font,
                    KerningAdjustment = cLabel.Kerning
                });
            }
		}
	}
}
