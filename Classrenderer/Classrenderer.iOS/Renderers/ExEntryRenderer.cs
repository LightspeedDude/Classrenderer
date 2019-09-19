using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Classrenderer.Controls;
using Classrenderer.iOS.Renderers;
using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExEntry), typeof(ExEntryRenderer))]

namespace Classrenderer.iOS.Renderers
{
    public class ExEntryRenderer: EntryRenderer
    {
        public ExEntryRenderer()
        {

        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                //Control.BorderStyle = UIKit.UITextBorderStyle.None;
                Control.BackgroundColor = UIColor.FromRGB(204, 153, 255);
                Control.BorderStyle = UITextBorderStyle.Line;
            }
        }
    }
}