using System;
using UIKit;

namespace CollectionViewSelfSizingCells
{
    public class Application
    {
        static void Main(string[] args)
        {
            try
            {
                UIApplication.Main(args, null, "AppDelegate");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}