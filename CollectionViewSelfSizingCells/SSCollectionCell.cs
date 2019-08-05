using System;
using Foundation;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    public class SSCollectionCell : UICollectionViewCell
    {
        public static readonly NSString Key = new NSString("SSCollectionCell");

        private UILabel _label;

        public SSCollectionCell(IntPtr handle) : base(handle)
        {
            Setup();
        }

        public void SetTitle(string text)
        {
            _label.Text = text;
        }

        private void Setup()
        {
            _label = new UILabel();

            // Notes:
            //
            // "If the application developer is using Auto Layout, setting this property to false
            // allows Auto Layout to change the layout of this UIView." (c) docs.microsoft.com
            _label.TranslatesAutoresizingMaskIntoConstraints = false;

            // Notes:
            //
            // there is no difference to use ContentView or work with cell directly
            // the same behavior actual for constraints also, but make sure
            // that if you add UIView to the ContentView - you should add constraints to ContentView
            // and vice verse for cell level
            AddSubviews(_label);

            // Notes:
            //
            // you can use Trailing and Leading instead Right and Left and vice verse
            NSLayoutConstraint.Create(_label, NSLayoutAttribute.Left, NSLayoutRelation.Equal, this, NSLayoutAttribute.Left, 1, 0).Active = true;
            NSLayoutConstraint.Create(_label, NSLayoutAttribute.Right, NSLayoutRelation.Equal, this, NSLayoutAttribute.Right, 1, 0).Active = true;
            NSLayoutConstraint.Create(_label, NSLayoutAttribute.Top, NSLayoutRelation.Equal, this, NSLayoutAttribute.Top, 1, 0).Active = true;
            NSLayoutConstraint.Create(_label, NSLayoutAttribute.Bottom, NSLayoutRelation.Equal, this, NSLayoutAttribute.Bottom, 1, 0).Active = true;

            ContentView.BackgroundColor = UIColor.Orange;
        }
    }
}
