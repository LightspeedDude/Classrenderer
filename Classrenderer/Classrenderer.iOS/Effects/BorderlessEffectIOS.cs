using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace Classrenderer.iOS.Effects
{
    public class BorderlessEffectIOS: PlatformEffect
    {

        protected override void OnAttached()
        {
            var control = Control as UITextField;
        }

        protected override void OnDetached()
        {
            
        }
    }
}