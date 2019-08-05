using Foundation;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    [Register("AppDelegate")]
    public class AppDelegate : UIApplicationDelegate
    {
        public override UIWindow Window { get; set; }

        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            Window = new UIWindow(UIScreen.MainScreen.Bounds)
            {
                // Notes:
                // you can use usual ViewController
                // or UICollectionViewController as well
                //
                RootViewController = new SSHomeCollectionViewController()
                //RootViewController = new SSHomeViewController()
            };
            Window.MakeKeyAndVisible();
            return true;
        }
    }
}

